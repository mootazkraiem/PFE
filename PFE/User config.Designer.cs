
namespace PFE
{
    partial class User_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_config));
            this.button2 = new System.Windows.Forms.Button();
            this.byidtxtbox = new System.Windows.Forms.TextBox();
            this.sAMUDataSet20 = new PFE.SAMUDataSet20();
            this.registertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registertblTableAdapter = new PFE.SAMUDataSet20TableAdapters.registertblTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.identifianttxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prenomtxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.telephonetxtbox = new System.Windows.Forms.TextBox();
            this.roletxtbox = new System.Windows.Forms.ComboBox();
            this.modifierbtn = new System.Windows.Forms.Button();
            this.Supprimerbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.motdpassetxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nomtxtbox = new System.Windows.Forms.TextBox();
            this.datagridview1 = new Zuby.ADGV.AdvancedDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.paridentiftxtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Location = new System.Drawing.Point(728, -30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 29);
            this.button2.TabIndex = 66;
            this.button2.Text = "Charger";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // byidtxtbox
            // 
            this.byidtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.byidtxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byidtxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.byidtxtbox.Location = new System.Drawing.Point(412, -28);
            this.byidtxtbox.Name = "byidtxtbox";
            this.byidtxtbox.Size = new System.Drawing.Size(310, 27);
            this.byidtxtbox.TabIndex = 65;
            this.byidtxtbox.Text = "Par identifiant";
            // 
            // sAMUDataSet20
            // 
            this.sAMUDataSet20.DataSetName = "SAMUDataSet20";
            this.sAMUDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registertblBindingSource
            // 
            this.registertblBindingSource.DataMember = "registertbl";
            this.registertblBindingSource.DataSource = this.sAMUDataSet20;
            // 
            // registertblTableAdapter
            // 
            this.registertblTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "Nom";
            // 
            // identifianttxtbox
            // 
            this.identifianttxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.identifianttxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifianttxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.identifianttxtbox.Location = new System.Drawing.Point(648, 96);
            this.identifianttxtbox.Name = "identifianttxtbox";
            this.identifianttxtbox.ReadOnly = true;
            this.identifianttxtbox.Size = new System.Drawing.Size(269, 23);
            this.identifianttxtbox.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "Prenom";
            // 
            // prenomtxtbox
            // 
            this.prenomtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prenomtxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomtxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.prenomtxtbox.Location = new System.Drawing.Point(181, 160);
            this.prenomtxtbox.Name = "prenomtxtbox";
            this.prenomtxtbox.Size = new System.Drawing.Size(269, 27);
            this.prenomtxtbox.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(479, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "Identifiant";
            // 
            // telephonetxtbox
            // 
            this.telephonetxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telephonetxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephonetxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.telephonetxtbox.Location = new System.Drawing.Point(181, 224);
            this.telephonetxtbox.Name = "telephonetxtbox";
            this.telephonetxtbox.Size = new System.Drawing.Size(269, 27);
            this.telephonetxtbox.TabIndex = 71;
            // 
            // roletxtbox
            // 
            this.roletxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roletxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.roletxtbox.FormattingEnabled = true;
            this.roletxtbox.Items.AddRange(new object[] {
            "medecin generaliste",
            "secretaire",
            "infirmiers",
            "ambulancier",
            "ouvrier",
            "personnel gardiennage",
            "aide soignante",
            "permanencier",
            "technecien superieur",
            "administrateur"});
            this.roletxtbox.Location = new System.Drawing.Point(646, 226);
            this.roletxtbox.Name = "roletxtbox";
            this.roletxtbox.Size = new System.Drawing.Size(269, 29);
            this.roletxtbox.TabIndex = 74;
            // 
            // modifierbtn
            // 
            this.modifierbtn.BackColor = System.Drawing.Color.White;
            this.modifierbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierbtn.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.modifierbtn.Location = new System.Drawing.Point(646, 582);
            this.modifierbtn.Name = "modifierbtn";
            this.modifierbtn.Size = new System.Drawing.Size(130, 31);
            this.modifierbtn.TabIndex = 75;
            this.modifierbtn.Text = "Modifier";
            this.modifierbtn.UseVisualStyleBackColor = false;
            this.modifierbtn.Click += new System.EventHandler(this.modifierbtn_Click);
            // 
            // Supprimerbtn
            // 
            this.Supprimerbtn.BackColor = System.Drawing.Color.White;
            this.Supprimerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supprimerbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimerbtn.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Supprimerbtn.Location = new System.Drawing.Point(787, 582);
            this.Supprimerbtn.Name = "Supprimerbtn";
            this.Supprimerbtn.Size = new System.Drawing.Size(125, 31);
            this.Supprimerbtn.TabIndex = 76;
            this.Supprimerbtn.Text = "Supprimer";
            this.Supprimerbtn.UseVisualStyleBackColor = false;
            this.Supprimerbtn.Click += new System.EventHandler(this.Supprimerbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(479, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 78;
            this.label7.Text = "Mot de passe";
            // 
            // motdpassetxtbox
            // 
            this.motdpassetxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motdpassetxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motdpassetxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.motdpassetxtbox.Location = new System.Drawing.Point(648, 163);
            this.motdpassetxtbox.Name = "motdpassetxtbox";
            this.motdpassetxtbox.Size = new System.Drawing.Size(269, 27);
            this.motdpassetxtbox.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(479, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 77;
            this.label6.Text = "Role";
            // 
            // nomtxtbox
            // 
            this.nomtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomtxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomtxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.nomtxtbox.Location = new System.Drawing.Point(179, 94);
            this.nomtxtbox.Name = "nomtxtbox";
            this.nomtxtbox.Size = new System.Drawing.Size(269, 27);
            this.nomtxtbox.TabIndex = 79;
            // 
            // datagridview1
            // 
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridview1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview1.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview1.FilterAndSortEnabled = true;
            this.datagridview1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.datagridview1.GridColor = System.Drawing.Color.LightSkyBlue;
            this.datagridview1.Location = new System.Drawing.Point(46, 293);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.ReadOnly = true;
            this.datagridview1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datagridview1.RowHeadersVisible = false;
            this.datagridview1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridview1.Size = new System.Drawing.Size(816, 283);
            this.datagridview1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.datagridview1.TabIndex = 81;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(782, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 83;
            this.button1.Text = "Charger";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paridentiftxtbox
            // 
            this.paridentiftxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paridentiftxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paridentiftxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.paridentiftxtbox.Location = new System.Drawing.Point(179, 24);
            this.paridentiftxtbox.Name = "paridentiftxtbox";
            this.paridentiftxtbox.Size = new System.Drawing.Size(573, 27);
            this.paridentiftxtbox.TabIndex = 84;
            this.paridentiftxtbox.Text = "Par identifiant";
            // 
            // User_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(921, 625);
            this.Controls.Add(this.paridentiftxtbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datagridview1);
            this.Controls.Add(this.nomtxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.motdpassetxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Supprimerbtn);
            this.Controls.Add(this.modifierbtn);
            this.Controls.Add(this.roletxtbox);
            this.Controls.Add(this.telephonetxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prenomtxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.identifianttxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.byidtxtbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_config";
            this.Text = "User_config";
            this.Load += new System.EventHandler(this.User_config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAMUDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox byidtxtbox;
        private SAMUDataSet20 sAMUDataSet20;
        private System.Windows.Forms.BindingSource registertblBindingSource;
        private SAMUDataSet20TableAdapters.registertblTableAdapter registertblTableAdapter;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox identifianttxtbox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox prenomtxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox telephonetxtbox;
        public System.Windows.Forms.ComboBox roletxtbox;
        private System.Windows.Forms.Button modifierbtn;
        private System.Windows.Forms.Button Supprimerbtn;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox motdpassetxtbox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox nomtxtbox;
        private Zuby.ADGV.AdvancedDataGridView datagridview1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox paridentiftxtbox;
    }
}