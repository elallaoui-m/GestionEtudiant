using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
namespace GestionEtudiant
{
    public partial class Importer : Form
    {
        
        DataTable dt;
        DataClasses1DataContext cl = new DataClasses1DataContext();

        public Importer()
        {
            InitializeComponent();
        }

        private void chooseExcelFile_Click(object sender, EventArgs e)
        {
           using (OpenFileDialog openFileDialog = new OpenFileDialog(){Filter= "Excel 97-2003 Workbook|.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    importInputPlaceholder.Text = openFileDialog.FileName;

                    FileStream stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader excelReader;

                    //1. Reading Excel file
                    if (Path.GetExtension(openFileDialog.FileName).ToUpper() == ".XLS")
                    {
                        //1.1 Reading from a binary Excel file ('97-2003 format; *.xls)
                        excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    else
                    {
                        //1.2 Reading from a OpenXml Excel file (2007 format; *.xlsx)
                        excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }

                    //2. DataSet - The result of each spreadsheet will be created in the result.Tables
                    DataSet result = excelReader.AsDataSet();

                    //just to check how many rows returns
                    MessageBox.Show(excelReader.RowCount.ToString());

                    dt = result.Tables[0];

                    // check if data work correctly
                    MessageBox.Show(dt.Rows[0][1].ToString());

                }
            }


        }

        private void Importer_Load(object sender, EventArgs e)
        {
            
        }

        private void ImportExcelFile_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count>0)
            {
                int addedRows = 0;
                foreach (DataRow dr in dt.Rows){
                    if (!StudentExist(dr[0].ToString())){
                        addedRows++;
                        Etudiant etudiant = new Etudiant();
                        etudiant.cne = dr[0].ToString();
                        etudiant.nom = dr[1].ToString();
                        etudiant.prenom = dr[2].ToString();
                        etudiant.sexe = Convert.ToChar(dr[3]);
                        etudiant.date_naissance = (DateTime)dr[4];
                        etudiant.adresse = dr[5].ToString();
                        etudiant.tele = dr[6].ToString();
                        etudiant.id_filiere = Convert.ToInt32(dr[7]);
                        cl.Etudiant.InsertOnSubmit(etudiant);
                        cl.SubmitChanges();
                    }
                    
                }
                this.Hide(); 
                MessageBox.Show(addedRows + " étudiant été ajouté(s) et " + dt.Rows.Count + " déjà existe");

            }
            else MessageBox.Show("Nothing To Import");
        }

        bool StudentExist(String cne)
        {
            var x = from c in cl.Etudiant
                    where c.cne == cne
                    select c;
            if(x.Count()>0)
                   return true;

            return false;
        }

    }
}