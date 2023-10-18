namespace bilgi_yarışması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsoru = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnd = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btna = new System.Windows.Forms.Button();
            this.dgrcvp = new System.Windows.Forms.Label();
            this.lblyanlıs = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.lblsoru = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scnk = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltrue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblfalse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsoru
            // 
            this.btnsoru.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnsoru.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsoru.Location = new System.Drawing.Point(632, 158);
            this.btnsoru.Name = "btnsoru";
            this.btnsoru.Size = new System.Drawing.Size(88, 92);
            this.btnsoru.TabIndex = 0;
            this.btnsoru.Text = "BASLA >";
            this.btnsoru.UseVisualStyleBackColor = false;
            this.btnsoru.Click += new System.EventHandler(this.btnsoru_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru Numarası:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(478, 261);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnd
            // 
            this.btnd.Location = new System.Drawing.Point(249, 316);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(241, 31);
            this.btnd.TabIndex = 4;
            this.btnd.Text = "D";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Visible = false;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(12, 316);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(231, 31);
            this.btnc.TabIndex = 5;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Visible = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnb
            // 
            this.btnb.Location = new System.Drawing.Point(249, 279);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(241, 31);
            this.btnb.TabIndex = 6;
            this.btnb.Text = "B";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Visible = false;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btna
            // 
            this.btna.Location = new System.Drawing.Point(12, 279);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(231, 31);
            this.btna.TabIndex = 7;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = true;
            this.btna.Visible = false;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // dgrcvp
            // 
            this.dgrcvp.AutoSize = true;
            this.dgrcvp.Location = new System.Drawing.Point(158, 372);
            this.dgrcvp.Name = "dgrcvp";
            this.dgrcvp.Size = new System.Drawing.Size(56, 23);
            this.dgrcvp.TabIndex = 8;
            this.dgrcvp.Text = "label2";
            this.dgrcvp.Visible = false;
            // 
            // lblyanlıs
            // 
            this.lblyanlıs.AutoSize = true;
            this.lblyanlıs.Location = new System.Drawing.Point(689, 86);
            this.lblyanlıs.Name = "lblyanlıs";
            this.lblyanlıs.Size = new System.Drawing.Size(30, 23);
            this.lblyanlıs.TabIndex = 9;
            this.lblyanlıs.Text = "00";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Location = new System.Drawing.Point(689, 51);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(30, 23);
            this.lbldogru.TabIndex = 10;
            this.lbldogru.Text = "00";
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.Location = new System.Drawing.Point(689, 15);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(30, 23);
            this.lblsoru.TabIndex = 11;
            this.lblsoru.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yanlış Cevap Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Doğru Cevap Sayısı:";
            // 
            // scnk
            // 
            this.scnk.AutoSize = true;
            this.scnk.Location = new System.Drawing.Point(249, 372);
            this.scnk.Name = "scnk";
            this.scnk.Size = new System.Drawing.Size(56, 23);
            this.scnk.TabIndex = 14;
            this.scnk.Text = "label8";
            this.scnk.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.lbltrue);
            this.panel1.Location = new System.Drawing.Point(512, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 66);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // lbltrue
            // 
            this.lbltrue.AutoSize = true;
            this.lbltrue.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltrue.Location = new System.Drawing.Point(18, 21);
            this.lbltrue.Name = "lbltrue";
            this.lbltrue.Size = new System.Drawing.Size(67, 23);
            this.lbltrue.TabIndex = 18;
            this.lbltrue.Text = "Doğru!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.lblfalse);
            this.panel2.Location = new System.Drawing.Point(512, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 66);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // lblfalse
            // 
            this.lblfalse.AutoSize = true;
            this.lblfalse.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblfalse.Location = new System.Drawing.Point(19, 19);
            this.lblfalse.Name = "lblfalse";
            this.lblfalse.Size = new System.Drawing.Size(66, 23);
            this.lblfalse.TabIndex = 17;
            this.lblfalse.Text = "Yanlış!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(622, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "BAŞTAN BAŞLA!!";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(767, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scnk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.lblyanlıs);
            this.Controls.Add(this.dgrcvp);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsoru);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnsoru;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button btnd;
        private Button btnc;
        private Button btnb;
        private Button btna;
        private Label dgrcvp;
        private Label lblyanlıs;
        private Label lbldogru;
        private Label lblsoru;
        private Label label6;
        private Label label7;
        private Label scnk;
        private Panel panel1;
        private Panel panel2;
        private Label lbltrue;
        private Label lblfalse;
        private Label label2;
    }
}