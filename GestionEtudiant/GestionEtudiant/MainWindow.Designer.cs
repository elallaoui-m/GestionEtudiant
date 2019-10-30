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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StatistiquePage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EtudiantPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tri_DCS = new System.Windows.Forms.Button();
            this.Tri_CRS = new System.Windows.Forms.Button();
            this.charger_donnes = new System.Windows.Forms.Button();
            this.resetForm = new System.Windows.Forms.Button();
            this.cherche_etudiant_combobox = new System.Windows.Forms.ComboBox();
            this.Importer = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.choixFiliereCombo = new System.Windows.Forms.ComboBox();
            this.tele_textbox = new System.Windows.Forms.TextBox();
            this.adresse_textbox = new System.Windows.Forms.TextBox();
            this.date_naissance = new System.Windows.Forms.DateTimePicker();
            this.male_radio = new System.Windows.Forms.RadioButton();
            this.female_radio = new System.Windows.Forms.RadioButton();
            this.prenom_textbox = new System.Windows.Forms.TextBox();
            this.nom_textbox = new System.Windows.Forms.TextBox();
            this.cne_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilierePage = new System.Windows.Forms.TabPage();
            this.ModifiyingPannel = new System.Windows.Forms.Panel();
            this.ValidationButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ModifiedName = new System.Windows.Forms.TextBox();
            this.listeFiliereBox = new System.Windows.Forms.GroupBox();
            this.supprimerFiliereBtn = new System.Windows.Forms.Button();
            this.modifierFiliereBtn = new System.Windows.Forms.Button();
            this.tableFiliere = new System.Windows.Forms.DataGridView();
            this.ajouterFiliereBox = new System.Windows.Forms.GroupBox();
            this.ajouterFiliereBtn = new System.Windows.Forms.Button();
            this.ajouterFiliereInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.TabControl();
            this.Reporting = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CINreportingCombobox = new System.Windows.Forms.ComboBox();
            this.reportingGenerate = new System.Windows.Forms.Button();
            this.reportingButton = new System.Windows.Forms.Button();
            this.reportingLabel = new System.Windows.Forms.Label();
            this.reportingComboBox = new System.Windows.Forms.ComboBox();
            this.closePanelEdit = new System.Windows.Forms.Button();
            this.StatistiquePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.EtudiantPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.FilierePage.SuspendLayout();
            this.ModifiyingPannel.SuspendLayout();
            this.listeFiliereBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableFiliere)).BeginInit();
            this.ajouterFiliereBox.SuspendLayout();
            this.menu.SuspendLayout();
            this.Reporting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StatistiquePage
            // 
            this.StatistiquePage.Controls.Add(this.pictureBox1);
            this.StatistiquePage.Controls.Add(this.chart1);
            this.StatistiquePage.Location = new System.Drawing.Point(4, 25);
            this.StatistiquePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatistiquePage.Name = "StatistiquePage";
            this.StatistiquePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatistiquePage.Size = new System.Drawing.Size(1245, 582);
            this.StatistiquePage.TabIndex = 3;
            this.StatistiquePage.Text = "Statistique";
            this.StatistiquePage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1198, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.resfreshButton_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(79, 41);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Nombre Etudiant";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(883, 377);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // EtudiantPage
            // 
            this.EtudiantPage.Controls.Add(this.groupBox2);
            this.EtudiantPage.Controls.Add(this.resetForm);
            this.EtudiantPage.Controls.Add(this.cherche_etudiant_combobox);
            this.EtudiantPage.Controls.Add(this.Importer);
            this.EtudiantPage.Controls.Add(this.Supprimer);
            this.EtudiantPage.Controls.Add(this.Modifier);
            this.EtudiantPage.Controls.Add(this.Ajouter);
            this.EtudiantPage.Controls.Add(this.groupBox1);
            this.EtudiantPage.Controls.Add(this.label2);
            this.EtudiantPage.Location = new System.Drawing.Point(4, 25);
            this.EtudiantPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EtudiantPage.Name = "EtudiantPage";
            this.EtudiantPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EtudiantPage.Size = new System.Drawing.Size(1245, 582);
            this.EtudiantPage.TabIndex = 2;
            this.EtudiantPage.Text = "Etudiant";
            this.EtudiantPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.Tri_DCS);
            this.groupBox2.Controls.Add(this.Tri_CRS);
            this.groupBox2.Controls.Add(this.charger_donnes);
            this.groupBox2.Location = new System.Drawing.Point(559, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 375);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des étudiants";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(679, 266);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Tri_DCS
            // 
            this.Tri_DCS.Location = new System.Drawing.Point(547, 40);
            this.Tri_DCS.Margin = new System.Windows.Forms.Padding(4);
            this.Tri_DCS.Name = "Tri_DCS";
            this.Tri_DCS.Size = new System.Drawing.Size(123, 36);
            this.Tri_DCS.TabIndex = 5;
            this.Tri_DCS.Text = "Tri décroissant";
            this.Tri_DCS.UseVisualStyleBackColor = true;
            this.Tri_DCS.Click += new System.EventHandler(this.Tri_DCS_Click);
            // 
            // Tri_CRS
            // 
            this.Tri_CRS.Location = new System.Drawing.Point(424, 40);
            this.Tri_CRS.Margin = new System.Windows.Forms.Padding(4);
            this.Tri_CRS.Name = "Tri_CRS";
            this.Tri_CRS.Size = new System.Drawing.Size(115, 36);
            this.Tri_CRS.TabIndex = 4;
            this.Tri_CRS.Text = "Tri croissant";
            this.Tri_CRS.UseVisualStyleBackColor = true;
            this.Tri_CRS.Click += new System.EventHandler(this.Tri_CRS_Click);
            // 
            // charger_donnes
            // 
            this.charger_donnes.Location = new System.Drawing.Point(7, 45);
            this.charger_donnes.Margin = new System.Windows.Forms.Padding(4);
            this.charger_donnes.Name = "charger_donnes";
            this.charger_donnes.Size = new System.Drawing.Size(161, 36);
            this.charger_donnes.TabIndex = 3;
            this.charger_donnes.Text = "Charger les données";
            this.charger_donnes.UseVisualStyleBackColor = true;
            this.charger_donnes.Click += new System.EventHandler(this.charger_donnes_Click);
            // 
            // resetForm
            // 
            this.resetForm.Location = new System.Drawing.Point(439, 487);
            this.resetForm.Margin = new System.Windows.Forms.Padding(4);
            this.resetForm.Name = "resetForm";
            this.resetForm.Size = new System.Drawing.Size(100, 36);
            this.resetForm.TabIndex = 12;
            this.resetForm.Text = "Reinstaliser";
            this.resetForm.UseVisualStyleBackColor = true;
            this.resetForm.Click += new System.EventHandler(this.resetForm_Click);
            // 
            // cherche_etudiant_combobox
            // 
            this.cherche_etudiant_combobox.FormattingEnabled = true;
            this.cherche_etudiant_combobox.Location = new System.Drawing.Point(251, 42);
            this.cherche_etudiant_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.cherche_etudiant_combobox.Name = "cherche_etudiant_combobox";
            this.cherche_etudiant_combobox.Size = new System.Drawing.Size(291, 24);
            this.cherche_etudiant_combobox.TabIndex = 11;
            this.cherche_etudiant_combobox.SelectedIndexChanged += new System.EventHandler(this.cherche_etudiant_combobox_SelectedIndexChanged);
            // 
            // Importer
            // 
            this.Importer.Location = new System.Drawing.Point(341, 487);
            this.Importer.Margin = new System.Windows.Forms.Padding(4);
            this.Importer.Name = "Importer";
            this.Importer.Size = new System.Drawing.Size(85, 36);
            this.Importer.TabIndex = 9;
            this.Importer.Text = "Importer";
            this.Importer.UseVisualStyleBackColor = true;
            this.Importer.Click += new System.EventHandler(this.Importer_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(228, 487);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(100, 36);
            this.Supprimer.TabIndex = 8;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(132, 487);
            this.Modifier.Margin = new System.Windows.Forms.Padding(4);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(83, 36);
            this.Modifier.TabIndex = 7;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(31, 487);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(88, 36);
            this.Ajouter.TabIndex = 6;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.choixFiliereCombo);
            this.groupBox1.Controls.Add(this.tele_textbox);
            this.groupBox1.Controls.Add(this.adresse_textbox);
            this.groupBox1.Controls.Add(this.date_naissance);
            this.groupBox1.Controls.Add(this.male_radio);
            this.groupBox1.Controls.Add(this.female_radio);
            this.groupBox1.Controls.Add(this.prenom_textbox);
            this.groupBox1.Controls.Add(this.nom_textbox);
            this.groupBox1.Controls.Add(this.cne_textBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(510, 375);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Etudiant";
            // 
            // choixFiliereCombo
            // 
            this.choixFiliereCombo.FormattingEnabled = true;
            this.choixFiliereCombo.Location = new System.Drawing.Point(200, 326);
            this.choixFiliereCombo.Margin = new System.Windows.Forms.Padding(4);
            this.choixFiliereCombo.Name = "choixFiliereCombo";
            this.choixFiliereCombo.Size = new System.Drawing.Size(265, 24);
            this.choixFiliereCombo.TabIndex = 16;
            // 
            // tele_textbox
            // 
            this.tele_textbox.Location = new System.Drawing.Point(200, 280);
            this.tele_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.tele_textbox.Name = "tele_textbox";
            this.tele_textbox.Size = new System.Drawing.Size(265, 22);
            this.tele_textbox.TabIndex = 15;
            // 
            // adresse_textbox
            // 
            this.adresse_textbox.Location = new System.Drawing.Point(200, 161);
            this.adresse_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.adresse_textbox.Name = "adresse_textbox";
            this.adresse_textbox.Size = new System.Drawing.Size(265, 22);
            this.adresse_textbox.TabIndex = 14;
            // 
            // date_naissance
            // 
            this.date_naissance.Location = new System.Drawing.Point(200, 242);
            this.date_naissance.Margin = new System.Windows.Forms.Padding(4);
            this.date_naissance.Name = "date_naissance";
            this.date_naissance.Size = new System.Drawing.Size(265, 22);
            this.date_naissance.TabIndex = 13;
            // 
            // male_radio
            // 
            this.male_radio.AutoSize = true;
            this.male_radio.Location = new System.Drawing.Point(348, 199);
            this.male_radio.Margin = new System.Windows.Forms.Padding(4);
            this.male_radio.Name = "male_radio";
            this.male_radio.Size = new System.Drawing.Size(40, 21);
            this.male_radio.TabIndex = 12;
            this.male_radio.TabStop = true;
            this.male_radio.Text = "M";
            this.male_radio.UseVisualStyleBackColor = true;
            // 
            // female_radio
            // 
            this.female_radio.AutoSize = true;
            this.female_radio.Location = new System.Drawing.Point(200, 199);
            this.female_radio.Margin = new System.Windows.Forms.Padding(4);
            this.female_radio.Name = "female_radio";
            this.female_radio.Size = new System.Drawing.Size(37, 21);
            this.female_radio.TabIndex = 11;
            this.female_radio.TabStop = true;
            this.female_radio.Text = "F";
            this.female_radio.UseVisualStyleBackColor = true;
            // 
            // prenom_textbox
            // 
            this.prenom_textbox.Location = new System.Drawing.Point(200, 120);
            this.prenom_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.prenom_textbox.Name = "prenom_textbox";
            this.prenom_textbox.Size = new System.Drawing.Size(265, 22);
            this.prenom_textbox.TabIndex = 10;
            // 
            // nom_textbox
            // 
            this.nom_textbox.Location = new System.Drawing.Point(200, 83);
            this.nom_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.nom_textbox.Name = "nom_textbox";
            this.nom_textbox.Size = new System.Drawing.Size(265, 22);
            this.nom_textbox.TabIndex = 9;
            // 
            // cne_textBox
            // 
            this.cne_textBox.Location = new System.Drawing.Point(200, 36);
            this.cne_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.cne_textBox.Name = "cne_textBox";
            this.cne_textBox.Size = new System.Drawing.Size(265, 22);
            this.cne_textBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 326);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Filiere:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 285);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Telephone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Adresse:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date de Naissance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sexe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prenom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "CNE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chercher un Etudiant";
            // 
            // FilierePage
            // 
            this.FilierePage.Controls.Add(this.ModifiyingPannel);
            this.FilierePage.Controls.Add(this.listeFiliereBox);
            this.FilierePage.Controls.Add(this.ajouterFiliereBox);
            this.FilierePage.Location = new System.Drawing.Point(4, 25);
            this.FilierePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilierePage.Name = "FilierePage";
            this.FilierePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilierePage.Size = new System.Drawing.Size(1245, 582);
            this.FilierePage.TabIndex = 0;
            this.FilierePage.Text = "Filière";
            this.FilierePage.UseVisualStyleBackColor = true;
            // 
            // ModifiyingPannel
            // 
            this.ModifiyingPannel.BackColor = System.Drawing.Color.DimGray;
            this.ModifiyingPannel.Controls.Add(this.closePanelEdit);
            this.ModifiyingPannel.Controls.Add(this.ValidationButton);
            this.ModifiyingPannel.Controls.Add(this.label11);
            this.ModifiyingPannel.Controls.Add(this.ModifiedName);
            this.ModifiyingPannel.Location = new System.Drawing.Point(417, 88);
            this.ModifiyingPannel.Margin = new System.Windows.Forms.Padding(4);
            this.ModifiyingPannel.Name = "ModifiyingPannel";
            this.ModifiyingPannel.Size = new System.Drawing.Size(411, 158);
            this.ModifiyingPannel.TabIndex = 1;
            this.ModifiyingPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ValidationButton
            // 
            this.ValidationButton.Location = new System.Drawing.Point(166, 99);
            this.ValidationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValidationButton.Name = "ValidationButton";
            this.ValidationButton.Size = new System.Drawing.Size(86, 27);
            this.ValidationButton.TabIndex = 4;
            this.ValidationButton.Text = "Valider";
            this.ValidationButton.UseVisualStyleBackColor = true;
            this.ValidationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(21, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nouveau Nom : ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // ModifiedName
            // 
            this.ModifiedName.Location = new System.Drawing.Point(151, 55);
            this.ModifiedName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifiedName.Name = "ModifiedName";
            this.ModifiedName.Size = new System.Drawing.Size(216, 22);
            this.ModifiedName.TabIndex = 2;
            // 
            // listeFiliereBox
            // 
            this.listeFiliereBox.Controls.Add(this.supprimerFiliereBtn);
            this.listeFiliereBox.Controls.Add(this.modifierFiliereBtn);
            this.listeFiliereBox.Controls.Add(this.tableFiliere);
            this.listeFiliereBox.Location = new System.Drawing.Point(448, 103);
            this.listeFiliereBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listeFiliereBox.Name = "listeFiliereBox";
            this.listeFiliereBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listeFiliereBox.Size = new System.Drawing.Size(768, 292);
            this.listeFiliereBox.TabIndex = 0;
            this.listeFiliereBox.TabStop = false;
            this.listeFiliereBox.Text = "Liste des filieres";
            // 
            // supprimerFiliereBtn
            // 
            this.supprimerFiliereBtn.Location = new System.Drawing.Point(639, 19);
            this.supprimerFiliereBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supprimerFiliereBtn.Name = "supprimerFiliereBtn";
            this.supprimerFiliereBtn.Size = new System.Drawing.Size(123, 35);
            this.supprimerFiliereBtn.TabIndex = 1;
            this.supprimerFiliereBtn.Text = "Supprimer";
            this.supprimerFiliereBtn.UseVisualStyleBackColor = true;
            this.supprimerFiliereBtn.Click += new System.EventHandler(this.supprimerFiliereBtn_Click);
            // 
            // modifierFiliereBtn
            // 
            this.modifierFiliereBtn.Location = new System.Drawing.Point(511, 19);
            this.modifierFiliereBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifierFiliereBtn.Name = "modifierFiliereBtn";
            this.modifierFiliereBtn.Size = new System.Drawing.Size(123, 35);
            this.modifierFiliereBtn.TabIndex = 1;
            this.modifierFiliereBtn.Text = "Modifier";
            this.modifierFiliereBtn.UseVisualStyleBackColor = true;
            this.modifierFiliereBtn.Click += new System.EventHandler(this.modifierFiliereBtn_Click);
            // 
            // tableFiliere
            // 
            this.tableFiliere.AllowUserToAddRows = false;
            this.tableFiliere.AllowUserToDeleteRows = false;
            this.tableFiliere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableFiliere.Location = new System.Drawing.Point(0, 66);
            this.tableFiliere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableFiliere.Name = "tableFiliere";
            this.tableFiliere.RowHeadersWidth = 51;
            this.tableFiliere.RowTemplate.Height = 24;
            this.tableFiliere.Size = new System.Drawing.Size(768, 225);
            this.tableFiliere.TabIndex = 0;
            // 
            // ajouterFiliereBox
            // 
            this.ajouterFiliereBox.Controls.Add(this.ajouterFiliereBtn);
            this.ajouterFiliereBox.Controls.Add(this.ajouterFiliereInput);
            this.ajouterFiliereBox.Controls.Add(this.label1);
            this.ajouterFiliereBox.Location = new System.Drawing.Point(19, 103);
            this.ajouterFiliereBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajouterFiliereBox.Name = "ajouterFiliereBox";
            this.ajouterFiliereBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajouterFiliereBox.Size = new System.Drawing.Size(409, 292);
            this.ajouterFiliereBox.TabIndex = 0;
            this.ajouterFiliereBox.TabStop = false;
            this.ajouterFiliereBox.Text = "Ajouter une filière";
            // 
            // ajouterFiliereBtn
            // 
            this.ajouterFiliereBtn.Location = new System.Drawing.Point(159, 190);
            this.ajouterFiliereBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajouterFiliereBtn.Name = "ajouterFiliereBtn";
            this.ajouterFiliereBtn.Size = new System.Drawing.Size(88, 34);
            this.ajouterFiliereBtn.TabIndex = 2;
            this.ajouterFiliereBtn.Text = "Ajouter";
            this.ajouterFiliereBtn.UseVisualStyleBackColor = true;
            this.ajouterFiliereBtn.Click += new System.EventHandler(this.ajouterFiliereBtn_Click);
            // 
            // ajouterFiliereInput
            // 
            this.ajouterFiliereInput.Location = new System.Drawing.Point(80, 124);
            this.ajouterFiliereInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajouterFiliereInput.Name = "ajouterFiliereInput";
            this.ajouterFiliereInput.Size = new System.Drawing.Size(289, 22);
            this.ajouterFiliereInput.TabIndex = 1;
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
            // menu
            // 
            this.menu.Controls.Add(this.FilierePage);
            this.menu.Controls.Add(this.EtudiantPage);
            this.menu.Controls.Add(this.StatistiquePage);
            this.menu.Controls.Add(this.Reporting);
            this.menu.ItemSize = new System.Drawing.Size(49, 21);
            this.menu.Location = new System.Drawing.Point(1, -1);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Drawing.Point(20, 3);
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(1253, 611);
            this.menu.TabIndex = 0;
            // 
            // Reporting
            // 
            this.Reporting.Controls.Add(this.pictureBox2);
            this.Reporting.Controls.Add(this.CINreportingCombobox);
            this.Reporting.Controls.Add(this.reportingGenerate);
            this.Reporting.Controls.Add(this.reportingButton);
            this.Reporting.Controls.Add(this.reportingLabel);
            this.Reporting.Controls.Add(this.reportingComboBox);
            this.Reporting.Location = new System.Drawing.Point(4, 25);
            this.Reporting.Margin = new System.Windows.Forms.Padding(4);
            this.Reporting.Name = "Reporting";
            this.Reporting.Padding = new System.Windows.Forms.Padding(4);
            this.Reporting.Size = new System.Drawing.Size(1245, 582);
            this.Reporting.TabIndex = 4;
            this.Reporting.Text = "Reporting";
            this.Reporting.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1198, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.resfreshButton_Click);
            // 
            // CINreportingCombobox
            // 
            this.CINreportingCombobox.FormattingEnabled = true;
            this.CINreportingCombobox.Location = new System.Drawing.Point(503, 239);
            this.CINreportingCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.CINreportingCombobox.Name = "CINreportingCombobox";
            this.CINreportingCombobox.Size = new System.Drawing.Size(252, 24);
            this.CINreportingCombobox.TabIndex = 5;
            this.CINreportingCombobox.Visible = false;
            // 
            // reportingGenerate
            // 
            this.reportingGenerate.Location = new System.Drawing.Point(563, 194);
            this.reportingGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.reportingGenerate.Name = "reportingGenerate";
            this.reportingGenerate.Size = new System.Drawing.Size(139, 36);
            this.reportingGenerate.TabIndex = 4;
            this.reportingGenerate.Text = "Afficher";
            this.reportingGenerate.UseVisualStyleBackColor = true;
            this.reportingGenerate.Visible = false;
            this.reportingGenerate.Click += new System.EventHandler(this.ReportingGenerate_Click);
            // 
            // reportingButton
            // 
            this.reportingButton.Location = new System.Drawing.Point(563, 298);
            this.reportingButton.Margin = new System.Windows.Forms.Padding(4);
            this.reportingButton.Name = "reportingButton";
            this.reportingButton.Size = new System.Drawing.Size(139, 38);
            this.reportingButton.TabIndex = 3;
            this.reportingButton.Text = "Afficher";
            this.reportingButton.UseVisualStyleBackColor = true;
            this.reportingButton.Visible = false;
            this.reportingButton.Click += new System.EventHandler(this.ReportingButton_Click);
            // 
            // reportingLabel
            // 
            this.reportingLabel.AutoSize = true;
            this.reportingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportingLabel.Location = new System.Drawing.Point(361, 242);
            this.reportingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reportingLabel.Name = "reportingLabel";
            this.reportingLabel.Size = new System.Drawing.Size(131, 17);
            this.reportingLabel.TabIndex = 1;
            this.reportingLabel.Text = "Selectionner CNE : ";
            this.reportingLabel.Visible = false;
            // 
            // reportingComboBox
            // 
            this.reportingComboBox.FormattingEnabled = true;
            this.reportingComboBox.Items.AddRange(new object[] {
            "Tous les étudiants",
            "Chaque étudiant"});
            this.reportingComboBox.Location = new System.Drawing.Point(503, 110);
            this.reportingComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.reportingComboBox.Name = "reportingComboBox";
            this.reportingComboBox.Size = new System.Drawing.Size(252, 24);
            this.reportingComboBox.TabIndex = 0;
            this.reportingComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // closePanelEdit
            // 
            this.closePanelEdit.Location = new System.Drawing.Point(379, -2);
            this.closePanelEdit.Name = "closePanelEdit";
            this.closePanelEdit.Size = new System.Drawing.Size(34, 26);
            this.closePanelEdit.TabIndex = 5;
            this.closePanelEdit.Text = "X";
            this.closePanelEdit.UseVisualStyleBackColor = true;
            this.closePanelEdit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 608);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainWindow";
            this.Text = "Gestion Des Etudiants";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.StatistiquePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.EtudiantPage.ResumeLayout(false);
            this.EtudiantPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FilierePage.ResumeLayout(false);
            this.ModifiyingPannel.ResumeLayout(false);
            this.ModifiyingPannel.PerformLayout();
            this.listeFiliereBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableFiliere)).EndInit();
            this.ajouterFiliereBox.ResumeLayout(false);
            this.ajouterFiliereBox.PerformLayout();
            this.menu.ResumeLayout(false);
            this.Reporting.ResumeLayout(false);
            this.Reporting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage StatistiquePage;
        private System.Windows.Forms.TabPage EtudiantPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage FilierePage;
        private System.Windows.Forms.GroupBox listeFiliereBox;
        private System.Windows.Forms.Button supprimerFiliereBtn;
        private System.Windows.Forms.Button modifierFiliereBtn;
        private System.Windows.Forms.DataGridView tableFiliere;
        private System.Windows.Forms.GroupBox ajouterFiliereBox;
        private System.Windows.Forms.Button ajouterFiliereBtn;
        private System.Windows.Forms.TextBox ajouterFiliereInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage Reporting;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Importer;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox choixFiliereCombo;
        private System.Windows.Forms.TextBox tele_textbox;
        private System.Windows.Forms.TextBox adresse_textbox;
        private System.Windows.Forms.DateTimePicker date_naissance;
        private System.Windows.Forms.RadioButton male_radio;
        private System.Windows.Forms.RadioButton female_radio;
        private System.Windows.Forms.TextBox prenom_textbox;
        private System.Windows.Forms.TextBox nom_textbox;
        private System.Windows.Forms.TextBox cne_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cherche_etudiant_combobox;
        private System.Windows.Forms.ComboBox reportingComboBox;
        private System.Windows.Forms.Label reportingLabel;
        private System.Windows.Forms.Button reportingButton;
        private System.Windows.Forms.Button reportingGenerate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel ModifiyingPannel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ModifiedName;
        private System.Windows.Forms.Button ValidationButton;
        private System.Windows.Forms.Button resetForm;
        private System.Windows.Forms.ComboBox CINreportingCombobox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Tri_DCS;
        private System.Windows.Forms.Button Tri_CRS;
        private System.Windows.Forms.Button charger_donnes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button closePanelEdit;
    }
}

