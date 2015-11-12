using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace BattleShip
{
    public partial class Form1 : Form
    {
        /*class Bateau
        {
            public int PosX = 0;
            public int PosY = 0;
            public bool Vertical = false;
            public int Longeur = 3;

            public Bateau(int X, int Y, bool Orientation, int Long)
            {
                PosX = X;
                PosY = Y;
                Vertical = Orientation;
                Longeur = Long;
            }
        }*/

        // À propos de la chaine tableau
        // Elle représente ce qu'il y a dans l'environnement de jeu
        // e -> Eau, o -> Eau explosée, b -> bateau, x-> Bateau explosé
        String ChaineTableau = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
        string ParDefaut = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
        String MesPlacementsDeBateaux = "";

        // Garde une liste des bateaux
        List<BattleShip.Bateau> Bateaux = null;

        // Garde les références sur les picture box dans un array list, comme ça ils sont plus facile à utiliser.
        List<PictureBox> Tableau = new List<PictureBox>();

        // Socket du client, qu'on récupère a la création d'une partie par le formulaire PlacerBateaux
        Socket SocketClient = null;

        int NombreTir = 0;

        bool aJouerSonTour = false;
        string tempData = "";

        // Liste des positions(Index) que l'autre joueur a attaqué!
        List<String> ListeIndex = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fait par Alexandre-Xavier labonté-Lamoureux, 2015");
        }

        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlacerBateaux Placage = new PlacerBateaux();

            // Méthode bloquante pour ouvrir un form
            Placage.ShowDialog();

            if (Placage.sck != null && SocketClient == null && Placage.connecterAuServeur == true)
            {
                SocketClient = Placage.sck;
                ChaineTableau = Placage.SpotsBateaux;
                Bateaux = new List<Bateau>(Placage.Bateaux);
            }

            if (SocketClient != null && SocketClient.Connected)
            {

                // Premier message que j'envoie au serveur c'est les positions de mes bateaux
                string text = ChaineTableau;
                byte[] data = Encoding.ASCII.GetBytes(text);

                SocketClient.Send(data);
            }
            // La ligne suivante en commentaire c'est pour mettre un string de jeu dans le tableau
            //ChangerCouleurCasesSelonString(ChaineTableau);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On ferme le jeu, la confirmation se fait dans formClosing
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Avant d'initialiser les couelurs, faut remplir l'array de picture box
            RemplirListePictureBox();

            // Après, là on peut mettre les couleurs dedans
            InitiliserCouleursPictureBoxes(Color.LightCyan);
        }

        private void RemplirListePictureBox()
        {
            Tableau.Add(pictureBox1);
            Tableau.Add(pictureBox2);
            Tableau.Add(pictureBox3);
            Tableau.Add(pictureBox4);
            Tableau.Add(pictureBox5);
            Tableau.Add(pictureBox6);
            Tableau.Add(pictureBox7);
            Tableau.Add(pictureBox8);
            Tableau.Add(pictureBox9);

            Tableau.Add(pictureBox10);
            Tableau.Add(pictureBox11);
            Tableau.Add(pictureBox12);
            Tableau.Add(pictureBox13);
            Tableau.Add(pictureBox14);
            Tableau.Add(pictureBox15);
            Tableau.Add(pictureBox16);
            Tableau.Add(pictureBox17);
            Tableau.Add(pictureBox18);
            Tableau.Add(pictureBox19);

            Tableau.Add(pictureBox20);
            Tableau.Add(pictureBox21);
            Tableau.Add(pictureBox22);
            Tableau.Add(pictureBox23);
            Tableau.Add(pictureBox24);
            Tableau.Add(pictureBox25);
            Tableau.Add(pictureBox26);
            Tableau.Add(pictureBox27);
            Tableau.Add(pictureBox28);
            Tableau.Add(pictureBox29);

            Tableau.Add(pictureBox30);
            Tableau.Add(pictureBox31);
            Tableau.Add(pictureBox32);
            Tableau.Add(pictureBox33);
            Tableau.Add(pictureBox34);
            Tableau.Add(pictureBox35);
            Tableau.Add(pictureBox36);
            Tableau.Add(pictureBox37);
            Tableau.Add(pictureBox38);
            Tableau.Add(pictureBox39);

            Tableau.Add(pictureBox40);
            Tableau.Add(pictureBox41);
            Tableau.Add(pictureBox42);
            Tableau.Add(pictureBox43);
            Tableau.Add(pictureBox44);
            Tableau.Add(pictureBox45);
            Tableau.Add(pictureBox46);
            Tableau.Add(pictureBox47);
            Tableau.Add(pictureBox48);
            Tableau.Add(pictureBox49);

            Tableau.Add(pictureBox50);
            Tableau.Add(pictureBox51);
            Tableau.Add(pictureBox52);
            Tableau.Add(pictureBox53);
            Tableau.Add(pictureBox54);
            Tableau.Add(pictureBox55);
            Tableau.Add(pictureBox56);
            Tableau.Add(pictureBox57);
            Tableau.Add(pictureBox58);
            Tableau.Add(pictureBox59);

            Tableau.Add(pictureBox60);
            Tableau.Add(pictureBox61);
            Tableau.Add(pictureBox62);
            Tableau.Add(pictureBox63);
            Tableau.Add(pictureBox64);
            Tableau.Add(pictureBox65);
            Tableau.Add(pictureBox66);
            Tableau.Add(pictureBox67);
            Tableau.Add(pictureBox68);
            Tableau.Add(pictureBox69);

            Tableau.Add(pictureBox70);
            Tableau.Add(pictureBox71);
            Tableau.Add(pictureBox72);
            Tableau.Add(pictureBox73);
            Tableau.Add(pictureBox74);
            Tableau.Add(pictureBox75);
            Tableau.Add(pictureBox76);
            Tableau.Add(pictureBox77);
            Tableau.Add(pictureBox78);
            Tableau.Add(pictureBox79);

            Tableau.Add(pictureBox80);
            Tableau.Add(pictureBox81);
            Tableau.Add(pictureBox82);
            Tableau.Add(pictureBox83);
            Tableau.Add(pictureBox84);
            Tableau.Add(pictureBox85);
            Tableau.Add(pictureBox86);
            Tableau.Add(pictureBox87);
            Tableau.Add(pictureBox88);
            Tableau.Add(pictureBox89);

            Tableau.Add(pictureBox90);
            Tableau.Add(pictureBox91);
            Tableau.Add(pictureBox92);
            Tableau.Add(pictureBox93);
            Tableau.Add(pictureBox94);
            Tableau.Add(pictureBox95);
            Tableau.Add(pictureBox96);
            Tableau.Add(pictureBox97);
            Tableau.Add(pictureBox98);
            Tableau.Add(pictureBox99);

            Tableau.Add(pictureBox100);
        }

        private void InitiliserCouleursPictureBoxes(Color Couleur)
        {
            // Initialiser les boîtes à la bonne couleur
            foreach (PictureBox pb in Tableau)
            {
                pb.BackColor = Couleur;
            }

            ChaineTableau = ParDefaut;
        }

        // Update la grille du jeu selon l'état
        private void ChangerCouleurCasesSelonString(string CharPourCase)
        {
            int i = 0;

            foreach (PictureBox pb in Tableau)
            {
                switch (CharPourCase.ElementAt(i))
                {
                    case 'e':
                        pb.BackColor = Color.LightCyan;
                        break;

                    case 'o':
                        pb.BackColor = Color.LightSkyBlue;
                        break;

                    case 'b':
                        pb.BackColor = Color.DimGray;
                        break;

                    case 'x':
                        pb.BackColor = Color.DarkOrange;
                        break;

                    default:
                        MessageBox.Show("Erreur: Couleur indéfinie!");
                        break;
                }

                i++;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // On ferme le jeu, envoyer au serveur une commande qui dit qu'on part. 
            var res = MessageBox.Show(this, "Êtes-vous sûr de vouloir quitter?", "Fermer le jeu",
            MessageBoxButtons.YesNo);

            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
        }

        // Ligne 1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReagirClique(0, 0, "10");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReagirClique(1, 0, "9");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ReagirClique(2, 0, "8");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ReagirClique(3, 0, "7");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ReagirClique(4, 0, "6");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ReagirClique(5, 0, "5");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ReagirClique(6, 0, "4");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ReagirClique(7, 0, "3");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ReagirClique(8, 0, "2");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ReagirClique(9, 0, "1");
        }

        // Ligne 2
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            ReagirClique(9, 1, "1");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            ReagirClique(8, 1, "2");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            ReagirClique(7, 1, "3");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            ReagirClique(6, 1, "4");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            ReagirClique(5, 1, "5");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            ReagirClique(4, 1, "6");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            ReagirClique(3, 1, "7");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ReagirClique(2, 1, "8");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ReagirClique(1, 1, "9");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ReagirClique(0, 1, "10");
        }

        // ligne 3
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            ReagirClique(9, 2, "1");
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            ReagirClique(8, 2, "2");
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            ReagirClique(7, 2, "3");
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            ReagirClique(6, 2, "4");
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            ReagirClique(5, 2, "5");
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            ReagirClique(4, 2, "6");
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            ReagirClique(3, 2, "7");
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            ReagirClique(2, 2, "8");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ReagirClique(1, 2, "9");
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            ReagirClique(0, 2, "10");
        }


        // Ligne 4
        private void pictureBox40_Click(object sender, EventArgs e)
        {
            ReagirClique(9, 3, "1");
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            ReagirClique(8, 3, "2");
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            ReagirClique(7, 3, "3");
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            ReagirClique(6, 3, "4");
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            ReagirClique(5, 3, "5");
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            ReagirClique(4, 3, "6");
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            ReagirClique(3, 3, "7");
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            ReagirClique(2, 3, "8");
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            ReagirClique(1, 3, "9");
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            ReagirClique(0, 3, "10");
        }

        // ligne 5
        private void pictureBox50_Click(object sender, EventArgs e)
        {
            ReagirClique(9, 4, "1");
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            ReagirClique(8, 4, "2");
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            ReagirClique(7, 4, "3");
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            ReagirClique(6, 4, "4");
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            ReagirClique(5, 4, "5");
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            ReagirClique(4, 4, "6");
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            ReagirClique(3, 4, "7");
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            ReagirClique(2, 4, "8");
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            ReagirClique(1, 4, "9");
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            ReagirClique(0, 4, "10");
        }

        // ligne 6
        private void pictureBox60_Click(object sender, EventArgs e)
        {
            ReagirClique(9, 5, "1");
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            ReagirClique(8, 5, "2");
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            ReagirClique(7, 5, "3");
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            ReagirClique(6, 5, "4");
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            ReagirClique(5, 5, "5");
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            ReagirClique(4, 5, "6");
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            ReagirClique(3, 5, "7");
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            ReagirClique(2, 5, "8");
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            ReagirClique(1, 5, "9");
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            ReagirClique(0, 5, "10");
        }

        // ligne 7
        private void pictureBox70_Click(object sender, EventArgs e)
        {
            ReagirClique(9, 6, "1");
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            ReagirClique(8, 6, "2");
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            ReagirClique(7, 6, "3");
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            ReagirClique(6, 6, "4");
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            ReagirClique(5, 6, "5");
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            ReagirClique(4, 6, "6");
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            ReagirClique(3, 6, "7");
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            ReagirClique(2, 6, "8");
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            ReagirClique(1, 6, "9");
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            ReagirClique(0, 6, "10");
        }

        // ligne 8
        private void pictureBox80_Click(object sender, EventArgs e)
        {
            ReagirClique(9, 7, "1");
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            ReagirClique(8, 7, "2");
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            ReagirClique(7, 7, "3");
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            ReagirClique(6, 7, "4");
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            ReagirClique(5, 7, "5");
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            ReagirClique(4, 7, "6");
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            ReagirClique(3, 7, "7");
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            ReagirClique(2, 7, "8");
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            ReagirClique(1, 7, "9");
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            ReagirClique(0, 7, "10");
        }

        // ligne 9
        private void pictureBox90_Click(object sender, EventArgs e)
        {
            ReagirClique(9, 8, "1");
        }

        private void pictureBox89_Click(object sender, EventArgs e)
        {
            ReagirClique(8, 8, "2");
        }

        private void pictureBox88_Click(object sender, EventArgs e)
        {
            ReagirClique(7, 8, "3");
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            ReagirClique(6, 8, "4");
        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            ReagirClique(5, 8, "5");
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {
            ReagirClique(4, 8, "6");
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            ReagirClique(3, 8, "7");
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            ReagirClique(2, 8, "8");
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            ReagirClique(1, 8, "9");
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            ReagirClique(0, 8, "10");
        }


        // ligne 10
        private void pictureBox100_Click(object sender, EventArgs e)
        {
            ReagirClique(9, 9, "1");
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            ReagirClique(8, 9, "2");
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            ReagirClique(7, 9, "3");
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            ReagirClique(6, 9, "4");
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {
            ReagirClique(5, 9, "5");
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            ReagirClique(4, 9, "6");
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {
            ReagirClique(3, 9, "7");
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            ReagirClique(2, 9, "8");
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {
            ReagirClique(1, 9, "9");
        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {
            ReagirClique(0, 9, "10");
        }
        // fin des détecteurs d'évènements sur les picture box


        // méthode pour est utilisée pour la réaction au clique
        private void ReagirClique(int PosX, int PosY, string PositionQuonDitQueCestLaEnX)
        {
            if (SocketClient != null)
            {
                if (!PartieFini())
                {
                    // Ne pas attaquer deux fois a la même endroit
                    int z = 0;
                    bool continuer = false;
                    // il devrait y avoir 100 éléments dedans
                    while (z < Tableau.Count)
                    {
                        if (z / 10 == PosY && z % 10 == PosX)
                        {
                            // Il y a de l'eau, donc on continue
                            if (Tableau.ElementAt(z).BackColor == Color.LightCyan)
                            {
                                continuer = true;
                            }
                        }

                        z++;
                    }
                    if (continuer)
                    {
                        bool BateauEnnemiTouche = false;
                        // Les position reçus sont de 0 à 9

                        char PosVerticale = 'A';

                        // Convertir la position Y en lettre, car l'axe vertical est composé de lettres.
                        for (int i = 0; i < PosY; i++)
                        {
                            PosVerticale++;
                        }

                        string strData3 = "";
                        String Index = "";
                        if (SocketClient.Connected)
                        {
                            // Vérifier si l'ennemi a attaquer 
                            byte[] Buffer3 = new byte[SocketClient.SendBufferSize];

                            SocketClient.ReceiveTimeout = 10;
                            try
                            {
                                int bytesRead3 = SocketClient.Receive(Buffer3);

                                byte[] formatted3 = new byte[bytesRead3];
                                for (int a = 0; a < bytesRead3; a++)
                                {
                                    formatted3[a] = Buffer3[a];
                                }
                                strData3 = Encoding.ASCII.GetString(formatted3);
                                String[] chaines = strData3.Split(',');
                                if (strData3 != "")
                                {
                                    strData3 = chaines[0];
                                    ListeIndex.Add(chaines[1]);
                                }
                            }
                            catch (SocketException se)
                            {

                            }
                            try
                            {

                                if ((strData3 != "" && (strData3 == "L'ennemi a touche un bateau" || strData3 == "L'ennemi a manque son tir" || NombreTir == 0/*C'est pour jouer le premier tour*/)) || NombreTir == 0 || !aJouerSonTour)
                                {
                                    aJouerSonTour = false;
                                    // Garder en mémoire le teste envoyer par le serveur (C'est une sécuriter)
                                    if (strData3 != "")
                                        tempData = strData3;

                                    // Demander si on execute le move
                                    DialogResult Executer = MessageBox.Show("Vous avez choisi la postion (" + PositionQuonDitQueCestLaEnX +
                                        ", " + PosVerticale + "). Voulez-vous lancer une torpille?",
                                        "Executer l'attaque?", MessageBoxButtons.YesNo);

                                    if (Executer == DialogResult.Yes)
                                    {
                                        strData3 = tempData;

                                        RTB_Messages.AppendText(strData3 + "\n");

                                        if (RTB_Messages.Visible)
                                        {
                                            RTB_Messages.SelectionStart = RTB_Messages.TextLength;
                                            RTB_Messages.ScrollToCaret();
                                        }

                                        if (strData3 == "L'ennemi a touche un bateau")
                                            LBL_MesBateauxTouches.Text = (Int32.Parse(LBL_MesBateauxTouches.Text) + 1).ToString();

                                        // Envoyer au serveur la position 
                                        //ConnecterAuServeur();
                                        /*string text =   "Vous avez choisi la postion (" + PositionQuonDitQueCestLaEnX + 
                                                        ", " + PosVerticale + ").";*/
                                        string text = PosX.ToString() + "," + PosY.ToString();
                                        byte[] data = Encoding.ASCII.GetBytes(text);

                                        SocketClient.Send(data);

                                        // Recois la confirmation par le serveur s'il a touché un bateau!
                                        byte[] Buffer2 = new byte[SocketClient.SendBufferSize];

                                        SocketClient.ReceiveTimeout = 10;
                                        try
                                        {
                                            int bytesRead2 = SocketClient.Receive(Buffer2);

                                            byte[] formatted2 = new byte[bytesRead2];
                                            for (int j = 0; j < bytesRead2; j++)
                                            {
                                                formatted2[j] = Buffer2[j];
                                            }

                                            string strData2 = Encoding.ASCII.GetString(formatted2);
                                            if (strData2 == "Toucher")
                                            {
                                                BateauEnnemiTouche = true;
                                                RTB_Messages.AppendText("Touché! \n");
                                                if (RTB_Messages.Visible)
                                                {
                                                    RTB_Messages.SelectionStart = RTB_Messages.TextLength;
                                                    RTB_Messages.ScrollToCaret();
                                                }
                                            }
                                            else
                                            {
                                                RTB_Messages.AppendText("À l'eau! \n");
                                                if (RTB_Messages.Visible)
                                                {
                                                    RTB_Messages.SelectionStart = RTB_Messages.TextLength;
                                                    RTB_Messages.ScrollToCaret();
                                                }
                                            }
                                        }
                                        catch (SocketException se)
                                        {

                                        }

                                        // Executer

                                        int i = 0;

                                        // il devrait y avoir 100 éléments dedans
                                        while (i < Tableau.Count)
                                        {
                                            if (i / 10 == PosY && i % 10 == PosX)
                                            {
                                                // Il y a un bateau
                                                if (Tableau.ElementAt(i).BackColor == Color.DimGray || BateauEnnemiTouche)
                                                {
                                                    // Couleur sautée
                                                    Tableau.ElementAt(i).BackColor = Color.DarkOrange;
                                                    ChaineTableau.Remove(i);
                                                    ChaineTableau.Insert(i, "x");
                                                }
                                                // C'est de l'eau
                                                else if (Tableau.ElementAt(i).BackColor == Color.LightCyan)
                                                {
                                                    // Couleur eau éclatée
                                                    Tableau.ElementAt(i).BackColor = Color.SkyBlue;
                                                    ChaineTableau.Remove(i);
                                                    ChaineTableau.Insert(i, "o");
                                                }

                                                //RTB_Messages.AppendText("Vous avez attaqué la position (" + PositionQuonDitQueCestLaEnX + ", " + PosVerticale + ")." + "\n");
                                            }

                                            i++;
                                        }
                                        aJouerSonTour = true;
                                    }
                                }
                                else
                                {
                                    RTB_Messages.AppendText("En attente du tour de l'autre joueur! \n");
                                    if (RTB_Messages.Visible)
                                    {
                                        RTB_Messages.SelectionStart = RTB_Messages.TextLength;
                                        RTB_Messages.ScrollToCaret();
                                    }
                                }
                            }
                            catch (SocketException se)
                            {

                            }

                        }

                        CompterNombreBateauTouche();

                        // Sinon on fait rien

                        NombreTir++;
                    }
                    else // Il a attaqué deux fois a la même endroit
                    {
                        MessageBox.Show("Ne pas attaquer deux foix a la même endroit!");
                    }
                }
                else// La partie est fini
                {
                    MessageBox.Show("La partie est fini!");
                }
            }
            else // Le socket est null, donc aucune partie en cours
            {
                MessageBox.Show("Démarrer une partie!");
            }
        }

        private void CompterNombreBateauTouche()
        {
            int NombreBateauEnnemiTouche = 0;

            int i = 0;

            // il devrait y avoir 100 éléments dedans
            while (i < Tableau.Count)
            {
                // Il y a un bateau
                if (Tableau.ElementAt(i).BackColor == Color.DarkOrange)
                {
                    NombreBateauEnnemiTouche++;
                }
                i++;
            }

            // Update le label qui indique le nombre de bateau ennemi touché
            LBL_BateauxEnnemisTouches.Text = NombreBateauEnnemiTouche.ToString();
        }

        // La partie est fini quand 17 bateaux est touchés!
        private bool PartieFini()
        {
            bool estFini = false;

            if (LBL_BateauxEnnemisTouches.Text == "17")
            {
                MessageBox.Show("Vous avez gagné!");
                estFini = true;
            }
            else if (LBL_MesBateauxTouches.Text == "17")
            {
                MessageBox.Show("Vous avez perdu!");
                estFini = true;
            }

            return estFini;
        }

        private void BTN_AfficherMesBateaux_Click(object sender, EventArgs e)
        {
            if (Bateaux != null)
            {
                NosBateaux form = new NosBateaux(Bateaux, ListeIndex);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Démarrer une partie!");
            }
        }
    }
}
