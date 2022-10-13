
namespace PFE
{
    partial class horrairedemissionchercher
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
            this.horrairedelamissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet11 = new PFE.SAMUDataSet11();
            this.horraire_de_la_missionTableAdapter = new PFE.SAMUDataSet11TableAdapters.Horraire_de_la_missionTableAdapter();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heuredepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heurearriveaulieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heurebilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heuredepartdestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heurearrivedestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heuredepartsec0DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heuredispDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureretourbaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleappelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horrairedelamissionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAMUDataSet16 = new PFE.SAMUDataSet16();
            this.horraire_de_la_missionTableAdapter1 = new PFE.SAMUDataSet16TableAdapters.Horraire_de_la_missionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.horrairedelamissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horrairedelamissionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // horrairedelamissionBindingSource
            // 
            this.horrairedelamissionBindingSource.DataMember = "Horraire_de_la_mission";
            this.horrairedelamissionBindingSource.DataSource = this.sAMUDataSet11;
            // 
            // sAMUDataSet11
            // 
            this.sAMUDataSet11.DataSetName = "SAMUDataSet11";
            this.sAMUDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horraire_de_la_missionTableAdapter
            // 
            this.horraire_de_la_missionTableAdapter.ClearBeforeFill = true;
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
            this.codeDataGridViewTextBoxColumn,
            this.heuredepartDataGridViewTextBoxColumn,
            this.heurearriveaulieuDataGridViewTextBoxColumn,
            this.heurebilanDataGridViewTextBoxColumn,
            this.heuredepartdestinationDataGridViewTextBoxColumn,
            this.heurearrivedestinationDataGridViewTextBoxColumn,
            this.heuredepartsec0DataGridViewTextBoxColumn,
            this.heuredispDataGridViewTextBoxColumn,
            this.heureretourbaseDataGridViewTextBoxColumn,
            this.cleappelDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.horrairedelamissionBindingSource1;
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
            this.advancedDataGridView1.Size = new System.Drawing.Size(775, 520);
            this.advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView1.TabIndex = 1;
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick_1);
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
            // heuredepartDataGridViewTextBoxColumn
            // 
            this.heuredepartDataGridViewTextBoxColumn.DataPropertyName = "Heuredepart";
            this.heuredepartDataGridViewTextBoxColumn.HeaderText = "Heuredepart";
            this.heuredepartDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.heuredepartDataGridViewTextBoxColumn.Name = "heuredepartDataGridViewTextBoxColumn";
            this.heuredepartDataGridViewTextBoxColumn.ReadOnly = true;
            this.heuredepartDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.heuredepartDataGridViewTextBoxColumn.Width = 134;
            // 
            // heurearriveaulieuDataGridViewTextBoxColumn
            // 
            this.heurearriveaulieuDataGridViewTextBoxColumn.DataPropertyName = "Heurearriveaulieu";
            this.heurearriveaulieuDataGridViewTextBoxColumn.HeaderText = "Heurearriveaulieu";
            this.heurearriveaulieuDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.heurearriveaulieuDataGridViewTextBoxColumn.Name = "heurearriveaulieuDataGridViewTextBoxColumn";
            this.heurearriveaulieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.heurearriveaulieuDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.heurearriveaulieuDataGridViewTextBoxColumn.Width = 174;
            // 
            // heurebilanDataGridViewTextBoxColumn
            // 
            this.heurebilanDataGridViewTextBoxColumn.DataPropertyName = "Heurebilan";
            this.heurebilanDataGridViewTextBoxColumn.HeaderText = "Heurebilan";
            this.heurebilanDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.heurebilanDataGridViewTextBoxColumn.Name = "heurebilanDataGridViewTextBoxColumn";
            this.heurebilanDataGridViewTextBoxColumn.ReadOnly = true;
            this.heurebilanDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.heurebilanDataGridViewTextBoxColumn.Width = 121;
            // 
            // heuredepartdestinationDataGridViewTextBoxColumn
            // 
            this.heuredepartdestinationDataGridViewTextBoxColumn.DataPropertyName = "Heuredepartdestination";
            this.heuredepartdestinationDataGridViewTextBoxColumn.HeaderText = "Heuredepartdestination";
            this.heuredepartdestinationDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.heuredepartdestinationDataGridViewTextBoxColumn.Name = "heuredepartdestinationDataGridViewTextBoxColumn";
            this.heuredepartdestinationDataGridViewTextBoxColumn.ReadOnly = true;
            this.heuredepartdestinationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.heuredepartdestinationDataGridViewTextBoxColumn.Width = 221;
            // 
            // heurearrivedestinationDataGridViewTextBoxColumn
            // 
            this.heurearrivedestinationDataGridViewTextBoxColumn.DataPropertyName = "Heurearrivedestination";
            this.heurearrivedestinationDataGridViewTextBoxColumn.HeaderText = "Heurearrivedestination";
            this.heurearrivedestinationDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.heurearrivedestinationDataGridViewTextBoxColumn.Name = "heurearrivedestinationDataGridViewTextBoxColumn";
            this.heurearrivedestinationDataGridViewTextBoxColumn.ReadOnly = true;
            this.heurearrivedestinationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.heurearrivedestinationDataGridViewTextBoxColumn.Width = 212;
            // 
            // heuredepartsec0DataGridViewTextBoxColumn
            // 
            this.heuredepartsec0DataGridViewTextBoxColumn.DataPropertyName = "Heuredepartsec0";
            this.heuredepartsec0DataGridViewTextBoxColumn.HeaderText = "Heuredepartsec0";
            this.heuredepartsec0DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.heuredepartsec0DataGridViewTextBoxColumn.Name = "heuredepartsec0DataGridViewTextBoxColumn";
            this.heuredepartsec0DataGridViewTextBoxColumn.ReadOnly = true;
            this.heuredepartsec0DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.heuredepartsec0DataGridViewTextBoxColumn.Width = 170;
            // 
            // heuredispDataGridViewTextBoxColumn
            // 
            this.heuredispDataGridViewTextBoxColumn.DataPropertyName = "Heuredisp";
            this.heuredispDataGridViewTextBoxColumn.HeaderText = "Heuredisp";
            this.heuredispDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.heuredispDataGridViewTextBoxColumn.Name = "heuredispDataGridViewTextBoxColumn";
            this.heuredispDataGridViewTextBoxColumn.ReadOnly = true;
            this.heuredispDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.heuredispDataGridViewTextBoxColumn.Width = 114;
            // 
            // heureretourbaseDataGridViewTextBoxColumn
            // 
            this.heureretourbaseDataGridViewTextBoxColumn.DataPropertyName = "Heureretourbase";
            this.heureretourbaseDataGridViewTextBoxColumn.HeaderText = "Heureretourbase";
            this.heureretourbaseDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.heureretourbaseDataGridViewTextBoxColumn.Name = "heureretourbaseDataGridViewTextBoxColumn";
            this.heureretourbaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.heureretourbaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.heureretourbaseDataGridViewTextBoxColumn.Width = 165;
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
            // horrairedelamissionBindingSource1
            // 
            this.horrairedelamissionBindingSource1.DataMember = "Horraire_de_la_mission";
            this.horrairedelamissionBindingSource1.DataSource = this.sAMUDataSet16;
            // 
            // sAMUDataSet16
            // 
            this.sAMUDataSet16.DataSetName = "SAMUDataSet16";
            this.sAMUDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horraire_de_la_missionTableAdapter1
            // 
            this.horraire_de_la_missionTableAdapter1.ClearBeforeFill = true;
            // 
            // horrairedemissionchercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(775, 520);
            this.Controls.Add(this.advancedDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "horrairedemissionchercher";
            this.Text = "horrairedemissionchercher";
            this.Load += new System.EventHandler(this.horrairedemissionchercher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.horrairedelamissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horrairedelamissionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SAMUDataSet11 sAMUDataSet11;
        private System.Windows.Forms.BindingSource horrairedelamissionBindingSource;
        private SAMUDataSet11TableAdapters.Horraire_de_la_missionTableAdapter horraire_de_la_missionTableAdapter;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private SAMUDataSet16 sAMUDataSet16;
        private System.Windows.Forms.BindingSource horrairedelamissionBindingSource1;
        private SAMUDataSet16TableAdapters.Horraire_de_la_missionTableAdapter horraire_de_la_missionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuredepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heurearriveaulieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heurebilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuredepartdestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heurearrivedestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuredepartsec0DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuredispDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureretourbaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleappelDataGridViewTextBoxColumn;
    }
}