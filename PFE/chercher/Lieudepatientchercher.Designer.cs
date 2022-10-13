
namespace PFE
{
    partial class Lieudepatientchercher
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
            this.lieudepatienttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet12 = new PFE.SAMUDataSet12();
            this.lieu_de_patient_tableTableAdapter = new PFE.SAMUDataSet12TableAdapters.Lieu_de_patient_tableTableAdapter();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.lieudepatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autrelieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hopitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieudepatienttableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet17 = new PFE.SAMUDataSet17();
            this.lieu_de_patient_tableTableAdapter1 = new PFE.SAMUDataSet17TableAdapters.Lieu_de_patient_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lieudepatienttableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieudepatienttableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet17)).BeginInit();
            this.SuspendLayout();
            // 
            // lieudepatienttableBindingSource
            // 
            this.lieudepatienttableBindingSource.DataMember = "Lieu_de_patient_table";
            this.lieudepatienttableBindingSource.DataSource = this.sAMUDataSet12;
            // 
            // sAMUDataSet12
            // 
            this.sAMUDataSet12.DataSetName = "SAMUDataSet12";
            this.sAMUDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lieu_de_patient_tableTableAdapter
            // 
            this.lieu_de_patient_tableTableAdapter.ClearBeforeFill = true;
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
            this.lieudepatientDataGridViewTextBoxColumn,
            this.autrelieuDataGridViewTextBoxColumn,
            this.hopitalDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.iDpatientDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.lieudepatienttableBindingSource1;
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
            this.advancedDataGridView1.Size = new System.Drawing.Size(617, 465);
            this.advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView1.TabIndex = 2;
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick_1);
            // 
            // lieudepatientDataGridViewTextBoxColumn
            // 
            this.lieudepatientDataGridViewTextBoxColumn.DataPropertyName = "Lieudepatient";
            this.lieudepatientDataGridViewTextBoxColumn.HeaderText = "Lieudepatient";
            this.lieudepatientDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.lieudepatientDataGridViewTextBoxColumn.Name = "lieudepatientDataGridViewTextBoxColumn";
            this.lieudepatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.lieudepatientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.lieudepatientDataGridViewTextBoxColumn.Width = 143;
            // 
            // autrelieuDataGridViewTextBoxColumn
            // 
            this.autrelieuDataGridViewTextBoxColumn.DataPropertyName = "Autrelieu";
            this.autrelieuDataGridViewTextBoxColumn.HeaderText = "Autrelieu";
            this.autrelieuDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.autrelieuDataGridViewTextBoxColumn.Name = "autrelieuDataGridViewTextBoxColumn";
            this.autrelieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.autrelieuDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.autrelieuDataGridViewTextBoxColumn.Width = 105;
            // 
            // hopitalDataGridViewTextBoxColumn
            // 
            this.hopitalDataGridViewTextBoxColumn.DataPropertyName = "Hopital";
            this.hopitalDataGridViewTextBoxColumn.HeaderText = "Hopital";
            this.hopitalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.hopitalDataGridViewTextBoxColumn.Name = "hopitalDataGridViewTextBoxColumn";
            this.hopitalDataGridViewTextBoxColumn.ReadOnly = true;
            this.hopitalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.hopitalDataGridViewTextBoxColumn.Width = 91;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "service";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.serviceDataGridViewTextBoxColumn.Width = 90;
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
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.codeDataGridViewTextBoxColumn.Width = 76;
            // 
            // lieudepatienttableBindingSource1
            // 
            this.lieudepatienttableBindingSource1.DataMember = "Lieu_de_patient_table";
            this.lieudepatienttableBindingSource1.DataSource = this.sAMUDataSet17;
            // 
            // sAMUDataSet17
            // 
            this.sAMUDataSet17.DataSetName = "SAMUDataSet17";
            this.sAMUDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lieu_de_patient_tableTableAdapter1
            // 
            this.lieu_de_patient_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // Lieudepatientchercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(617, 465);
            this.Controls.Add(this.advancedDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lieudepatientchercher";
            this.Text = "Lieudepatientchercher";
            this.Load += new System.EventHandler(this.Lieudepatientchercher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lieudepatienttableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieudepatienttableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet17)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SAMUDataSet12 sAMUDataSet12;
        private System.Windows.Forms.BindingSource lieudepatienttableBindingSource;
        private SAMUDataSet12TableAdapters.Lieu_de_patient_tableTableAdapter lieu_de_patient_tableTableAdapter;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private SAMUDataSet17 sAMUDataSet17;
        private System.Windows.Forms.BindingSource lieudepatienttableBindingSource1;
        private SAMUDataSet17TableAdapters.Lieu_de_patient_tableTableAdapter lieu_de_patient_tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieudepatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autrelieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hopitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
    }
}