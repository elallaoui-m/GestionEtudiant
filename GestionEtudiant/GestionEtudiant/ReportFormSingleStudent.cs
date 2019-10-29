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
        String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["gestion_etudiantConnectionString"].ToString();
        DataClasses1DataContext cl = new DataClasses1DataContext();



        public ReportFormSingleStudent()
        {
            InitializeComponent();
        }

        private void ReportFormSingleStudent_Load(object sender, EventArgs e)
        {


            
            SingleStudent cr = new SingleStudent();
            string sql = "SELECT * FROM Etudiant WHERE CNE = " + CIN + "";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);

            adapter.Fill(ds, "Etudiant");
            DataTable dt = ds.Tables["Etudiant"];

            cr.SetDataSource(ds.Tables["Etudiant"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

        }

        public void getCIN (String a)
        {
            CIN = a.ToString();
        }


    }
}
