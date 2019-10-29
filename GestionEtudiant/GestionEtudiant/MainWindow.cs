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
    
        DataClasses1DataContext cl = new DataClasses1DataContext();
        string choix = "";
        String cin;
        public mainWindow()
        {
            InitializeComponent();

        }
        
        private void ajouterFiliereBox_Enter(object sender, EventArgs e)
        {
            if (female_radio.Checked)
            {
                choix = "M";
            }
            else choix = "F";
            Etudiant p = new Etudiant();
            p.cne = cne_textBox.Text;
            p.nom = nom_textbox.Text;
            p.prenom = prenom_textbox.Text;
            p.adresse = adresse_textbox.Text;
            p.sexe = choix[0];
            p.date_naissance = date_naissance.Value;
            p.tele = tele_textbox.Text;
            ComboBoxItem cbm = (ComboBoxItem)comboBox2.SelectedItem;

            p.id_filiere = cbm.Value1;
            cl.Etudiant.InsertOnSubmit(p);

            cl.SubmitChanges();

            dataGridView1.Refresh();
            MessageBox.Show("inserted");
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
                      
            FillFiliereCombobox();
            fillStatisticsChart();

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
    }
}
