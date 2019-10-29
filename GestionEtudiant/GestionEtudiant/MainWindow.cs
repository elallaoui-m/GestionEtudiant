using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        


        private void charger_donnes_Click(object sender, EventArgs e)
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

            //Console.Write(etu.FirstOrDefault().cne);

            dataGridView1.DataSource = etu;
           
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            var p = cl.Etudiant.SingleOrDefault(x => x.id_etudiant == Convert.ToInt32(cne_textBox.Text));
            cl.Etudiant.DeleteOnSubmit(p);
            cl.SubmitChanges();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (female_radio.Checked)
            {
                choix = "M";
            }
            else choix = "F";
            var etu = cl.Etudiant.SingleOrDefault(x => x.id_etudiant == Convert.ToInt32(cne_textBox.Text));
            etu.nom = nom_textbox.Text;
            etu.prenom = prenom_textbox.Text;
            etu.adresse = adresse_textbox.Text;
            etu.sexe = choix[0];
            etu.date_naissance = date_naissance.Value;
            
            etu.tele = tele_textbox.Text;
            etu.id_filiere = Int32.Parse((string)cherche_etudiant_combobox.SelectedValue);
            cl.SubmitChanges();
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
                reportingTextBox.Show();
                reportingLabel.Show();
                reportingGenerate.Hide();
            } else
            {
                reportingButton.Hide();
                reportingTextBox.Hide();
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
            cin = reportingTextBox.Text;
            ReportFormSingleStudent reportFormSingleStudent = new ReportFormSingleStudent();
            reportFormSingleStudent.getCIN(cin.ToString());
            reportFormSingleStudent.Show();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            loadFiliereData();
            FillFiliereCombobox();
            fillStatisticsChart();
            ModifiyingPannel.Visible = false;
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
            var fil = from f in cl.filiere orderby f.nom_filiere select f;
            comboBox2.Items.Clear();
            foreach (var u in fil)
            {
                comboBox2.Items.Add(new ComboBoxItem(u.id_filiere, u.nom_filiere));
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (female_radio.Checked)
            {
                choix = "M";
            }
            else choix = "F";
            var etu = new Etudiant();
            etu.nom = nom_textbox.Text;
            etu.prenom = prenom_textbox.Text;
            etu.adresse = adresse_textbox.Text;
            etu.sexe = choix[0];
            etu.date_naissance = date_naissance.Value;

            etu.tele = tele_textbox.Text;
            etu.id_filiere = Int32.Parse((string)cherche_etudiant_combobox.SelectedValue);
            cl.SubmitChanges();
            MessageBox.Show("Inserted succesfuly");
            dataGridView1.Refresh();
            CleanTextBoxs();

        }

        void CleanTextBoxs()
        {
            nom_textbox.Text = "";
            prenom_textbox.Text = "";
            adresse_textbox.Text = "";
            female_radio.Checked = false;
            male_radio.Checked = false;
            tele_textbox.Text = "";


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
                MessageBox.Show("la filliere a été Modifié avec Succes ");
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
            MessageBox.Show("Filiere bien ajoutee");
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
                MessageBox.Show("la filliere a éte Supprimer avec Succes ");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    }
    }

