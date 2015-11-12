using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Serveur
{
    class Program
    {
        static byte[] Buffer1 { get; set; }
        static byte[] Buffer2 { get; set; }
        static Socket SocketServeur;
        static Socket SocketClient1;
        static Socket SocketClient2;
        static int Port = 0;

        static String ChaineTableauClient1;
        static String ChaineTableauClient2;

        static void Main(string[] args)
        {
            Console.Title = "Serveur BattleShip";

            EntrerUnPort();

            Console.WriteLine("Serveur en cours de démarrage!");

            AttendreDeuxConnexions();
        }

        public static void EntrerUnPort()
        {
            do
            {
                Console.Write("Entrez le port TCP/IP: ");
                string StringPort = Console.ReadLine();
                try
                {
                    Port = Int32.Parse(StringPort);
                    if (Port <= 0 || Port > 65535)
                    {
                        Port = 0;
                        Console.WriteLine("Le port doit etre entre 1 et 65535");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur dans le Parse int!");
                }
            } while (Port == 0);

            Console.WriteLine("Le port est: " + Port.ToString() + "!");
        }

        public static void AttendreDeuxConnexions()
        {
            try
            {
                SocketServeur = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                SocketServeur.Bind(new IPEndPoint(0, Port));
                SocketServeur.Listen(100);


                SocketClient1 = SocketServeur.Accept();
                // Avant de lancer un thread pour gérer les attaques du client,
                // il faut récupérer son premier message qui va être sa ChaineTableau,
                // donc la position de ses bateaux
                Buffer1 = new byte[SocketClient1.SendBufferSize];

                int bytesRead1 = SocketClient1.Receive(Buffer1);

                byte[] formatted1 = new byte[bytesRead1];
                for (int i = 0; i < bytesRead1; i++)
                {
                    formatted1[i] = Buffer1[i];
                }

                string strData1 = Encoding.ASCII.GetString(formatted1);
                ChaineTableauClient1 = strData1;
                Console.Write(ChaineTableauClient1 + " Client 1 \r\n");

                SocketClient2 = SocketServeur.Accept();
                // Avant de lancer un thread pour gérer les attaques du client,
                // il faut récupérer son premier message qui va être sa ChaineTableau,
                // donc la position de ses bateaux
                Buffer2 = new byte[SocketClient2.SendBufferSize];

                int bytesRead2 = SocketClient2.Receive(Buffer2);

                byte[] formatted2 = new byte[bytesRead2];
                for (int i = 0; i < bytesRead2; i++)
                {
                    formatted2[i] = Buffer2[i];
                }

                string strData2 = Encoding.ASCII.GetString(formatted2);
                ChaineTableauClient2 = strData2;
                Console.Write(ChaineTableauClient2 + " Client 2 \r\n");

                Thread ThreadClient1 = new Thread(new ThreadStart(TraiterClient1));
                // Lancement du thread
                ThreadClient1.Start();

                Thread ThreadClient2 = new Thread(new ThreadStart(TraiterClient2));
                // Lancement du thread
                ThreadClient2.Start();

                // Bouclé tant que les deux clients sont connectés
                while (SocketClient1.Connected && SocketClient2.Connected)
                {
                    // ew
                    Thread.Sleep(5);
                }
                // Si l'un des deux clients ce déconnecte, fermer tout!
                ThreadClient1.Abort();
                ThreadClient2.Abort();
                SocketServeur.Close();
                SocketClient1.Close();
                SocketClient2.Close();
            }
            catch(SocketException)
            {

            }

        }

        public static void TraiterClient1()
        {
            try
            {
                while (SocketClient1 != null && SocketClient1.Connected)
                {

                    Buffer1 = new byte[SocketClient1.SendBufferSize];

                    int bytesRead1 = SocketClient1.Receive(Buffer1);

                    byte[] formatted1 = new byte[bytesRead1];
                    for (int i = 0; i < bytesRead1; i++)
                    {
                        formatted1[i] = Buffer1[i];
                    }

                    string strData1 = Encoding.ASCII.GetString(formatted1);
                    Console.Write(strData1 + " Client 1 \r\n");

                    // Récupérer la position X et Y et vérifier si sa toucher un bateau ennemi!
                    if (strData1.Contains(','))
                    {
                        string text = "";
                        byte[] data;

                        string text2 = "";
                        byte[] data2;

                        String[] Strings = strData1.Split(',');
                        int PosY = Int32.Parse(Strings[1]);
                        int PosX = Int32.Parse(Strings[0]);
                        int Index = (PosY * 10) + PosX;

                        if (ChaineTableauClient2[Index] == 'b')
                        {                           
                            text = "Toucher";
                            data = Encoding.ASCII.GetBytes(text);

                            text2 = "L'ennemi a touche un bateau," + Index.ToString();
                            data2 = Encoding.ASCII.GetBytes(text2);

                            SocketClient1.Send(data);
                            SocketClient2.Send(data2);
                            Console.WriteLine("Bateau ennemi touché!," + Index.ToString());
                        }
                        else
                        {
                            text = "Manquer";
                            data = Encoding.ASCII.GetBytes(text);

                            text2 = "L'ennemi a manque son tir," + Index.ToString();
                            data2 = Encoding.ASCII.GetBytes(text2);

                            SocketClient1.Send(data);
                            SocketClient2.Send(data2);
                            Console.WriteLine("Bateau ennemi manqué!");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur dans la fonction TraiterClient1.");
            }
        }

        public static void TraiterClient2()
        {
            try
            {
                while (SocketClient2 != null && SocketClient2.Connected)
                {
                    Buffer2 = new byte[SocketClient2.SendBufferSize];

                    int bytesRead2 = SocketClient2.Receive(Buffer2);

                    byte[] formatted2 = new byte[bytesRead2];
                    for (int i = 0; i < bytesRead2; i++)
                    {
                        formatted2[i] = Buffer2[i];
                    }

                    string strData2 = Encoding.ASCII.GetString(formatted2);
                    Console.Write(strData2 + " Client 2 \r\n");

                    // Pour être sur qu'on recois des positions x et y
                    if (strData2.Contains(','))
                    {
                        string text = "";
                        byte[] data;

                        string text2 = "";
                        byte[] data2;
                        // Récupérer la position X et Y et vérifier si sa toucher un bateau ennemi!
                        String[] Strings = strData2.Split(',');
                        int PosY = Int32.Parse(Strings[1]);
                        int PosX = Int32.Parse(Strings[0]);
                        int Index = (PosY * 10) + PosX;



                        if (ChaineTableauClient1[Index] == 'b')
                        {
                            text = "Toucher";
                            data = Encoding.ASCII.GetBytes(text);

                            text2 = "L'ennemi a touche un bateau," + Index.ToString();
                            data2 = Encoding.ASCII.GetBytes(text2);

                            SocketClient2.Send(data);
                            SocketClient1.Send(data2);
                            Console.WriteLine("Bateau ennemi touché!," + Index.ToString());
                        }
                        else
                        {
                            text = "Manquer";
                            data = Encoding.ASCII.GetBytes(text);

                            text2 = "L'ennemi a manque son tir," + Index.ToString();
                            data2 = Encoding.ASCII.GetBytes(text2);

                            SocketClient2.Send(data);
                            SocketClient1.Send(data2);
                            Console.WriteLine("Bateau ennemi manqué!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur dans la fonction TraiterClient2.");
            }
        }
    }
}
