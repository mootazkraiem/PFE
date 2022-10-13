
namespace PFE
{
    partial class appelchercher
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
            this.appeltableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet9 = new PFE.SAMUDataSet9();
            this.appeltableTableAdapter = new PFE.SAMUDataSet9TableAdapters.AppeltableTableAdapter();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.cleAppelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinregulateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBvictimesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetdedemandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decisionderegulationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculeengageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifdappelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typologiepathologieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathologieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validationmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilitedemissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idappelantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appeltableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet15 = new PFE.SAMUDataSet15();
            this.appeltableTableAdapter1 = new PFE.SAMUDataSet15TableAdapters.AppeltableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appeltableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appeltableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // appeltableBindingSource
            // 
            this.appeltableBindingSource.DataMember = "Appeltable";
            this.appeltableBindingSource.DataSource = this.sAMUDataSet9;
            // 
            // sAMUDataSet9
            // 
            this.sAMUDataSet9.DataSetName = "SAMUDataSet9";
            this.sAMUDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appeltableTableAdapter
            // 
            this.appeltableTableAdapter.ClearBeforeFill = true;
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
            this.cleAppelDataGridViewTextBoxColumn,
            this.medecinregulateurDataGridViewTextBoxColumn,
            this.nBvictimesDataGridViewTextBoxColumn,
            this.paramDataGridViewTextBoxColumn,
            this.objetdedemandeDataGridViewTextBoxColumn,
            this.decisionderegulationDataGridViewTextBoxColumn,
            this.vehiculeengageDataGridViewTextBoxColumn,
            this.motifdappelDataGridViewTextBoxColumn,
            this.typologiepathologieDataGridViewTextBoxColumn,
            this.pathologieDataGridViewTextBoxColumn,
            this.validationmissionDataGridViewTextBoxColumn,
            this.utilitedemissionDataGridViewTextBoxColumn,
            this.idappelantDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.appeltableBindingSource1;
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
            this.advancedDataGridView1.Size = new System.Drawing.Size(793, 538);
            this.advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView1.TabIndex = 1;
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick_1);
            // 
            // cleAppelDataGridViewTextBoxColumn
            // 
            this.cleAppelDataGridViewTextBoxColumn.DataPropertyName = "CleAppel";
            this.cleAppelDataGridViewTextBoxColumn.HeaderText = "CleAppel";
            this.cleAppelDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cleAppelDataGridViewTextBoxColumn.Name = "cleAppelDataGridViewTextBoxColumn";
            this.cleAppelDataGridViewTextBoxColumn.ReadOnly = true;
            this.cleAppelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cleAppelDataGridViewTextBoxColumn.Width = 109;
            // 
            // medecinregulateurDataGridViewTextBoxColumn
            // 
            this.medecinregulateurDataGridViewTextBoxColumn.DataPropertyName = "Medecinregulateur";
            this.medecinregulateurDataGridViewTextBoxColumn.HeaderText = "Medecinregulateur";
            this.medecinregulateurDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.medecinregulateurDataGridViewTextBoxColumn.Name = "medecinregulateurDataGridViewTextBoxColumn";
            this.medecinregulateurDataGridViewTextBoxColumn.ReadOnly = true;
            this.medecinregulateurDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.medecinregulateurDataGridViewTextBoxColumn.Width = 185;
            // 
            // nBvictimesDataGridViewTextBoxColumn
            // 
            this.nBvictimesDataGridViewTextBoxColumn.DataPropertyName = "NBvictimes";
            this.nBvictimesDataGridViewTextBoxColumn.HeaderText = "NBvictimes";
            this.nBvictimesDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nBvictimesDataGridViewTextBoxColumn.Name = "nBvictimesDataGridViewTextBoxColumn";
            this.nBvictimesDataGridViewTextBoxColumn.ReadOnly = true;
            this.nBvictimesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nBvictimesDataGridViewTextBoxColumn.Width = 121;
            // 
            // paramDataGridViewTextBoxColumn
            // 
            this.paramDataGridViewTextBoxColumn.DataPropertyName = "Param";
            this.paramDataGridViewTextBoxColumn.HeaderText = "Param";
            this.paramDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.paramDataGridViewTextBoxColumn.Name = "paramDataGridViewTextBoxColumn";
            this.paramDataGridViewTextBoxColumn.ReadOnly = true;
            this.paramDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.paramDataGridViewTextBoxColumn.Width = 86;
            // 
            // objetdedemandeDataGridViewTextBoxColumn
            // 
            this.objetdedemandeDataGridViewTextBoxColumn.DataPropertyName = "Objetdedemande";
            this.objetdedemandeDataGridViewTextBoxColumn.HeaderText = "Objetdedemande";
            this.objetdedemandeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.objetdedemandeDataGridViewTextBoxColumn.Name = "objetdedemandeDataGridViewTextBoxColumn";
            this.objetdedemandeDataGridViewTextBoxColumn.ReadOnly = true;
            this.objetdedemandeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.objetdedemandeDataGridViewTextBoxColumn.Width = 177;
            // 
            // decisionderegulationDataGridViewTextBoxColumn
            // 
            this.decisionderegulationDataGridViewTextBoxColumn.DataPropertyName = "Decisionderegulation";
            this.decisionderegulationDataGridViewTextBoxColumn.HeaderText = "Decisionderegulation";
            this.decisionderegulationDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.decisionderegulationDataGridViewTextBoxColumn.Name = "decisionderegulationDataGridViewTextBoxColumn";
            this.decisionderegulationDataGridViewTextBoxColumn.ReadOnly = true;
            this.decisionderegulationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.decisionderegulationDataGridViewTextBoxColumn.Width = 202;
            // 
            // vehiculeengageDataGridViewTextBoxColumn
            // 
            this.vehiculeengageDataGridViewTextBoxColumn.DataPropertyName = "Vehiculeengage";
            this.vehiculeengageDataGridViewTextBoxColumn.HeaderText = "Vehiculeengage";
            this.vehiculeengageDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.vehiculeengageDataGridViewTextBoxColumn.Name = "vehiculeengageDataGridViewTextBoxColumn";
            this.vehiculeengageDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehiculeengageDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.vehiculeengageDataGridViewTextBoxColumn.Width = 167;
            // 
            // motifdappelDataGridViewTextBoxColumn
            // 
            this.motifdappelDataGridViewTextBoxColumn.DataPropertyName = "Motifdappel";
            this.motifdappelDataGridViewTextBoxColumn.HeaderText = "Motifdappel";
            this.motifdappelDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.motifdappelDataGridViewTextBoxColumn.Name = "motifdappelDataGridViewTextBoxColumn";
            this.motifdappelDataGridViewTextBoxColumn.ReadOnly = true;
            this.motifdappelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.motifdappelDataGridViewTextBoxColumn.Width = 130;
            // 
            // typologiepathologieDataGridViewTextBoxColumn
            // 
            this.typologiepathologieDataGridViewTextBoxColumn.DataPropertyName = "Typologiepathologie";
            this.typologiepathologieDataGridViewTextBoxColumn.HeaderText = "Typologiepathologie";
            this.typologiepathologieDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.typologiepathologieDataGridViewTextBoxColumn.Name = "typologiepathologieDataGridViewTextBoxColumn";
            this.typologiepathologieDataGridViewTextBoxColumn.ReadOnly = true;
            this.typologiepathologieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.typologiepathologieDataGridViewTextBoxColumn.Width = 197;
            // 
            // pathologieDataGridViewTextBoxColumn
            // 
            this.pathologieDataGridViewTextBoxColumn.DataPropertyName = "pathologie";
            this.pathologieDataGridViewTextBoxColumn.HeaderText = "pathologie";
            this.pathologieDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pathologieDataGridViewTextBoxColumn.Name = "pathologieDataGridViewTextBoxColumn";
            this.pathologieDataGridViewTextBoxColumn.ReadOnly = true;
            this.pathologieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pathologieDataGridViewTextBoxColumn.Width = 121;
            // 
            // validationmissionDataGridViewTextBoxColumn
            // 
            this.validationmissionDataGridViewTextBoxColumn.DataPropertyName = "Validationmission";
            this.validationmissionDataGridViewTextBoxColumn.HeaderText = "Validationmission";
            this.validationmissionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.validationmissionDataGridViewTextBoxColumn.Name = "validationmissionDataGridViewTextBoxColumn";
            this.validationmissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.validationmissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.validationmissionDataGridViewTextBoxColumn.Width = 173;
            // 
            // utilitedemissionDataGridViewTextBoxColumn
            // 
            this.utilitedemissionDataGridViewTextBoxColumn.DataPropertyName = "Utilitedemission";
            this.utilitedemissionDataGridViewTextBoxColumn.HeaderText = "Utilitedemission";
            this.utilitedemissionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.utilitedemissionDataGridViewTextBoxColumn.Name = "utilitedemissionDataGridViewTextBoxColumn";
            this.utilitedemissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.utilitedemissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.utilitedemissionDataGridViewTextBoxColumn.Width = 155;
            // 
            // idappelantDataGridViewTextBoxColumn
            // 
            this.idappelantDataGridViewTextBoxColumn.DataPropertyName = "Idappelant";
            this.idappelantDataGridViewTextBoxColumn.HeaderText = "Idappelant";
            this.idappelantDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idappelantDataGridViewTextBoxColumn.Name = "idappelantDataGridViewTextBoxColumn";
            this.idappelantDataGridViewTextBoxColumn.ReadOnly = true;
            this.idappelantDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idappelantDataGridViewTextBoxColumn.Width = 123;
            // 
            // appeltableBindingSource1
            // 
            this.appeltableBindingSource1.DataMember = "Appeltable";
            this.appeltableBindingSource1.DataSource = this.sAMUDataSet15;
            // 
            // sAMUDataSet15
            // 
            this.sAMUDataSet15.DataSetName = "SAMUDataSet15";
            this.sAMUDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appeltableTableAdapter1
            // 
            this.appeltableTableAdapter1.ClearBeforeFill = true;
            // 
            // appelchercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(793, 538);
            this.Controls.Add(this.advancedDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appelchercher";
            this.Text = "appelchercher";
            this.Load += new System.EventHandler(this.appelchercher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appeltableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appeltableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SAMUDataSet9 sAMUDataSet9;
        private System.Windows.Forms.BindingSource appeltableBindingSource;
        private SAMUDataSet9TableAdapters.AppeltableTableAdapter appeltableTableAdapter;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private SAMUDataSet15 sAMUDataSet15;
        private System.Windows.Forms.BindingSource appeltableBindingSource1;
        private SAMUDataSet15TableAdapters.AppeltableTableAdapter appeltableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleAppelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinregulateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nBvictimesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetdedemandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decisionderegulationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculeengageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifdappelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typologiepathologieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathologieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validationmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilitedemissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idappelantDataGridViewTextBoxColumn;
    }
}