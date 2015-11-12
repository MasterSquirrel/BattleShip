namespace BattleShip
{
    partial class NosBateaux
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Grille = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Grille)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Grille
            // 
            this.DGV_Grille.AllowUserToAddRows = false;
            this.DGV_Grille.AllowUserToDeleteRows = false;
            this.DGV_Grille.AllowUserToResizeColumns = false;
            this.DGV_Grille.AllowUserToResizeRows = false;
            this.DGV_Grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Grille.ColumnHeadersVisible = false;
            this.DGV_Grille.Location = new System.Drawing.Point(12, 12);
            this.DGV_Grille.MultiSelect = false;
            this.DGV_Grille.Name = "DGV_Grille";
            this.DGV_Grille.ReadOnly = true;
            this.DGV_Grille.RowHeadersVisible = false;
            this.DGV_Grille.RowHeadersWidth = 16;
            this.DGV_Grille.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_Grille.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_Grille.Size = new System.Drawing.Size(404, 346);
            this.DGV_Grille.TabIndex = 2;
            this.DGV_Grille.SelectionChanged += new System.EventHandler(this.DGV_Grille_SelectionChanged);
            // 
            // NosBateaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 373);
            this.Controls.Add(this.DGV_Grille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NosBateaux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NosBateaux";
            this.Load += new System.EventHandler(this.NosBateaux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Grille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Grille;
    }
}