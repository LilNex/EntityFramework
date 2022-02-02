namespace EntityFramework
{
    partial class frmStagiaire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStg = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblfiliere = new System.Windows.Forms.Label();
            this.lblgenre = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.dtm = new System.Windows.Forms.DateTimePicker();
            this.cmbfilier = new System.Windows.Forms.ComboBox();
            this.rdF = new System.Windows.Forms.RadioButton();
            this.rdM = new System.Windows.Forms.RadioButton();
            this.dgvstagiaire = new System.Windows.Forms.DataGridView();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnafficher = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnrechercher = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnpremier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnprecedent = new System.Windows.Forms.Button();
            this.btnDerniere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstagiaire)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStg
            // 
            this.lblStg.AutoSize = true;
            this.lblStg.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStg.Location = new System.Drawing.Point(248, 9);
            this.lblStg.Name = "lblStg";
            this.lblStg.Size = new System.Drawing.Size(299, 37);
            this.lblStg.TabIndex = 0;
            this.lblStg.Text = "Gestion Stagiaire :";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(12, 94);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(117, 16);
            this.lblnum.TabIndex = 1;
            this.lblnum.Text = "Numero stagiaire :";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.Location = new System.Drawing.Point(12, 125);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(98, 16);
            this.lblnom.TabIndex = 2;
            this.lblnom.Text = "Nom stagiaire :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 158);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(130, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date de Naissance :";
            // 
            // lblfiliere
            // 
            this.lblfiliere.AutoSize = true;
            this.lblfiliere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiliere.Location = new System.Drawing.Point(12, 215);
            this.lblfiliere.Name = "lblfiliere";
            this.lblfiliere.Size = new System.Drawing.Size(51, 16);
            this.lblfiliere.TabIndex = 4;
            this.lblfiliere.Text = "Filiere :";
            // 
            // lblgenre
            // 
            this.lblgenre.AutoSize = true;
            this.lblgenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenre.Location = new System.Drawing.Point(12, 185);
            this.lblgenre.Name = "lblgenre";
            this.lblgenre.Size = new System.Drawing.Size(51, 16);
            this.lblgenre.TabIndex = 5;
            this.lblgenre.Text = "Genre :";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(168, 123);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(159, 20);
            this.txtnom.TabIndex = 6;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(168, 92);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(159, 20);
            this.txtnum.TabIndex = 7;
            // 
            // dtm
            // 
            this.dtm.Location = new System.Drawing.Point(168, 158);
            this.dtm.Name = "dtm";
            this.dtm.Size = new System.Drawing.Size(159, 20);
            this.dtm.TabIndex = 8;
            // 
            // cmbfilier
            // 
            this.cmbfilier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfilier.FormattingEnabled = true;
            this.cmbfilier.Location = new System.Drawing.Point(168, 215);
            this.cmbfilier.Name = "cmbfilier";
            this.cmbfilier.Size = new System.Drawing.Size(159, 26);
            this.cmbfilier.TabIndex = 9;
            // 
            // rdF
            // 
            this.rdF.AutoSize = true;
            this.rdF.Location = new System.Drawing.Point(168, 192);
            this.rdF.Name = "rdF";
            this.rdF.Size = new System.Drawing.Size(31, 17);
            this.rdF.TabIndex = 10;
            this.rdF.TabStop = true;
            this.rdF.Text = "F";
            this.rdF.UseVisualStyleBackColor = true;
            // 
            // rdM
            // 
            this.rdM.AutoSize = true;
            this.rdM.Location = new System.Drawing.Point(293, 192);
            this.rdM.Name = "rdM";
            this.rdM.Size = new System.Drawing.Size(34, 17);
            this.rdM.TabIndex = 11;
            this.rdM.TabStop = true;
            this.rdM.Text = "M";
            this.rdM.UseVisualStyleBackColor = true;
            // 
            // dgvstagiaire
            // 
            this.dgvstagiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstagiaire.Location = new System.Drawing.Point(2, 298);
            this.dgvstagiaire.Name = "dgvstagiaire";
            this.dgvstagiaire.Size = new System.Drawing.Size(393, 146);
            this.dgvstagiaire.TabIndex = 12;
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.PeachPuff;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(440, 80);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(81, 32);
            this.btnajouter.TabIndex = 13;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.PeachPuff;
            this.btnsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.Location = new System.Drawing.Point(527, 123);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(81, 32);
            this.btnsupprimer.TabIndex = 24;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            // 
            // btnafficher
            // 
            this.btnafficher.BackColor = System.Drawing.Color.PeachPuff;
            this.btnafficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafficher.Location = new System.Drawing.Point(440, 123);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(81, 32);
            this.btnafficher.TabIndex = 25;
            this.btnafficher.Text = "Afficher";
            this.btnafficher.UseVisualStyleBackColor = false;
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.PeachPuff;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(527, 80);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(81, 32);
            this.btnmodifier.TabIndex = 26;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            // 
            // btnrechercher
            // 
            this.btnrechercher.BackColor = System.Drawing.Color.PeachPuff;
            this.btnrechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechercher.Location = new System.Drawing.Point(614, 80);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Size = new System.Drawing.Size(81, 32);
            this.btnrechercher.TabIndex = 27;
            this.btnrechercher.Text = "Rechercher";
            this.btnrechercher.UseVisualStyleBackColor = false;
            // 
            // btnquitter
            // 
            this.btnquitter.BackColor = System.Drawing.Color.PeachPuff;
            this.btnquitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitter.Location = new System.Drawing.Point(614, 123);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(81, 32);
            this.btnquitter.TabIndex = 28;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = false;
            // 
            // btnpremier
            // 
            this.btnpremier.BackColor = System.Drawing.Color.SandyBrown;
            this.btnpremier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpremier.Location = new System.Drawing.Point(429, 240);
            this.btnpremier.Name = "btnpremier";
            this.btnpremier.Size = new System.Drawing.Size(81, 32);
            this.btnpremier.TabIndex = 29;
            this.btnpremier.Text = "Premiere";
            this.btnpremier.UseVisualStyleBackColor = false;
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(513, 240);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(81, 32);
            this.btnSuivant.TabIndex = 30;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = false;
            // 
            // btnprecedent
            // 
            this.btnprecedent.BackColor = System.Drawing.Color.SandyBrown;
            this.btnprecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprecedent.Location = new System.Drawing.Point(600, 240);
            this.btnprecedent.Name = "btnprecedent";
            this.btnprecedent.Size = new System.Drawing.Size(81, 32);
            this.btnprecedent.TabIndex = 31;
            this.btnprecedent.Text = "Precedent";
            this.btnprecedent.UseVisualStyleBackColor = false;
            // 
            // btnDerniere
            // 
            this.btnDerniere.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDerniere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerniere.Location = new System.Drawing.Point(687, 240);
            this.btnDerniere.Name = "btnDerniere";
            this.btnDerniere.Size = new System.Drawing.Size(81, 32);
            this.btnDerniere.TabIndex = 32;
            this.btnDerniere.Text = "Derniere";
            this.btnDerniere.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(812, 447);
            this.Controls.Add(this.btnDerniere);
            this.Controls.Add(this.btnprecedent);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnpremier);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnafficher);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.dgvstagiaire);
            this.Controls.Add(this.rdM);
            this.Controls.Add(this.rdF);
            this.Controls.Add(this.cmbfilier);
            this.Controls.Add(this.dtm);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lblgenre);
            this.Controls.Add(this.lblfiliere);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lblStg);
            this.Name = "Form1";
            this.Text = "frmStagiaire";
            ((System.ComponentModel.ISupportInitialize)(this.dgvstagiaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStg;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblfiliere;
        private System.Windows.Forms.Label lblgenre;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.DateTimePicker dtm;
        private System.Windows.Forms.ComboBox cmbfilier;
        private System.Windows.Forms.RadioButton rdF;
        private System.Windows.Forms.RadioButton rdM;
        private System.Windows.Forms.DataGridView dgvstagiaire;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnafficher;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnpremier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnprecedent;
        private System.Windows.Forms.Button btnDerniere;
    }
}

