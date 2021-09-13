
namespace PPE2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.LabelCatalogue = new System.Windows.Forms.Label();
            this.Catalogue = new System.Windows.Forms.ListBox();
            this.LabelFiltre = new System.Windows.Forms.Label();
            this.ListTrancheAge = new System.Windows.Forms.ListBox();
            this.LabelTrancheAge = new System.Windows.Forms.Label();
            this.ListCategorie = new System.Windows.Forms.ListBox();
            this.LabelCategorie = new System.Windows.Forms.Label();
            this.btnAjoutPanier = new System.Windows.Forms.Button();
            this.btnRetirerPanier = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChoixEnfant = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelRes = new System.Windows.Forms.Label();
            this.btnDeco = new System.Windows.Forms.Button();
            this.StaticLabelNom = new System.Windows.Forms.Label();
            this.LabelNom = new System.Windows.Forms.Label();
            this.LabelErrorRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCatalogue
            // 
            this.LabelCatalogue.AutoSize = true;
            this.LabelCatalogue.Location = new System.Drawing.Point(242, 15);
            this.LabelCatalogue.Name = "LabelCatalogue";
            this.LabelCatalogue.Size = new System.Drawing.Size(61, 13);
            this.LabelCatalogue.TabIndex = 1;
            this.LabelCatalogue.Text = "Catalogue :";
            // 
            // Catalogue
            // 
            this.Catalogue.FormattingEnabled = true;
            this.Catalogue.Location = new System.Drawing.Point(212, 31);
            this.Catalogue.Name = "Catalogue";
            this.Catalogue.Size = new System.Drawing.Size(124, 238);
            this.Catalogue.TabIndex = 2;
            this.Catalogue.SelectedIndexChanged += new System.EventHandler(this.catalogue_SelectedIndexChanged);
            // 
            // LabelFiltre
            // 
            this.LabelFiltre.AutoSize = true;
            this.LabelFiltre.Location = new System.Drawing.Point(12, 144);
            this.LabelFiltre.Name = "LabelFiltre";
            this.LabelFiltre.Size = new System.Drawing.Size(40, 13);
            this.LabelFiltre.TabIndex = 3;
            this.LabelFiltre.Text = "Filtres :";
            // 
            // ListTrancheAge
            // 
            this.ListTrancheAge.FormattingEnabled = true;
            this.ListTrancheAge.Items.AddRange(new object[] {
            "0-2",
            "2-4",
            "4-8",
            "8-12",
            ">12"});
            this.ListTrancheAge.Location = new System.Drawing.Point(12, 182);
            this.ListTrancheAge.Name = "ListTrancheAge";
            this.ListTrancheAge.Size = new System.Drawing.Size(76, 69);
            this.ListTrancheAge.TabIndex = 5;
            this.ListTrancheAge.SelectedIndexChanged += new System.EventHandler(this.ListTrancheAge_SelectedIndexChanged);
            // 
            // LabelTrancheAge
            // 
            this.LabelTrancheAge.AutoSize = true;
            this.LabelTrancheAge.Location = new System.Drawing.Point(12, 166);
            this.LabelTrancheAge.Name = "LabelTrancheAge";
            this.LabelTrancheAge.Size = new System.Drawing.Size(82, 13);
            this.LabelTrancheAge.TabIndex = 6;
            this.LabelTrancheAge.Text = "Tranche d\'âge :";
            // 
            // ListCategorie
            // 
            this.ListCategorie.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ListCategorie.FormattingEnabled = true;
            this.ListCategorie.Items.AddRange(new object[] {
            "Jeux de société",
            "Imitation",
            "Peluches",
            "Jeux d’extérieur",
            "Petits personnages",
            "Jeux technologiques et éléctriques",
            "Eveil et premier age"});
            this.ListCategorie.Location = new System.Drawing.Point(12, 283);
            this.ListCategorie.Name = "ListCategorie";
            this.ListCategorie.Size = new System.Drawing.Size(173, 95);
            this.ListCategorie.TabIndex = 7;
            this.ListCategorie.SelectedIndexChanged += new System.EventHandler(this.ListCategorie_SelectedIndexChanged);
            // 
            // LabelCategorie
            // 
            this.LabelCategorie.AutoSize = true;
            this.LabelCategorie.Location = new System.Drawing.Point(12, 267);
            this.LabelCategorie.Name = "LabelCategorie";
            this.LabelCategorie.Size = new System.Drawing.Size(58, 13);
            this.LabelCategorie.TabIndex = 8;
            this.LabelCategorie.Text = "Catégorie :";
            // 
            // btnAjoutPanier
            // 
            this.btnAjoutPanier.Location = new System.Drawing.Point(212, 309);
            this.btnAjoutPanier.Name = "btnAjoutPanier";
            this.btnAjoutPanier.Size = new System.Drawing.Size(124, 23);
            this.btnAjoutPanier.TabIndex = 9;
            this.btnAjoutPanier.Text = "Réserver le jouet";
            this.btnAjoutPanier.UseVisualStyleBackColor = true;
            this.btnAjoutPanier.Click += new System.EventHandler(this.btnAjoutPanier_Click);
            // 
            // btnRetirerPanier
            // 
            this.btnRetirerPanier.Location = new System.Drawing.Point(108, 425);
            this.btnRetirerPanier.Name = "btnRetirerPanier";
            this.btnRetirerPanier.Size = new System.Drawing.Size(120, 23);
            this.btnRetirerPanier.TabIndex = 10;
            this.btnRetirerPanier.Text = "Retirer du panier";
            this.btnRetirerPanier.UseVisualStyleBackColor = true;
            this.btnRetirerPanier.Click += new System.EventHandler(this.btnRetirerPanier_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ChoixEnfant
            // 
            this.ChoixEnfant.Location = new System.Drawing.Point(212, 283);
            this.ChoixEnfant.Name = "ChoixEnfant";
            this.ChoixEnfant.Size = new System.Drawing.Size(124, 20);
            this.ChoixEnfant.TabIndex = 12;
            this.ChoixEnfant.Text = "Sélectionner l\'enfant...";
            this.ChoixEnfant.SelectedItemChanged += new System.EventHandler(this.ChoixEnfant_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // LabelRes
            // 
            this.LabelRes.AutoSize = true;
            this.LabelRes.Location = new System.Drawing.Point(61, 409);
            this.LabelRes.Name = "LabelRes";
            this.LabelRes.Size = new System.Drawing.Size(242, 13);
            this.LabelRes.TabIndex = 14;
            this.LabelRes.Text = "Sélectionnez un enfant pour voir ses réservations.";
            this.LabelRes.Click += new System.EventHandler(this.LabelRes_Click);
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(257, 503);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(91, 23);
            this.btnDeco.TabIndex = 15;
            this.btnDeco.Text = "Se déconnecter";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // StaticLabelNom
            // 
            this.StaticLabelNom.AutoSize = true;
            this.StaticLabelNom.Location = new System.Drawing.Point(9, 508);
            this.StaticLabelNom.Name = "StaticLabelNom";
            this.StaticLabelNom.Size = new System.Drawing.Size(110, 13);
            this.StaticLabelNom.TabIndex = 16;
            this.StaticLabelNom.Text = "Connecté en tant que";
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNom.Location = new System.Drawing.Point(117, 508);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(68, 13);
            this.LabelNom.TabIndex = 17;
            this.LabelNom.Text = "Prénom Nom";
            this.LabelNom.Click += new System.EventHandler(this.LabelNom_Click);
            // 
            // LabelErrorRes
            // 
            this.LabelErrorRes.AutoSize = true;
            this.LabelErrorRes.ForeColor = System.Drawing.Color.Red;
            this.LabelErrorRes.Location = new System.Drawing.Point(209, 335);
            this.LabelErrorRes.Name = "LabelErrorRes";
            this.LabelErrorRes.Size = new System.Drawing.Size(64, 13);
            this.LabelErrorRes.TabIndex = 18;
            this.LabelErrorRes.Text = "Informations";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(348, 530);
            this.Controls.Add(this.LabelErrorRes);
            this.Controls.Add(this.LabelNom);
            this.Controls.Add(this.StaticLabelNom);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.LabelRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoixEnfant);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRetirerPanier);
            this.Controls.Add(this.btnAjoutPanier);
            this.Controls.Add(this.LabelCategorie);
            this.Controls.Add(this.ListCategorie);
            this.Controls.Add(this.LabelTrancheAge);
            this.Controls.Add(this.ListTrancheAge);
            this.Controls.Add(this.LabelFiltre);
            this.Controls.Add(this.Catalogue);
            this.Controls.Add(this.LabelCatalogue);
            this.Name = "frmMain";
            this.Text = "Catalogue de réservation";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelCatalogue;
        private System.Windows.Forms.ListBox Catalogue;
        private System.Windows.Forms.Label LabelFiltre;
        private System.Windows.Forms.ListBox ListTrancheAge;
        private System.Windows.Forms.Label LabelTrancheAge;
        private System.Windows.Forms.ListBox ListCategorie;
        private System.Windows.Forms.Label LabelCategorie;
        private System.Windows.Forms.Button btnAjoutPanier;
        private System.Windows.Forms.Button btnRetirerPanier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DomainUpDown ChoixEnfant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelRes;
        private System.Windows.Forms.Button btnDeco;
        private System.Windows.Forms.Label StaticLabelNom;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.Label LabelErrorRes;
    }
}