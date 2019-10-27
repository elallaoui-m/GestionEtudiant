using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class mainWindow : Form
    {
        DataClasses1DataContext cl = new DataClasses1DataContext();
        string choix = "";
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

        private void EtudiantPage_Click(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
