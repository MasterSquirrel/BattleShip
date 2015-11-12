using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class NosBateaux : Form
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
        List<BattleShip.Bateau> Bateaux = new List<BattleShip.Bateau>();
        List<String> ListeIndex = new List<String>();

        public NosBateaux(List<BattleShip.Bateau> MesBateaux,List<String> MewListeIndex)
        {
            InitializeComponent();
            Bateaux = MesBateaux;
            ListeIndex = MewListeIndex;

            // Créer la grille
            for (int i = 1; i <= 10; i++)
            {
                DGV_Grille.Columns.Add("", i.ToString());
                DGV_Grille.Columns[i - 1].Width = 40;
            }

            for (int i = 1; i <= 10; i++)
            {
                DGV_Grille.Rows.Add("");
                DGV_Grille.Rows[i - 1].Height = 34;
            }

            DessinerBateaux();
            MontrerLesTiresEnnemie();
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
        private void MontrerLesTiresEnnemie()
        {
            for(int i = 0; i < ListeIndex.Count; i++)
            {
                int PosX = 0;
                int PosY = 0;

                int Index = Int32.Parse(ListeIndex[i]);

                PosX = Math.Abs((9 - (Index % 10)));
                PosY = Index / 10;

                if (DGV_Grille.Rows[PosY].Cells[PosX].Style.BackColor == Color.Black)
                {
                    DGV_Grille.Rows[PosY].Cells[PosX].Style.BackColor = Color.Orange;
                }
                else
                {
                    DGV_Grille.Rows[PosY].Cells[PosX].Style.BackColor = Color.LightBlue;
                }
            }
        }
        private void NosBateaux_Load(object sender, EventArgs e)
        {

        }

        private void DGV_Grille_SelectionChanged(object sender, EventArgs e)
        {
            DGV_Grille.ClearSelection();
        }
    }
}
