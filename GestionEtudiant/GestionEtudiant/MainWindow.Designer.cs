namespace GestionEtudiant
{
    partial class mainWindow
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
            this.menu = new System.Windows.Forms.TabControl();
            this.FilierePage = new System.Windows.Forms.TabPage();
            this.listeFiliereBox = new System.Windows.Forms.GroupBox();
            this.ajouterFiliereBox = new System.Windows.Forms.GroupBox();
            this.EtudiantPage = new System.Windows.Forms.TabPage();
            this.StatistiquePage = new System.Windows.Forms.TabPage();
            this.ReportingPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ajouterFiliereInput = new System.Windows.Forms.TextBox();
            this.ajouterFiliereBtn = new System.Windows.Forms.Button();
            this.tableFiliere = new System.Windows.Forms.DataGridView();
            this.modifierFiliereBtn = new System.Windows.Forms.Button();
            this.supprimerFiliereBtn = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.FilierePage.SuspendLayout();
            this.listeFiliereBox.SuspendLayout();
            this.ajouterFiliereBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableFiliere)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.FilierePage);
            this.menu.Controls.Add(this.EtudiantPage);
            this.menu.Controls.Add(this.StatistiquePage);
            this.menu.Controls.Add(this.ReportingPage);
            this.menu.ItemSize = new System.Drawing.Size(49, 21);
            this.menu.Location = new System.Drawing.Point(-1, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Drawing.Point(20, 3);
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(1110, 585);
            this.menu.TabIndex = 0;
            // 
            // FilierePage
            // 
            this.FilierePage.Controls.Add(this.listeFiliereBox);
            this.FilierePage.Controls.Add(this.ajouterFiliereBox);
            this.FilierePage.Location = new System.Drawing.Point(4, 25);
            this.FilierePage.Name = "FilierePage";
            this.FilierePage.Padding = new System.Windows.Forms.Padding(3);
            this.FilierePage.Size = new System.Drawing.Size(1102, 556);
            this.FilierePage.TabIndex = 0;
            this.FilierePage.Text = "Filière";
            this.FilierePage.UseVisualStyleBackColor = true;
            // 
            // listeFiliereBox
            // 
            this.listeFiliereBox.Controls.Add(this.supprimerFiliereBtn);
            this.listeFiliereBox.Controls.Add(this.modifierFiliereBtn);
            this.listeFiliereBox.Controls.Add(this.tableFiliere);
            this.listeFiliereBox.Location = new System.Drawing.Point(448, 103);
            this.listeFiliereBox.Name = "listeFiliereBox";
            this.listeFiliereBox.Size = new System.Drawing.Size(624, 292);
            this.listeFiliereBox.TabIndex = 0;
            this.listeFiliereBox.TabStop = false;
            this.listeFiliereBox.Text = "Liste des filieres";
            // 
            // ajouterFiliereBox
            // 
            this.ajouterFiliereBox.Controls.Add(this.ajouterFiliereBtn);
            this.ajouterFiliereBox.Controls.Add(this.ajouterFiliereInput);
            this.ajouterFiliereBox.Controls.Add(this.label1);
            this.ajouterFiliereBox.Location = new System.Drawing.Point(19, 103);
            this.ajouterFiliereBox.Name = "ajouterFiliereBox";
            this.ajouterFiliereBox.Size = new System.Drawing.Size(409, 292);
            this.ajouterFiliereBox.TabIndex = 0;
            this.ajouterFiliereBox.TabStop = false;
            this.ajouterFiliereBox.Text = "Ajouter une filière";
            // 
            // EtudiantPage
            // 
            this.EtudiantPage.Location = new System.Drawing.Point(4, 25);
            this.EtudiantPage.Name = "EtudiantPage";
            this.EtudiantPage.Padding = new System.Windows.Forms.Padding(3);
            this.EtudiantPage.Size = new System.Drawing.Size(1102, 556);
            this.EtudiantPage.TabIndex = 1;
            this.EtudiantPage.Text = "Etudiant";
            this.EtudiantPage.UseVisualStyleBackColor = true;
            // 
            // StatistiquePage
            // 
            this.StatistiquePage.Location = new System.Drawing.Point(4, 25);
            this.StatistiquePage.Name = "StatistiquePage";
            this.StatistiquePage.Padding = new System.Windows.Forms.Padding(3);
            this.StatistiquePage.Size = new System.Drawing.Size(793, 420);
            this.StatistiquePage.TabIndex = 2;
            this.StatistiquePage.Text = "Statistique";
            this.StatistiquePage.UseVisualStyleBackColor = true;
            // 
            // ReportingPage
            // 
            this.ReportingPage.Location = new System.Drawing.Point(4, 25);
            this.ReportingPage.Name = "ReportingPage";
            this.ReportingPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReportingPage.Size = new System.Drawing.Size(793, 420);
            this.ReportingPage.TabIndex = 3;
            this.ReportingPage.Text = "Reporting";
            this.ReportingPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // ajouterFiliereInput
            // 
            this.ajouterFiliereInput.Location = new System.Drawing.Point(80, 124);
            this.ajouterFiliereInput.Name = "ajouterFiliereInput";
            this.ajouterFiliereInput.Size = new System.Drawing.Size(289, 22);
            this.ajouterFiliereInput.TabIndex = 1;
            // 
            // ajouterFiliereBtn
            // 
            this.ajouterFiliereBtn.Location = new System.Drawing.Point(167, 189);
            this.ajouterFiliereBtn.Name = "ajouterFiliereBtn";
            this.ajouterFiliereBtn.Size = new System.Drawing.Size(75, 23);
            this.ajouterFiliereBtn.TabIndex = 2;
            this.ajouterFiliereBtn.Text = "Ajouter";
            this.ajouterFiliereBtn.UseVisualStyleBackColor = true;
            // 
            // tableFiliere
            // 
            this.tableFiliere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableFiliere.Location = new System.Drawing.Point(0, 67);
            this.tableFiliere.Name = "tableFiliere";
            this.tableFiliere.RowHeadersWidth = 51;
            this.tableFiliere.RowTemplate.Height = 24;
            this.tableFiliere.Size = new System.Drawing.Size(624, 225);
            this.tableFiliere.TabIndex = 0;
            // 
            // modifierFiliereBtn
            // 
            this.modifierFiliereBtn.Location = new System.Drawing.Point(174, 27);
            this.modifierFiliereBtn.Name = "modifierFiliereBtn";
            this.modifierFiliereBtn.Size = new System.Drawing.Size(122, 23);
            this.modifierFiliereBtn.TabIndex = 1;
            this.modifierFiliereBtn.Text = "Modifier";
            this.modifierFiliereBtn.UseVisualStyleBackColor = true;
            // 
            // supprimerFiliereBtn
            // 
            this.supprimerFiliereBtn.Location = new System.Drawing.Point(302, 27);
            this.supprimerFiliereBtn.Name = "supprimerFiliereBtn";
            this.supprimerFiliereBtn.Size = new System.Drawing.Size(122, 23);
            this.supprimerFiliereBtn.TabIndex = 1;
            this.supprimerFiliereBtn.Text = "Supprimer";
            this.supprimerFiliereBtn.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 578);
            this.Controls.Add(this.menu);
            this.Name = "mainWindow";
            this.Text = "Gestion Des Etudiants";
            this.menu.ResumeLayout(false);
            this.FilierePage.ResumeLayout(false);
            this.listeFiliereBox.ResumeLayout(false);
            this.ajouterFiliereBox.ResumeLayout(false);
            this.ajouterFiliereBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableFiliere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage FilierePage;
        private System.Windows.Forms.GroupBox ajouterFiliereBox;
        private System.Windows.Forms.TabPage EtudiantPage;
        private System.Windows.Forms.TabPage StatistiquePage;
        private System.Windows.Forms.TabPage ReportingPage;
        private System.Windows.Forms.GroupBox listeFiliereBox;
        private System.Windows.Forms.Button ajouterFiliereBtn;
        private System.Windows.Forms.TextBox ajouterFiliereInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button supprimerFiliereBtn;
        private System.Windows.Forms.Button modifierFiliereBtn;
        private System.Windows.Forms.DataGridView tableFiliere;
    }
}

