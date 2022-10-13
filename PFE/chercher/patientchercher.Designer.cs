
namespace PFE
{
    partial class patientchercher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
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
            this.patientTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet18 = new PFE.SAMUDataSet18();
            this.patientTTableAdapter = new PFE.SAMUDataSet18TableAdapters.patientTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet18)).BeginInit();
            this.SuspendLayout();
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.advancedDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.advancedDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.advancedDataGridView1.DataSource = this.patientTBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView1.GridColor = System.Drawing.Color.LightSkyBlue;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.RowHeadersVisible = false;
            this.advancedDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.advancedDataGridView1.Size = new System.Drawing.Size(750, 461);
            this.advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView1.TabIndex = 3;
            // 
            // iDpatientDataGridViewTextBoxColumn
            // 
            this.iDpatientDataGridViewTextBoxColumn.DataPropertyName = "IDpatient";
            this.iDpatientDataGridViewTextBoxColumn.HeaderText = "IDpatient";
            this.iDpatientDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDpatientDataGridViewTextBoxColumn.Name = "iDpatientDataGridViewTextBoxColumn";
            this.iDpatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDpatientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.iDpatientDataGridViewTextBoxColumn.Width = 106;
            // 
            // nompatientDataGridViewTextBoxColumn
            // 
            this.nompatientDataGridViewTextBoxColumn.DataPropertyName = "Nompatient";
            this.nompatientDataGridViewTextBoxColumn.HeaderText = "Nompatient";
            this.nompatientDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nompatientDataGridViewTextBoxColumn.Name = "nompatientDataGridViewTextBoxColumn";
            this.nompatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nompatientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nompatientDataGridViewTextBoxColumn.Width = 129;
            // 
            // prenompatientDataGridViewTextBoxColumn
            // 
            this.prenompatientDataGridViewTextBoxColumn.DataPropertyName = "Prenompatient";
            this.prenompatientDataGridViewTextBoxColumn.HeaderText = "Prenompatient";
            this.prenompatientDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.prenompatientDataGridViewTextBoxColumn.Name = "prenompatientDataGridViewTextBoxColumn";
            this.prenompatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenompatientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.prenompatientDataGridViewTextBoxColumn.Width = 150;
            // 
            // agepatientDataGridViewTextBoxColumn
            // 
            this.agepatientDataGridViewTextBoxColumn.DataPropertyName = "Agepatient";
            this.agepatientDataGridViewTextBoxColumn.HeaderText = "Agepatient";
            this.agepatientDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.agepatientDataGridViewTextBoxColumn.Name = "agepatientDataGridViewTextBoxColumn";
            this.agepatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.agepatientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.agepatientDataGridViewTextBoxColumn.Width = 124;
            // 
            // genrepatientDataGridViewTextBoxColumn
            // 
            this.genrepatientDataGridViewTextBoxColumn.DataPropertyName = "Genrepatient";
            this.genrepatientDataGridViewTextBoxColumn.HeaderText = "Genrepatient";
            this.genrepatientDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.genrepatientDataGridViewTextBoxColumn.Name = "genrepatientDataGridViewTextBoxColumn";
            this.genrepatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.genrepatientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.genrepatientDataGridViewTextBoxColumn.Width = 139;
            // 
            // gouvernoratpatientDataGridViewTextBoxColumn
            // 
            this.gouvernoratpatientDataGridViewTextBoxColumn.DataPropertyName = "Gouvernoratpatient";
            this.gouvernoratpatientDataGridViewTextBoxColumn.HeaderText = "Gouvernoratpatient";
            this.gouvernoratpatientDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.gouvernoratpatientDataGridViewTextBoxColumn.Name = "gouvernoratpatientDataGridViewTextBoxColumn";
            this.gouvernoratpatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.gouvernoratpatientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gouvernoratpatientDataGridViewTextBoxColumn.Width = 189;
            // 
            // gcsDataGridViewTextBoxColumn
            // 
            this.gcsDataGridViewTextBoxColumn.DataPropertyName = "Gcs";
            this.gcsDataGridViewTextBoxColumn.HeaderText = "Gcs";
            this.gcsDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.gcsDataGridViewTextBoxColumn.Name = "gcsDataGridViewTextBoxColumn";
            this.gcsDataGridViewTextBoxColumn.ReadOnly = true;
            this.gcsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gcsDataGridViewTextBoxColumn.Width = 65;
            // 
            // tADataGridViewTextBoxColumn
            // 
            this.tADataGridViewTextBoxColumn.DataPropertyName = "TA";
            this.tADataGridViewTextBoxColumn.HeaderText = "TA";
            this.tADataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tADataGridViewTextBoxColumn.Name = "tADataGridViewTextBoxColumn";
            this.tADataGridViewTextBoxColumn.ReadOnly = true;
            this.tADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tADataGridViewTextBoxColumn.Width = 54;
            // 
            // poulsDataGridViewTextBoxColumn
            // 
            this.poulsDataGridViewTextBoxColumn.DataPropertyName = "Pouls";
            this.poulsDataGridViewTextBoxColumn.HeaderText = "Pouls";
            this.poulsDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.poulsDataGridViewTextBoxColumn.Name = "poulsDataGridViewTextBoxColumn";
            this.poulsDataGridViewTextBoxColumn.ReadOnly = true;
            this.poulsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.poulsDataGridViewTextBoxColumn.Width = 75;
            // 
            // fRDataGridViewTextBoxColumn
            // 
            this.fRDataGridViewTextBoxColumn.DataPropertyName = "FR";
            this.fRDataGridViewTextBoxColumn.HeaderText = "FR";
            this.fRDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fRDataGridViewTextBoxColumn.Name = "fRDataGridViewTextBoxColumn";
            this.fRDataGridViewTextBoxColumn.ReadOnly = true;
            this.fRDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fRDataGridViewTextBoxColumn.Width = 52;
            // 
            // sPO2DataGridViewTextBoxColumn
            // 
            this.sPO2DataGridViewTextBoxColumn.DataPropertyName = "SPO2";
            this.sPO2DataGridViewTextBoxColumn.HeaderText = "SPO2";
            this.sPO2DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.sPO2DataGridViewTextBoxColumn.Name = "sPO2DataGridViewTextBoxColumn";
            this.sPO2DataGridViewTextBoxColumn.ReadOnly = true;
            this.sPO2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.sPO2DataGridViewTextBoxColumn.Width = 74;
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "T";
            this.tDataGridViewTextBoxColumn.HeaderText = "T";
            this.tDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            this.tDataGridViewTextBoxColumn.ReadOnly = true;
            this.tDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tDataGridViewTextBoxColumn.Width = 42;
            // 
            // dextroDataGridViewTextBoxColumn
            // 
            this.dextroDataGridViewTextBoxColumn.DataPropertyName = "Dextro";
            this.dextroDataGridViewTextBoxColumn.HeaderText = "Dextro";
            this.dextroDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dextroDataGridViewTextBoxColumn.Name = "dextroDataGridViewTextBoxColumn";
            this.dextroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dextroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dextroDataGridViewTextBoxColumn.Width = 85;
            // 
            // patientTBindingSource
            // 
            this.patientTBindingSource.DataMember = "patientT";
            this.patientTBindingSource.DataSource = this.sAMUDataSet18;
            // 
            // sAMUDataSet18
            // 
            this.sAMUDataSet18.DataSetName = "SAMUDataSet18";
            this.sAMUDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTTableAdapter
            // 
            this.patientTTableAdapter.ClearBeforeFill = true;
            // 
            // patientchercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(750, 461);
            this.Controls.Add(this.advancedDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "patientchercher";
            this.Text = "patientchercher";
            this.Load += new System.EventHandler(this.patientchercher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet18)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private SAMUDataSet18 sAMUDataSet18;
        private System.Windows.Forms.BindingSource patientTBindingSource;
        private SAMUDataSet18TableAdapters.patientTTableAdapter patientTTableAdapter;
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