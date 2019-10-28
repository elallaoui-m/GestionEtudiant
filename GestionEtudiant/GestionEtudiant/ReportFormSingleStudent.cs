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
  
    public partial class ReportFormSingleStudent : Form
    {

        String CIN;
        String connectionString = "Server = localhost; Database = gestion_etudiant ; Integrated Security = True;";
        

        public ReportFormSingleStudent()
        {
            InitializeComponent();
        }

        private void ReportFormSingleStudent_Load(object sender, EventArgs e)
        {

        }

        public void getCIN (String a)
        {
            CIN = a.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SingleStudent cr = new SingleStudent();
            string sql = "SELECT * FROM Etudiant WHERE CNE = "+CIN+"";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);

            adapter.Fill(ds, "Etudiant");
            DataTable dt = ds.Tables["Etudiant"];

            cr.SetDataSource(ds.Tables["Etudiant"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
