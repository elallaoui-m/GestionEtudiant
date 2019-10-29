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
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["gestion_etudiantConnectionString"].ConnectionString;
        SqlConnection con;
        SqlDataReader datare;
    
        DataClasses1DataContext cl = new DataClasses1DataContext();
        string choix = "";
        String cin;
        public mainWindow()
        {
            InitializeComponent();

        }
        
        private void ajouterFiliereBox_Enter(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                choix = "M";
            }
            else choix = "F";
            Etudiant p = new Etudiant();
            p.cne = textBox1.Text;
            p.nom = textBox2.Text;
            p.prenom = textBox3.Text;
            p.adresse = textBox4.Text;
            p.sexe = choix[0];
            p.date_naissance = dateTimePicker1.Value;
            p.tele = textBox5.Text;
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
            var fil = from f in cl.filiere orderby f.nom_filiere select f;
            comboBox2.Items.Clear();
            foreach (var u in fil)
            {
                comboBox2.Items.Add(new ComboBoxItem(u.id_filiere, u.nom_filiere));
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            var p = cl.Etudiant.SingleOrDefault(x => x.id_etudiant == Convert.ToInt32(textBox1.Text));
            cl.Etudiant.DeleteOnSubmit(p);
            cl.SubmitChanges();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                choix = "M";
            }
            else choix = "F";
            var etu = cl.Etudiant.SingleOrDefault(x => x.id_etudiant == Convert.ToInt32(textBox1.Text));
            etu.nom = textBox2.Text;
            etu.prenom = textBox3.Text;
            etu.adresse = textBox4.Text;
            etu.sexe = choix[0];
            etu.date_naissance = dateTimePicker1.Value;
            
            etu.tele = textBox5.Text;
            etu.id_filiere = Int32.Parse((string)comboBox1.SelectedValue);
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
            /*con = new SqlConnection(cs);
            con.Open();

            //commande1
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "SELECT * FROM Etudiant e INNER JOIN filiere f ON e.id_filiere = f.id_filiere WHERE f.id_filiere = 1";
            SqlDataReader lirecmd1 = cmd1.ExecuteReader();
            lirecmd1.Close();


            //commande2
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandText = "SELECT * FROM Etudiant e INNER JOIN filiere f ON e.id_filiere = f.id_filiere WHERE f.id_filiere = 2";
            SqlDataReader lirecmd2 = cmd2.ExecuteReader();
            lirecmd2.Close();

            //commande3
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandText = "SELECT * FROM Etudiant e INNER JOIN filiere f ON e.id_filiere = f.id_filiere WHERE f. id_filiere = 3";
            SqlDataReader lirecmd3 = cmd3.ExecuteReader();
            lirecmd3.Close();

            DataTable dt1 = new DataTable();
            dt1.Load(lirecmd1);
            DataTable dt2 = new DataTable();
            dt2.Load(lirecmd2);
            DataTable dt3 = new DataTable();
            dt3.Load(lirecmd3);



            int var1 = Int32.Parse(dt1.Rows[0][0].ToString());
            int var2 = Int32.Parse(dt2.Rows[0][0].ToString());
            int var3 = Int32.Parse(dt3.Rows[0][0].ToString());




            chart1.Series["Nombre Etudiant"].Points.AddXY("informatique", var1);
            chart1.Series["Nombre Etudiant"].Points.AddXY("industriel", var2);
            chart1.Series["Nombre Etudiant"].Points.AddXY("telecome", var3);


            con.Close();*/

            fillStatisticsChart();

        }

        void fillStatisticsChart()
        {
            var filiere = from f in cl.filiere select f;
            Console.WriteLine("123");

            
        }
    }
}
