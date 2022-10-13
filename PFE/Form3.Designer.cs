
namespace PFE
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sAMUDataSet21 = new PFE.SAMUDataSet21();
            this.patientTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTTableAdapter = new PFE.SAMUDataSet21TableAdapters.patientTTableAdapter();
            this.iDpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenompatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agepatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genrepatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gouvernoratpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poulsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPO2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dextroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpatientDataGridViewTextBoxColumn,
            this.nompatientDataGridViewTextBoxColumn,
            this.prenompatientDataGridViewTextBoxColumn,
            this.agepatientDataGridViewTextBoxColumn,
            this.genrepatientDataGridViewTextBoxColumn,
            this.gouvernoratpatientDataGridViewTextBoxColumn,
            this.gcsDataGridViewTextBoxColumn,
            this.tADataGridViewTextBoxColumn,
            this.poulsDataGridViewTextBoxColumn,
            this.fRDataGridViewTextBoxColumn,
            this.sPO2DataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn,
            this.dextroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(193, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // sAMUDataSet21
            // 
            this.sAMUDataSet21.DataSetName = "SAMUDataSet21";
            this.sAMUDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTBindingSource
            // 
            this.patientTBindingSource.DataMember = "patientT";
            this.patientTBindingSource.DataSource = this.sAMUDataSet21;
            // 
            // patientTTableAdapter
            // 
            this.patientTTableAdapter.ClearBeforeFill = true;
            // 
            // iDpatientDataGridViewTextBoxColumn
            // 
            this.iDpatientDataGridViewTextBoxColumn.DataPropertyName = "IDpatient";
            this.iDpatientDataGridViewTextBoxColumn.HeaderText = "IDpatient";
            this.iDpatientDataGridViewTextBoxColumn.Name = "iDpatientDataGridViewTextBoxColumn";
            // 
            // nompatientDataGridViewTextBoxColumn
            // 
            this.nompatientDataGridViewTextBoxColumn.DataPropertyName = "Nompatient";
            this.nompatientDataGridViewTextBoxColumn.HeaderText = "Nompatient";
            this.nompatientDataGridViewTextBoxColumn.Name = "nompatientDataGridViewTextBoxColumn";
            // 
            // prenompatientDataGridViewTextBoxColumn
            // 
            this.prenompatientDataGridViewTextBoxColumn.DataPropertyName = "Prenompatient";
            this.prenompatientDataGridViewTextBoxColumn.HeaderText = "Prenompatient";
            this.prenompatientDataGridViewTextBoxColumn.Name = "prenompatientDataGridViewTextBoxColumn";
            // 
            // agepatientDataGridViewTextBoxColumn
            // 
            this.agepatientDataGridViewTextBoxColumn.DataPropertyName = "Agepatient";
            this.agepatientDataGridViewTextBoxColumn.HeaderText = "Agepatient";
            this.agepatientDataGridViewTextBoxColumn.Name = "agepatientDataGridViewTextBoxColumn";
            // 
            // genrepatientDataGridViewTextBoxColumn
            // 
            this.genrepatientDataGridViewTextBoxColumn.DataPropertyName = "Genrepatient";
            this.genrepatientDataGridViewTextBoxColumn.HeaderText = "Genrepatient";
            this.genrepatientDataGridViewTextBoxColumn.Name = "genrepatientDataGridViewTextBoxColumn";
            // 
            // gouvernoratpatientDataGridViewTextBoxColumn
            // 
            this.gouvernoratpatientDataGridViewTextBoxColumn.DataPropertyName = "Gouvernoratpatient";
            this.gouvernoratpatientDataGridViewTextBoxColumn.HeaderText = "Gouvernoratpatient";
            this.gouvernoratpatientDataGridViewTextBoxColumn.Name = "gouvernoratpatientDataGridViewTextBoxColumn";
            // 
            // gcsDataGridViewTextBoxColumn
            // 
            this.gcsDataGridViewTextBoxColumn.DataPropertyName = "Gcs";
            this.gcsDataGridViewTextBoxColumn.HeaderText = "Gcs";
            this.gcsDataGridViewTextBoxColumn.Name = "gcsDataGridViewTextBoxColumn";
            // 
            // tADataGridViewTextBoxColumn
            // 
            this.tADataGridViewTextBoxColumn.DataPropertyName = "TA";
            this.tADataGridViewTextBoxColumn.HeaderText = "TA";
            this.tADataGridViewTextBoxColumn.Name = "tADataGridViewTextBoxColumn";
            // 
            // poulsDataGridViewTextBoxColumn
            // 
            this.poulsDataGridViewTextBoxColumn.DataPropertyName = "Pouls";
            this.poulsDataGridViewTextBoxColumn.HeaderText = "Pouls";
            this.poulsDataGridViewTextBoxColumn.Name = "poulsDataGridViewTextBoxColumn";
            // 
            // fRDataGridViewTextBoxColumn
            // 
            this.fRDataGridViewTextBoxColumn.DataPropertyName = "FR";
            this.fRDataGridViewTextBoxColumn.HeaderText = "FR";
            this.fRDataGridViewTextBoxColumn.Name = "fRDataGridViewTextBoxColumn";
            // 
            // sPO2DataGridViewTextBoxColumn
            // 
            this.sPO2DataGridViewTextBoxColumn.DataPropertyName = "SPO2";
            this.sPO2DataGridViewTextBoxColumn.HeaderText = "SPO2";
            this.sPO2DataGridViewTextBoxColumn.Name = "sPO2DataGridViewTextBoxColumn";
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "T";
            this.tDataGridViewTextBoxColumn.HeaderText = "T";
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            // 
            // dextroDataGridViewTextBoxColumn
            // 
            this.dextroDataGridViewTextBoxColumn.DataPropertyName = "Dextro";
            this.dextroDataGridViewTextBoxColumn.HeaderText = "Dextro";
            this.dextroDataGridViewTextBoxColumn.Name = "dextroDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SAMUDataSet21 sAMUDataSet21;
        private System.Windows.Forms.BindingSource patientTBindingSource;
        private SAMUDataSet21TableAdapters.patientTTableAdapter patientTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenompatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agepatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genrepatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gouvernoratpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poulsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPO2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dextroDataGridViewTextBoxColumn;
    }
}