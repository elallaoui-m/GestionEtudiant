using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class mainWindow : Form{
        string FiliereId;
        DataClasses1DataContext cl = new DataClasses1DataContext();
        string choix = "";
        String cin;
        public mainWindow()
        {
            InitializeComponent();

        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            loadFiliereData();
            FillFiliereCombobox();
            fillStatisticsChart();
            FillChercherEtudiant();
            FillReportingCombobox();
            ModifiyingPannel.Visible = false;
        }

        private void charger_donnes_Click(object sender, EventArgs e)
        {
            loadDataEtudiants();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            var p = cl.Etudiant.SingleOrDefault(x => x.cne == cne_textBox.Text);
            cl.Etudiant.DeleteOnSubmit(p);
            cl.SubmitChanges();
            MessageBox.Show("L'étudiant a été bien supprimé.");
            CleanTextBoxs();
            loadDataEtudiants();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (female_radio.Checked)
            {
                choix = "M";
            }
            else choix = "F";
            var etu = cl.Etudiant.SingleOrDefault(x => x.cne ==cne_textBox.Text);
            etu.nom = nom_textbox.Text;
            etu.prenom = prenom_textbox.Text;
            etu.adresse = adresse_textbox.Text;
            etu.sexe = choix[0];
            etu.date_naissance = date_naissance.Value;
            
            etu.tele = tele_textbox.Text;
            ComboBoxItem cnb = (ComboBoxItem)choixFiliereCombo.SelectedItem;
            etu.id_filiere = cnb.Value1;
            cl.SubmitChanges();

            MessageBox.Show("Les informations ont été bien modifiées.");
            CleanTextBoxs();
            
        }

        private void Tri_DCS_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["nom"], ListSortDirection.Descending);
        }

        private void Tri_CRS_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["nom"], ListSortDirection.Ascending);
        }


        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportingComboBox.SelectedIndex == 1)
            {
                reportingButton.Show();
                CINreportingCombobox.Show();
                reportingLabel.Show();
                reportingGenerate.Hide();
            } else
            {
                reportingButton.Hide();
                CINreportingCombobox.Hide();
                reportingLabel.Hide();
                reportingGenerate.Show();
            }
        }

        private void ReportingGenerate_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void ReportingButton_Click(object sender, EventArgs e)
        {

            ComboBoxItem cnb = (ComboBoxItem)CINreportingCombobox.SelectedItem;
            cin = cnb.Value1.ToString();
            ReportFormSingleStudent reportFormSingleStudent = new ReportFormSingleStudent();
            reportFormSingleStudent.getCIN(cin.ToString());
            reportFormSingleStudent.Show();
        }


        void loadFiliereData()
        {
            
            var selectQuery =
               from a in cl.filiere
               select a;

            tableFiliere.DataSource = selectQuery;
            tableFiliere.ReadOnly = true;
            tableFiliere.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void fillStatisticsChart()
        {
            
            var filiere = from f in cl.filiere select f;
           
            foreach (var x in filiere)
            {
                var tmp = from e in cl.Etudiant
                          where e.id_filiere == x.id_filiere
                          select e;

                chart1.Series["Nombre Etudiant"].Points.AddXY(x.nom_filiere, tmp.Count());

            }

        }

        void FillFiliereCombobox()
        {
            choixFiliereCombo.Items.Clear();
            var fil = from f in cl.filiere orderby f.nom_filiere select f;
            choixFiliereCombo.Items.Clear();
            foreach (var u in fil)
            {
                choixFiliereCombo.Items.Add(new ComboBoxItem(u.id_filiere, u.nom_filiere));
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            var cne = cne_textBox.Text;
            var x = from et in cl.Etudiant
                    where et.cne == cne
                    select et;

            if(x.Count() > 0)
            {
                MessageBox.Show("Le CNE existe déjà dans la base de données!");
                return;
            }


            if (female_radio.Checked)
            {
                choix = "M";
            }
            else choix = "F";
            var etu = new Etudiant();
            etu.cne = cne;
            etu.nom = nom_textbox.Text;
            etu.prenom = prenom_textbox.Text;
            etu.adresse = adresse_textbox.Text;
            etu.sexe = choix[0];
            etu.date_naissance = date_naissance.Value;

            etu.tele = tele_textbox.Text;
            ComboBoxItem cnb = (ComboBoxItem)choixFiliereCombo.SelectedItem;
            etu.id_filiere = cnb.Value1;
            cl.Etudiant.InsertOnSubmit(etu);
            cl.SubmitChanges();
            MessageBox.Show("L'étudiant a été ajouté avec succès.");
            dataGridView1.Refresh();
            CleanTextBoxs();

        }

        void CleanTextBoxs()
        {
            cne_textBox.Text = "";
            nom_textbox.Text = "";
            prenom_textbox.Text = "";
            adresse_textbox.Text = "";
            female_radio.Checked = false;
            male_radio.Checked = false;
            tele_textbox.Text = "";
            choixFiliereCombo.Text = "";
            date_naissance.Value = DateTimePicker.MinimumDateTime;
            cherche_etudiant_combobox.Text = "";


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifiyingPannel.Visible = false;
            try
            {
                string rowindex = tableFiliere.CurrentCell.Value.ToString();
                var update = (from p in cl.filiere
                             where p.id_filiere == Convert.ToInt16(FiliereId)// match the ecords.
                             select p).SingleOrDefault();
                update.nom_filiere = ModifiedName.Text;
                cl.SubmitChanges();
                loadFiliereData();
                MessageBox.Show("La filière a été modifiée avec succès.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void modifierFiliereBtn_Click(object sender, EventArgs e)
        {
            ModifiyingPannel.Visible = true;
            
             FiliereId = tableFiliere.CurrentCell.Value.ToString();
            var select = (from p in cl.filiere
                          where p.id_filiere == Convert.ToInt16(FiliereId)// match the ecords.
                          select p).SingleOrDefault();

            ModifiedName.Text = select.nom_filiere;

        }

        private void ajouterFiliereBtn_Click(object sender, EventArgs e)
        {
            
            filiere NewFil = new filiere();
            NewFil.nom_filiere = ajouterFiliereInput.Text;
            cl.filiere.InsertOnSubmit(NewFil);
            cl.SubmitChanges();
            loadFiliereData();
            MessageBox.Show("La filière a été ajoutée avec succès.");
            ajouterFiliereInput.Text ="";

        }

        private void supprimerFiliereBtn_Click(object sender, EventArgs e)
        { try {
                string rowindex = tableFiliere.CurrentCell.Value.ToString();
                var delete = from p in cl.filiere
                             where p.id_filiere == Convert.ToInt16(rowindex)// match the ecords.
                             select p;
                cl.filiere.DeleteOnSubmit(delete.SingleOrDefault());
                cl.SubmitChanges();
                loadFiliereData();
                MessageBox.Show("La filière a été supprimée avec succès.");
            }
            catch(SqlException ex)
            {
                
                MessageBox.Show(ex.Message +" ====== "+ cl.GetChangeSet().Deletes.Count());
                Discard_deletes();
                
            }
            }

        void Discard_deletes()
        {
            ChangeSet changeSet = cl.GetChangeSet();
            foreach (object objToDelete in changeSet.Deletes)
            {
                cl.GetTable(objToDelete.GetType()).InsertOnSubmit(objToDelete);
            }
        }

        void FillChercherEtudiant()
        {
            try
            {
                cherche_etudiant_combobox.Items.Clear();
                var x = from e in cl.Etudiant select e;

                foreach (var etu in x)
                {
                    cherche_etudiant_combobox.Items.Add(new ComboBoxItem(Int32.Parse(etu.cne), etu.cne +" "+etu.nom));
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }


        void FillTextBox_Etudiant(Etudiant e)
        {
            cne_textBox.Text = e.cne;
            nom_textbox.Text = e.nom;
            prenom_textbox.Text = e.prenom;
            adresse_textbox.Text = e.adresse;

            if(e.sexe == 'M')
            {
                male_radio.Checked = true;
            }
            else
            {
                female_radio.Checked = true;
            }
            tele_textbox.Text = e.tele;
            date_naissance.Value = (DateTime)e.date_naissance;
            choixFiliereCombo.Text = e.filiere.nom_filiere;

        }

        private void cherche_etudiant_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbbi = (ComboBoxItem)cherche_etudiant_combobox.SelectedItem;

            var x = from et in cl.Etudiant
                    where et.cne.Equals(cbbi.Value1.ToString())
                    select et;
            FillTextBox_Etudiant(x.SingleOrDefault());
        }

        public void loadDataEtudiants()
        {
            var etu = from p in cl.Etudiant
                      join d in cl.filiere on p.id_filiere equals d.id_filiere
                      select new
                      {
                          p.cne,
                          p.nom,
                          p.prenom,
                          p.adresse,
                          p.sexe,
                          p.date_naissance,
                          p.tele,
                          d.nom_filiere
                      };

     
            dataGridView1.DataSource = etu;
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                var x = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                
                var etudiant = from et in cl.Etudiant
                               where et.cne == x
                               select et;



               FillTextBox_Etudiant(etudiant.SingleOrDefault());
            }
        }

        private void resetForm_Click(object sender, EventArgs e)
        {
            CleanTextBoxs();
        }

        void FillReportingCombobox()
        {
            try
            {
                CINreportingCombobox.Items.Clear();
                var x = from e in cl.Etudiant select e;

                foreach (var etu in x)
                {
                    CINreportingCombobox.Items.Add(new ComboBoxItem(Convert.ToInt32(etu.cne), etu.cne +" "+ etu.nom));
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resfreshButton_Click(object sender, EventArgs e)
        {
            loadFiliereData();
            FillFiliereCombobox();
            fillStatisticsChart();
            FillChercherEtudiant();
            FillReportingCombobox();
        }

        private void Importer_Click(object sender, EventArgs e)
        {
            Importer im = new Importer();
            im.ShowDialog();
        }
    }
    }

