
namespace PFE
{
    partial class appelantrecherche
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
            this.appelanttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet13 = new PFE.SAMUDataSet13();
            this.appelant_tableTableAdapter = new PFE.SAMUDataSet13TableAdapters.Appelant_tableTableAdapter();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.iDappelantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomappelantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneappelantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cINappelantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleappelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appelanttableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet14 = new PFE.SAMUDataSet14();
            this.appelant_tableTableAdapter1 = new PFE.SAMUDataSet14TableAdapters.Appelant_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appelanttableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appelanttableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // appelanttableBindingSource
            // 
            this.appelanttableBindingSource.DataMember = "Appelant_table";
            this.appelanttableBindingSource.DataSource = this.sAMUDataSet13;
            // 
            // sAMUDataSet13
            // 
            this.sAMUDataSet13.DataSetName = "SAMUDataSet13";
            this.sAMUDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appelant_tableTableAdapter
            // 
            this.appelant_tableTableAdapter.ClearBeforeFill = true;
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
            this.iDappelantDataGridViewTextBoxColumn,
            this.nomappelantDataGridViewTextBoxColumn,
            this.telephoneappelantDataGridViewTextBoxColumn,
            this.cINappelantDataGridViewTextBoxColumn,
            this.cleappelDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.appelanttableBindingSource1;
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
            this.advancedDataGridView1.Size = new System.Drawing.Size(503, 450);
            this.advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick_1);
            // 
            // iDappelantDataGridViewTextBoxColumn
            // 
            this.iDappelantDataGridViewTextBoxColumn.DataPropertyName = "ID_appelant";
            this.iDappelantDataGridViewTextBoxColumn.HeaderText = "ID_appelant";
            this.iDappelantDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDappelantDataGridViewTextBoxColumn.Name = "iDappelantDataGridViewTextBoxColumn";
            this.iDappelantDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDappelantDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.iDappelantDataGridViewTextBoxColumn.Width = 131;
            // 
            // nomappelantDataGridViewTextBoxColumn
            // 
            this.nomappelantDataGridViewTextBoxColumn.DataPropertyName = "Nom_appelant";
            this.nomappelantDataGridViewTextBoxColumn.HeaderText = "Nom_appelant";
            this.nomappelantDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nomappelantDataGridViewTextBoxColumn.Name = "nomappelantDataGridViewTextBoxColumn";
            this.nomappelantDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomappelantDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nomappelantDataGridViewTextBoxColumn.Width = 154;
            // 
            // telephoneappelantDataGridViewTextBoxColumn
            // 
            this.telephoneappelantDataGridViewTextBoxColumn.DataPropertyName = "Telephone_appelant";
            this.telephoneappelantDataGridViewTextBoxColumn.HeaderText = "Telephone_appelant";
            this.telephoneappelantDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.telephoneappelantDataGridViewTextBoxColumn.Name = "telephoneappelantDataGridViewTextBoxColumn";
            this.telephoneappelantDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephoneappelantDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.telephoneappelantDataGridViewTextBoxColumn.Width = 198;
            // 
            // cINappelantDataGridViewTextBoxColumn
            // 
            this.cINappelantDataGridViewTextBoxColumn.DataPropertyName = "CIN_appelant";
            this.cINappelantDataGridViewTextBoxColumn.HeaderText = "CIN_appelant";
            this.cINappelantDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cINappelantDataGridViewTextBoxColumn.Name = "cINappelantDataGridViewTextBoxColumn";
            this.cINappelantDataGridViewTextBoxColumn.ReadOnly = true;
            this.cINappelantDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cINappelantDataGridViewTextBoxColumn.Width = 145;
            // 
            // cleappelDataGridViewTextBoxColumn
            // 
            this.cleappelDataGridViewTextBoxColumn.DataPropertyName = "cleappel";
            this.cleappelDataGridViewTextBoxColumn.HeaderText = "cleappel";
            this.cleappelDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cleappelDataGridViewTextBoxColumn.Name = "cleappelDataGridViewTextBoxColumn";
            this.cleappelDataGridViewTextBoxColumn.ReadOnly = true;
            this.cleappelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cleappelDataGridViewTextBoxColumn.Width = 106;
            // 
            // appelanttableBindingSource1
            // 
            this.appelanttableBindingSource1.DataMember = "Appelant_table";
            this.appelanttableBindingSource1.DataSource = this.sAMUDataSet14;
            // 
            // sAMUDataSet14
            // 
            this.sAMUDataSet14.DataSetName = "SAMUDataSet14";
            this.sAMUDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appelant_tableTableAdapter1
            // 
            this.appelant_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // appelantrecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.advancedDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appelantrecherche";
            this.Text = "appelantrecherche";
            this.Load += new System.EventHandler(this.appelantrecherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appelanttableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appelanttableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SAMUDataSet13 sAMUDataSet13;
        private System.Windows.Forms.BindingSource appelanttableBindingSource;
        private SAMUDataSet13TableAdapters.Appelant_tableTableAdapter appelant_tableTableAdapter;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private SAMUDataSet14 sAMUDataSet14;
        private System.Windows.Forms.BindingSource appelanttableBindingSource1;
        private SAMUDataSet14TableAdapters.Appelant_tableTableAdapter appelant_tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDappelantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomappelantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneappelantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINappelantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleappelDataGridViewTextBoxColumn;
    }
}