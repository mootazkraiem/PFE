
namespace PFE
{
    partial class Decisionderegulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decisionderegulation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.decisionderegulationcombobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vehiculeengagecomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.medecinscomboBox = new System.Windows.Forms.ComboBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Decision de la régulation";
            // 
            // decisionderegulationcombobox
            // 
            this.decisionderegulationcombobox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decisionderegulationcombobox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.decisionderegulationcombobox.FormattingEnabled = true;
            this.decisionderegulationcombobox.Items.AddRange(new object[] {
            "Primaire",
            "Sec Transf.",
            "Sec Ex. Comp\t",
            "Sec Acte Spec.",
            "Transp.Sanit",
            "Conceil",
            "Renseig",
            "Envoi MLP",
            "D.Injust",
            "Indisp.Moy.",
            "Hre=Ire H+ CSSB",
            "Annulé Av.Dép",
            "Vers Urg.par Moy.Simple",
            "Demande incompléte"});
            this.decisionderegulationcombobox.Location = new System.Drawing.Point(300, 164);
            this.decisionderegulationcombobox.Name = "decisionderegulationcombobox";
            this.decisionderegulationcombobox.Size = new System.Drawing.Size(309, 31);
            this.decisionderegulationcombobox.TabIndex = 19;
            this.decisionderegulationcombobox.SelectedIndexChanged += new System.EventHandler(this.decisionderegulationcombobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(28, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Décision de la régulation";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(28, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Véhicule Engagé";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // vehiculeengagecomboBox
            // 
            this.vehiculeengagecomboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiculeengagecomboBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.vehiculeengagecomboBox.FormattingEnabled = true;
            this.vehiculeengagecomboBox.Items.AddRange(new object[] {
            "Aucun",
            "AR",
            "VL",
            "Astreinte",
            "Catégorie B",
            "ADEFSUR",
            "P.Civile",
            "Autre",
            "SMUR"});
            this.vehiculeengagecomboBox.Location = new System.Drawing.Point(300, 263);
            this.vehiculeengagecomboBox.Name = "vehiculeengagecomboBox";
            this.vehiculeengagecomboBox.Size = new System.Drawing.Size(309, 31);
            this.vehiculeengagecomboBox.TabIndex = 19;
            this.vehiculeengagecomboBox.SelectedIndexChanged += new System.EventHandler(this.vehiculeengagecomboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(30, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Médecins";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // medecinscomboBox
            // 
            this.medecinscomboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinscomboBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.medecinscomboBox.FormattingEnabled = true;
            this.medecinscomboBox.Items.AddRange(new object[] {
            "Aucun",
            "M.D.Interv.",
            "Int/Double",
            "Autre",
            "M.Régule"});
            this.medecinscomboBox.Location = new System.Drawing.Point(302, 357);
            this.medecinscomboBox.Name = "medecinscomboBox";
            this.medecinscomboBox.Size = new System.Drawing.Size(309, 31);
            this.medecinscomboBox.TabIndex = 19;
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.Color.White;
            this.registerbtn.Location = new System.Drawing.Point(490, 517);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(119, 29);
            this.registerbtn.TabIndex = 20;
            this.registerbtn.Text = " Suivant";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Location = new System.Drawing.Point(34, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 29);
            this.button2.TabIndex = 21;
            this.button2.Text = "Precedent";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Decisionderegulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 577);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.medecinscomboBox);
            this.Controls.Add(this.vehiculeengagecomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decisionderegulationcombobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Decisionderegulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decisionderegulation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox decisionderegulationcombobox;
        public System.Windows.Forms.ComboBox vehiculeengagecomboBox;
        public System.Windows.Forms.ComboBox medecinscomboBox;
    }
}