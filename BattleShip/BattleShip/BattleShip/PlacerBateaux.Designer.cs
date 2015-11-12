namespace BattleShip
{
    partial class PlacerBateaux
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
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Bateaux = new System.Windows.Forms.GroupBox();
            this.RB_Torpilleur = new System.Windows.Forms.RadioButton();
            this.RB_SousMarin = new System.Windows.Forms.RadioButton();
            this.RB_ContreTorpilleur = new System.Windows.Forms.RadioButton();
            this.RB_Croiseur = new System.Windows.Forms.RadioButton();
            this.RB_PorteAvion = new System.Windows.Forms.RadioButton();
            this.GB_Position = new System.Windows.Forms.GroupBox();
            this.NUD_Vectical = new System.Windows.Forms.NumericUpDown();
            this.NUD_Horizontal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GB_Rotation = new System.Windows.Forms.GroupBox();
            this.CB_RotationVerticale = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GB_OptionsReseau = new System.Windows.Forms.GroupBox();
            this.BTN_Tester = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NUD_Port = new System.Windows.Forms.NumericUpDown();
            this.TB_AdresseIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_Infos = new System.Windows.Forms.Label();
            this.BTN_Debuter = new System.Windows.Forms.Button();
            this.DGV_Grille = new System.Windows.Forms.DataGridView();
            this.GB_Bateaux.SuspendLayout();
            this.GB_Position.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Vectical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Horizontal)).BeginInit();
            this.GB_Rotation.SuspendLayout();
            this.GB_OptionsReseau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Grille)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placer chaque bateau et utilisant les boutons de sélection pous régler leur posit" +
    "ion et leur orientation.";
            // 
            // GB_Bateaux
            // 
            this.GB_Bateaux.Controls.Add(this.RB_Torpilleur);
            this.GB_Bateaux.Controls.Add(this.RB_SousMarin);
            this.GB_Bateaux.Controls.Add(this.RB_ContreTorpilleur);
            this.GB_Bateaux.Controls.Add(this.RB_Croiseur);
            this.GB_Bateaux.Controls.Add(this.RB_PorteAvion);
            this.GB_Bateaux.Location = new System.Drawing.Point(426, 40);
            this.GB_Bateaux.Name = "GB_Bateaux";
            this.GB_Bateaux.Size = new System.Drawing.Size(189, 150);
            this.GB_Bateaux.TabIndex = 2;
            this.GB_Bateaux.TabStop = false;
            this.GB_Bateaux.Text = "Bateaux à placer";
            // 
            // RB_Torpilleur
            // 
            this.RB_Torpilleur.AutoSize = true;
            this.RB_Torpilleur.Location = new System.Drawing.Point(15, 112);
            this.RB_Torpilleur.Name = "RB_Torpilleur";
            this.RB_Torpilleur.Size = new System.Drawing.Size(68, 17);
            this.RB_Torpilleur.TabIndex = 4;
            this.RB_Torpilleur.TabStop = true;
            this.RB_Torpilleur.Text = "Torpilleur";
            this.RB_Torpilleur.UseVisualStyleBackColor = true;
            this.RB_Torpilleur.CheckedChanged += new System.EventHandler(this.RB_Torpilleur_CheckedChanged);
            // 
            // RB_SousMarin
            // 
            this.RB_SousMarin.AutoSize = true;
            this.RB_SousMarin.Location = new System.Drawing.Point(15, 89);
            this.RB_SousMarin.Name = "RB_SousMarin";
            this.RB_SousMarin.Size = new System.Drawing.Size(77, 17);
            this.RB_SousMarin.TabIndex = 3;
            this.RB_SousMarin.TabStop = true;
            this.RB_SousMarin.Text = "Sous-marin";
            this.RB_SousMarin.UseVisualStyleBackColor = true;
            this.RB_SousMarin.CheckedChanged += new System.EventHandler(this.RB_SousMarin_CheckedChanged);
            // 
            // RB_ContreTorpilleur
            // 
            this.RB_ContreTorpilleur.AutoSize = true;
            this.RB_ContreTorpilleur.Location = new System.Drawing.Point(15, 65);
            this.RB_ContreTorpilleur.Name = "RB_ContreTorpilleur";
            this.RB_ContreTorpilleur.Size = new System.Drawing.Size(98, 17);
            this.RB_ContreTorpilleur.TabIndex = 2;
            this.RB_ContreTorpilleur.TabStop = true;
            this.RB_ContreTorpilleur.Text = "Contre-torpilleur";
            this.RB_ContreTorpilleur.UseVisualStyleBackColor = true;
            this.RB_ContreTorpilleur.CheckedChanged += new System.EventHandler(this.RB_ContreTorpilleur_CheckedChanged);
            // 
            // RB_Croiseur
            // 
            this.RB_Croiseur.AutoSize = true;
            this.RB_Croiseur.Location = new System.Drawing.Point(15, 42);
            this.RB_Croiseur.Name = "RB_Croiseur";
            this.RB_Croiseur.Size = new System.Drawing.Size(63, 17);
            this.RB_Croiseur.TabIndex = 1;
            this.RB_Croiseur.Text = "Croiseur";
            this.RB_Croiseur.UseVisualStyleBackColor = true;
            this.RB_Croiseur.CheckedChanged += new System.EventHandler(this.RB_Croiseur_CheckedChanged);
            // 
            // RB_PorteAvion
            // 
            this.RB_PorteAvion.AutoSize = true;
            this.RB_PorteAvion.Checked = true;
            this.RB_PorteAvion.Location = new System.Drawing.Point(15, 19);
            this.RB_PorteAvion.Name = "RB_PorteAvion";
            this.RB_PorteAvion.Size = new System.Drawing.Size(79, 17);
            this.RB_PorteAvion.TabIndex = 0;
            this.RB_PorteAvion.TabStop = true;
            this.RB_PorteAvion.Text = "Porte-avion";
            this.RB_PorteAvion.UseVisualStyleBackColor = true;
            this.RB_PorteAvion.CheckedChanged += new System.EventHandler(this.RB_PorteAvion_CheckedChanged);
            // 
            // GB_Position
            // 
            this.GB_Position.Controls.Add(this.NUD_Vectical);
            this.GB_Position.Controls.Add(this.NUD_Horizontal);
            this.GB_Position.Controls.Add(this.label3);
            this.GB_Position.Controls.Add(this.label2);
            this.GB_Position.Location = new System.Drawing.Point(426, 197);
            this.GB_Position.Name = "GB_Position";
            this.GB_Position.Size = new System.Drawing.Size(189, 95);
            this.GB_Position.TabIndex = 3;
            this.GB_Position.TabStop = false;
            this.GB_Position.Text = "Positionnement";
            // 
            // NUD_Vectical
            // 
            this.NUD_Vectical.Location = new System.Drawing.Point(72, 49);
            this.NUD_Vectical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Vectical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Vectical.Name = "NUD_Vectical";
            this.NUD_Vectical.Size = new System.Drawing.Size(41, 20);
            this.NUD_Vectical.TabIndex = 3;
            this.NUD_Vectical.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUD_Vectical.ValueChanged += new System.EventHandler(this.NUD_Vectical_ValueChanged);
            // 
            // NUD_Horizontal
            // 
            this.NUD_Horizontal.Location = new System.Drawing.Point(72, 23);
            this.NUD_Horizontal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Horizontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Horizontal.Name = "NUD_Horizontal";
            this.NUD_Horizontal.Size = new System.Drawing.Size(41, 20);
            this.NUD_Horizontal.TabIndex = 2;
            this.NUD_Horizontal.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUD_Horizontal.ValueChanged += new System.EventHandler(this.NUD_Horizontal_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vertical";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Horizontal";
            // 
            // GB_Rotation
            // 
            this.GB_Rotation.Controls.Add(this.CB_RotationVerticale);
            this.GB_Rotation.Controls.Add(this.label4);
            this.GB_Rotation.Location = new System.Drawing.Point(426, 299);
            this.GB_Rotation.Name = "GB_Rotation";
            this.GB_Rotation.Size = new System.Drawing.Size(189, 87);
            this.GB_Rotation.TabIndex = 4;
            this.GB_Rotation.TabStop = false;
            this.GB_Rotation.Text = "Rotation";
            // 
            // CB_RotationVerticale
            // 
            this.CB_RotationVerticale.AutoSize = true;
            this.CB_RotationVerticale.Location = new System.Drawing.Point(33, 45);
            this.CB_RotationVerticale.Name = "CB_RotationVerticale";
            this.CB_RotationVerticale.Size = new System.Drawing.Size(119, 17);
            this.CB_RotationVerticale.TabIndex = 1;
            this.CB_RotationVerticale.Text = "(Vecticale si coché)";
            this.CB_RotationVerticale.UseVisualStyleBackColor = true;
            this.CB_RotationVerticale.CheckedChanged += new System.EventHandler(this.CB_RotationVerticale_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Positionner à la verticale?";
            // 
            // GB_OptionsReseau
            // 
            this.GB_OptionsReseau.Controls.Add(this.BTN_Tester);
            this.GB_OptionsReseau.Controls.Add(this.label6);
            this.GB_OptionsReseau.Controls.Add(this.NUD_Port);
            this.GB_OptionsReseau.Controls.Add(this.TB_AdresseIP);
            this.GB_OptionsReseau.Controls.Add(this.label5);
            this.GB_OptionsReseau.Location = new System.Drawing.Point(16, 393);
            this.GB_OptionsReseau.Name = "GB_OptionsReseau";
            this.GB_OptionsReseau.Size = new System.Drawing.Size(599, 85);
            this.GB_OptionsReseau.TabIndex = 5;
            this.GB_OptionsReseau.TabStop = false;
            this.GB_OptionsReseau.Text = "Options réseau pour la partie";
            // 
            // BTN_Tester
            // 
            this.BTN_Tester.Enabled = false;
            this.BTN_Tester.Location = new System.Drawing.Point(459, 48);
            this.BTN_Tester.Name = "BTN_Tester";
            this.BTN_Tester.Size = new System.Drawing.Size(75, 23);
            this.BTN_Tester.TabIndex = 4;
            this.BTN_Tester.Text = "Tester";
            this.BTN_Tester.UseVisualStyleBackColor = true;
            this.BTN_Tester.Click += new System.EventHandler(this.BTN_Tester_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Numéro de port:";
            // 
            // NUD_Port
            // 
            this.NUD_Port.Location = new System.Drawing.Point(459, 22);
            this.NUD_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_Port.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.NUD_Port.Name = "NUD_Port";
            this.NUD_Port.Size = new System.Drawing.Size(64, 20);
            this.NUD_Port.TabIndex = 2;
            this.NUD_Port.Value = new decimal(new int[] {
            8666,
            0,
            0,
            0});
            // 
            // TB_AdresseIP
            // 
            this.TB_AdresseIP.Location = new System.Drawing.Point(138, 22);
            this.TB_AdresseIP.MaxLength = 15;
            this.TB_AdresseIP.Name = "TB_AdresseIP";
            this.TB_AdresseIP.Size = new System.Drawing.Size(160, 20);
            this.TB_AdresseIP.TabIndex = 1;
            this.TB_AdresseIP.Text = "127.0.0.1";
            this.TB_AdresseIP.TextChanged += new System.EventHandler(this.TB_AdresseIP_TextChanged);
            this.TB_AdresseIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_AdresseIP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adresse IP du serveur:";
            // 
            // LBL_Infos
            // 
            this.LBL_Infos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBL_Infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos.ForeColor = System.Drawing.Color.Red;
            this.LBL_Infos.Location = new System.Drawing.Point(16, 485);
            this.LBL_Infos.Name = "LBL_Infos";
            this.LBL_Infos.Size = new System.Drawing.Size(453, 41);
            this.LBL_Infos.TabIndex = 6;
            this.LBL_Infos.Text = "ERREURS";
            // 
            // BTN_Debuter
            // 
            this.BTN_Debuter.Location = new System.Drawing.Point(475, 485);
            this.BTN_Debuter.Name = "BTN_Debuter";
            this.BTN_Debuter.Size = new System.Drawing.Size(140, 41);
            this.BTN_Debuter.TabIndex = 7;
            this.BTN_Debuter.Text = "Débuter la partie!";
            this.BTN_Debuter.UseVisualStyleBackColor = true;
            this.BTN_Debuter.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGV_Grille
            // 
            this.DGV_Grille.AllowUserToAddRows = false;
            this.DGV_Grille.AllowUserToDeleteRows = false;
            this.DGV_Grille.AllowUserToResizeColumns = false;
            this.DGV_Grille.AllowUserToResizeRows = false;
            this.DGV_Grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Grille.ColumnHeadersVisible = false;
            this.DGV_Grille.Location = new System.Drawing.Point(16, 40);
            this.DGV_Grille.Name = "DGV_Grille";
            this.DGV_Grille.ReadOnly = true;
            this.DGV_Grille.RowHeadersVisible = false;
            this.DGV_Grille.RowHeadersWidth = 16;
            this.DGV_Grille.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_Grille.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_Grille.Size = new System.Drawing.Size(404, 346);
            this.DGV_Grille.TabIndex = 1;
            this.DGV_Grille.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Grille_CellClick);
            this.DGV_Grille.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Grille_CellContentClick);
            this.DGV_Grille.SelectionChanged += new System.EventHandler(this.DGV_Grille_SelectionChanged);
            // 
            // PlacerBateaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 535);
            this.Controls.Add(this.BTN_Debuter);
            this.Controls.Add(this.LBL_Infos);
            this.Controls.Add(this.GB_OptionsReseau);
            this.Controls.Add(this.GB_Rotation);
            this.Controls.Add(this.GB_Position);
            this.Controls.Add(this.GB_Bateaux);
            this.Controls.Add(this.DGV_Grille);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlacerBateaux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle Partie";
            this.Load += new System.EventHandler(this.PlacerBateaux_Load);
            this.GB_Bateaux.ResumeLayout(false);
            this.GB_Bateaux.PerformLayout();
            this.GB_Position.ResumeLayout(false);
            this.GB_Position.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Vectical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Horizontal)).EndInit();
            this.GB_Rotation.ResumeLayout(false);
            this.GB_Rotation.PerformLayout();
            this.GB_OptionsReseau.ResumeLayout(false);
            this.GB_OptionsReseau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Grille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_Bateaux;
        private System.Windows.Forms.RadioButton RB_Torpilleur;
        private System.Windows.Forms.RadioButton RB_SousMarin;
        private System.Windows.Forms.RadioButton RB_ContreTorpilleur;
        private System.Windows.Forms.RadioButton RB_Croiseur;
        private System.Windows.Forms.RadioButton RB_PorteAvion;
        private System.Windows.Forms.GroupBox GB_Position;
        private System.Windows.Forms.NumericUpDown NUD_Vectical;
        private System.Windows.Forms.NumericUpDown NUD_Horizontal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GB_Rotation;
        private System.Windows.Forms.CheckBox CB_RotationVerticale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GB_OptionsReseau;
        private System.Windows.Forms.Button BTN_Tester;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUD_Port;
        private System.Windows.Forms.TextBox TB_AdresseIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_Infos;
        private System.Windows.Forms.Button BTN_Debuter;
        private System.Windows.Forms.DataGridView DGV_Grille;
    }
}