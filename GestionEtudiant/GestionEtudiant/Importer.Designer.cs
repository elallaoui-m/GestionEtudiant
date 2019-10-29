namespace GestionEtudiant
{
    partial class Importer
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
            this.importInputPlaceholder = new System.Windows.Forms.TextBox();
            this.ImportExcelFile = new System.Windows.Forms.Button();
            this.chooseExcelFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // importInputPlaceholder
            // 
            this.importInputPlaceholder.Location = new System.Drawing.Point(157, 80);
            this.importInputPlaceholder.Name = "importInputPlaceholder";
            this.importInputPlaceholder.Size = new System.Drawing.Size(243, 22);
            this.importInputPlaceholder.TabIndex = 1;
            // 
            // ImportExcelFile
            // 
            this.ImportExcelFile.Location = new System.Drawing.Point(178, 154);
            this.ImportExcelFile.Name = "ImportExcelFile";
            this.ImportExcelFile.Size = new System.Drawing.Size(166, 33);
            this.ImportExcelFile.TabIndex = 2;
            this.ImportExcelFile.Text = "Charger dans la DB";
            this.ImportExcelFile.UseVisualStyleBackColor = true;
            this.ImportExcelFile.Click += new System.EventHandler(this.ImportExcelFile_Click);
            // 
            // chooseExcelFile
            // 
            this.chooseExcelFile.Location = new System.Drawing.Point(406, 75);
            this.chooseExcelFile.Name = "chooseExcelFile";
            this.chooseExcelFile.Size = new System.Drawing.Size(62, 33);
            this.chooseExcelFile.TabIndex = 0;
            this.chooseExcelFile.Text = "...";
            this.chooseExcelFile.UseVisualStyleBackColor = true;
            this.chooseExcelFile.Click += new System.EventHandler(this.chooseExcelFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du fichier :";
            // 
            // Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImportExcelFile);
            this.Controls.Add(this.importInputPlaceholder);
            this.Controls.Add(this.chooseExcelFile);
            this.Name = "Importer";
            this.Text = "Importer";
            this.Load += new System.EventHandler(this.Importer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox importInputPlaceholder;
        private System.Windows.Forms.Button ImportExcelFile;
        private System.Windows.Forms.Button chooseExcelFile;
        private System.Windows.Forms.Label label1;
    }
}