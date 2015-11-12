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
    public partial class PlacerBateaux : Form
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

        // Largeur et hauteur de la grille
        const int Max = 10;
        bool Changing = false;
        public String SpotsBateaux = "";

        // Garde une liste des bateaux
        public List<BattleShip.Bateau> Bateaux = new List<BattleShip.Bateau>();

        // Socket du client
        public Socket sck;
        public bool connecterAuServeur = false;

        public PlacerBateaux()
        {
            InitializeComponent();

            // Créer la grille
            for (int i = 1; i <= 10; i++)
            {
                DGV_Grille.Columns.Add("", i.ToString());
                DGV_Grille.Columns[i-1].Width = 40;
            }

            for (int i = 1; i <= 10; i++)
            {
                DGV_Grille.Rows.Add("");
                DGV_Grille.Rows[i-1].Height = 34;
            }

            // Faire apparaîte les bateaux dans la grille
            Bateaux.Add(new Bateau(1, 1, false, 5));
            Bateaux.Add(new Bateau(2, 2, true,  4));
            Bateaux.Add(new Bateau(4, 5, false, 3));
            Bateaux.Add(new Bateau(4, 7, false, 3));
            Bateaux.Add(new Bateau(5, 9, false, 2));

            DessinerBateaux();
        }

        private void DessinerBateaux()
        {
            // Reset des couleurs
            for (int i = 0; i < Max; i++)
            {
                for (int j = 0; j < Max; j++)
                {
                    DGV_Grille.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }

            // Dessiner des carrés noirs où il y a les bateaux
            for (int i = 0; i < Bateaux.Count; i++)
            {
                Bateau Selection = Bateaux.ElementAt(i);
                Color CouleurUtiliser = Color.Black;

                // Horizontal ?
                if (Selection.Vertical == false)
                {
                    // En dehors de la grille
                    if (Selection.PosX + Selection.Longeur > Max)
                    {
                        CouleurUtiliser = Color.Red;
                    }

                    for (int j = Selection.PosX; j < Max && j < Selection.Longeur + Selection.PosX; j++)
                    {
                        if (DGV_Grille.Rows[Selection.PosY].Cells[j].Style.BackColor == CouleurUtiliser)
                        {
                            DGV_Grille.Rows[Selection.PosY].Cells[j].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            DGV_Grille.Rows[Selection.PosY].Cells[j].Style.BackColor = CouleurUtiliser;
                        }
                    }
                }
                else
                {
                    // Vertical

                    if (Selection.PosY + Selection.Longeur > Max)
                    {
                        CouleurUtiliser = Color.Red;
                    }

                    for (int j = Selection.PosY; j < Max && j < Selection.Longeur + Selection.PosY; j++)
                    {
                        if (DGV_Grille.Rows[j].Cells[Selection.PosX].Style.BackColor == CouleurUtiliser)
                        {
                            DGV_Grille.Rows[j].Cells[Selection.PosX].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            DGV_Grille.Rows[j].Cells[Selection.PosX].Style.BackColor = CouleurUtiliser;
                        }
                    }
                }
            }
        }

        private void TB_AdresseIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_AdresseIP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DGV_Grille_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            int NumColonne = e.ColumnIndex;
            int NumLigne = e.RowIndex;

            //DGV_Grille.Rows[NumLigne].Cells[NumColonne].Style.BackColor = Color.Red;

            if (DGV_Grille.Rows[NumLigne].Cells[NumColonne].Style.BackColor != Color.Black)
            {
                DGV_Grille.Rows[NumLigne].Cells[NumColonne].Style.BackColor = Color.Black;
            }
            else if (DGV_Grille.Rows[NumLigne].Cells[NumColonne].Style.BackColor == Color.Black)
            {
                DGV_Grille.Rows[NumLigne].Cells[NumColonne].Style.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Mauvaise couleur.");
            }

            DGV_Grille.ClearSelection();
            */
        }

        private void DGV_Grille_SelectionChanged(object sender, EventArgs e)
        {
            DGV_Grille.ClearSelection();
        }

        private void NUD_Horizontal_ValueChanged(object sender, EventArgs e)
        {
            if (!Changing)
            {
                if (RB_PorteAvion.Checked)
                {
                    Bateaux.ElementAt(0).PosX = Decimal.ToInt32(NUD_Horizontal.Value) - 1;
                    Bateaux.ElementAt(0).PosY = Decimal.ToInt32(NUD_Vectical.Value) - 1;
                }
                else if (RB_Croiseur.Checked)
                {
                    Bateaux.ElementAt(1).PosX = Decimal.ToInt32(NUD_Horizontal.Value) - 1;
                    Bateaux.ElementAt(1).PosY = Decimal.ToInt32(NUD_Vectical.Value) - 1;
                }
                else if (RB_ContreTorpilleur.Checked)
                {
                    Bateaux.ElementAt(2).PosX = Decimal.ToInt32(NUD_Horizontal.Value) - 1;
                    Bateaux.ElementAt(2).PosY = Decimal.ToInt32(NUD_Vectical.Value) - 1;
                }
                else if (RB_SousMarin.Checked)
                {
                    Bateaux.ElementAt(3).PosX = Decimal.ToInt32(NUD_Horizontal.Value) - 1;
                    Bateaux.ElementAt(3).PosY = Decimal.ToInt32(NUD_Vectical.Value) - 1;
                }
                else if (RB_Torpilleur.Checked)
                {
                    Bateaux.ElementAt(4).PosX = Decimal.ToInt32(NUD_Horizontal.Value) - 1;
                    Bateaux.ElementAt(4).PosY = Decimal.ToInt32(NUD_Vectical.Value) - 1;
                }
                else
                {
                    MessageBox.Show("Aucun bateau n'a été sélectionné. ");
                }
            }

            DessinerBateaux();
        }

        private void NUD_Vectical_ValueChanged(object sender, EventArgs e)
        {
            if (!Changing)
            {
                if (RB_PorteAvion.Checked)
                {
                    Bateaux.ElementAt(0).PosX = Decimal.ToInt32(NUD_Horizontal.Value) - 1;
                    Bateaux.ElementAt(0).PosY = Decimal.ToInt32(NUD_Vectical.Value) - 1;
                }
                else if (RB_Croiseur.Checked)
                {
                    Bateaux.ElementAt(1).PosX = Decimal.ToInt32(NUD_Horizontal.Value) - 1;
                    Bateaux.ElementAt(1).PosY = Decimal.ToInt32(NUD_Vectical.Value) - 1;
                }
                else if (RB_ContreTorpilleur.Checked)
                {
                    Bateaux.ElementAt(2).PosX = Decimal.ToInt32(NUD_Horizontal.Value) - 1;
                    Bateaux.ElementAt(2).PosY = Decimal.ToInt32(NUD_Vectical.Value) - 1;
                }
                else if (RB_SousMarin.Checked)
                {
                    Bateaux.ElementAt(3).PosX = Decimal.ToInt32(NUD_Horizontal.Value) - 1;
                    Bateaux.ElementAt(3).PosY = Decimal.ToInt32(NUD_Vectical.Value) - 1;
                }
                else if (RB_Torpilleur.Checked)
                {
                    Bateaux.ElementAt(4).PosX = Decimal.ToInt32(NUD_Horizontal.Value) - 1;
                    Bateaux.ElementAt(4).PosY = Decimal.ToInt32(NUD_Vectical.Value) - 1;
                }
                else
                {
                    MessageBox.Show("Aucun bateau n'a été sélectionné. ");
                }
            }

            DessinerBateaux();
        }

        private void AssignerPosBateauCocher()
        {
            Changing = true;

            if (RB_PorteAvion.Checked)
            {
                NUD_Horizontal.Value = Bateaux.ElementAt(0).PosX + 1;
                NUD_Vectical.Value = Bateaux.ElementAt(0).PosY + 1;
                CB_RotationVerticale.Checked = Bateaux.ElementAt(0).Vertical;
            }
            else if (RB_Croiseur.Checked)
            {
                NUD_Horizontal.Value = Bateaux.ElementAt(1).PosX + 1;
                NUD_Vectical.Value = Bateaux.ElementAt(1).PosY + 1;
                CB_RotationVerticale.Checked = Bateaux.ElementAt(1).Vertical;
            }
            else if (RB_ContreTorpilleur.Checked)
            {
                NUD_Horizontal.Value = Bateaux.ElementAt(2).PosX + 1;
                NUD_Vectical.Value = Bateaux.ElementAt(2).PosY + 1;
                CB_RotationVerticale.Checked = Bateaux.ElementAt(2).Vertical;
            }
            else if (RB_SousMarin.Checked)
            {
                NUD_Horizontal.Value = Bateaux.ElementAt(3).PosX + 1;
                NUD_Vectical.Value = Bateaux.ElementAt(3).PosY + 1;
                CB_RotationVerticale.Checked = Bateaux.ElementAt(3).Vertical;
            }
            else if (RB_Torpilleur.Checked)
            {
                NUD_Horizontal.Value = Bateaux.ElementAt(4).PosX + 1;
                NUD_Vectical.Value = Bateaux.ElementAt(4).PosY + 1;
                CB_RotationVerticale.Checked = Bateaux.ElementAt(4).Vertical;
            }
            else
            {
                MessageBox.Show("Aucun bateau n'a été sélectionné. ");
            }

            Changing = false;
        }

        private void RB_PorteAvion_CheckedChanged(object sender, EventArgs e)
        {
            AssignerPosBateauCocher();
        }

        private void RB_Croiseur_CheckedChanged(object sender, EventArgs e)
        {
            AssignerPosBateauCocher();
        }

        private void RB_ContreTorpilleur_CheckedChanged(object sender, EventArgs e)
        {
            AssignerPosBateauCocher();
        }

        private void RB_SousMarin_CheckedChanged(object sender, EventArgs e)
        {
            AssignerPosBateauCocher();
        }

        private void RB_Torpilleur_CheckedChanged(object sender, EventArgs e)
        {
            AssignerPosBateauCocher();
        }

        private void CB_RotationVerticale_CheckedChanged(object sender, EventArgs e)
        {
            if (!Changing)
            {
                if (RB_PorteAvion.Checked)
                {
                    Bateaux.ElementAt(0).Vertical = CB_RotationVerticale.Checked;
                }
                else if (RB_Croiseur.Checked)
                {
                    Bateaux.ElementAt(1).Vertical = CB_RotationVerticale.Checked;
                }
                else if (RB_ContreTorpilleur.Checked)
                {
                    Bateaux.ElementAt(2).Vertical = CB_RotationVerticale.Checked;
                }
                else if (RB_SousMarin.Checked)
                {
                    Bateaux.ElementAt(3).Vertical = CB_RotationVerticale.Checked;
                }
                else if (RB_Torpilleur.Checked)
                {
                    Bateaux.ElementAt(4).Vertical = CB_RotationVerticale.Checked;
                }
                else
                {
                    MessageBox.Show("Aucun bateau n'a été sélectionné. ");
                }
            }

            DessinerBateaux();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Encoder les bateaux dans le string
            bool Correct = true;
            SpotsBateaux = "";

            for (int i = 0; i < Max; i++)
            {
                for (int j = 0; j < Max; j++)
                {
                    if (DGV_Grille.Rows[i].Cells[9 - j].Style.BackColor == Color.Black)
                    {
                        SpotsBateaux = SpotsBateaux + "b";
                    }
                    else if (DGV_Grille.Rows[i].Cells[9 - j].Style.BackColor == Color.Red)
                    {
                        Correct = false;
                    }
                    else
                    {
                        SpotsBateaux = SpotsBateaux + "e";
                    }
                }
            }

            // Bouton pour commencer la partie
            if (Correct)
            {
                if (sck == null)
                    ConnecterAuServeur();

                /*string text = "J'envoie un message";
                byte[] data = Encoding.ASCII.GetBytes(text);

                sck.Send(data);*/
                if (connecterAuServeur == true)
                    this.Close();
                else
                    sck = null;
            }
        }

        private void BTN_Tester_Click(object sender, EventArgs e)
        {
            // Essayer de se connecter au Serveur tout de suite
            // Si la connexion réussie, on a le socket déja en place!
            ConnecterAuServeur();
        }

        private void ConnecterAuServeur()
        {
            try
            {
                sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse(TB_AdresseIP.Text), Int32.Parse(NUD_Port.Value.ToString()));
                try
                {
                    sck.Connect(localEndPoint);
                    MessageBox.Show("Connecter au serveur!");
                    connecterAuServeur = true;
                }
                catch
                {
                    MessageBox.Show("Échec de la connexion!");
                    connecterAuServeur = false;
                }
            }
            catch
            {
                MessageBox.Show("L'adresse Ip ou le Port est invalide!");
            }


        }

        private void DGV_Grille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PlacerBateaux_Load(object sender, EventArgs e)
        {

        }
    }
}
