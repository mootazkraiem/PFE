
namespace PFE
{
    partial class Autrelieudepatient
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
            this.hopitaltxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autrelieutxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.servicetxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hopitaltxtbox
            // 
            this.hopitaltxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hopitaltxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopitaltxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.hopitaltxtbox.Location = new System.Drawing.Point(322, 94);
            this.hopitaltxtbox.Name = "hopitaltxtbox";
            this.hopitaltxtbox.Size = new System.Drawing.Size(269, 27);
            this.hopitaltxtbox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Hopital";
            // 
            // autrelieutxtbox
            // 
            this.autrelieutxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autrelieutxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autrelieutxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.autrelieutxtbox.Location = new System.Drawing.Point(322, 30);
            this.autrelieutxtbox.Name = "autrelieutxtbox";
            this.autrelieutxtbox.Size = new System.Drawing.Size(269, 27);
            this.autrelieutxtbox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Autre ";
            // 
            // servicetxtbox
            // 
            this.servicetxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servicetxtbox.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicetxtbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.servicetxtbox.Location = new System.Drawing.Point(322, 159);
            this.servicetxtbox.Name = "servicetxtbox";
            this.servicetxtbox.Size = new System.Drawing.Size(269, 27);
            this.servicetxtbox.TabIndex = 29;
            // 
            // Autrelieudepatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 216);
            this.Controls.Add(this.hopitaltxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.autrelieutxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.servicetxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autrelieudepatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autrelieudepatient";
            this.Load += new System.EventHandler(this.Autrelieudepatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox hopitaltxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox autrelieutxtbox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox servicetxtbox;
    }
}