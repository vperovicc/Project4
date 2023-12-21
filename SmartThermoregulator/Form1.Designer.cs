
namespace SmartThermoregulator
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOdDnevni = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDoDnevni = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDoNocni = new System.Windows.Forms.ComboBox();
            this.cbOdNocni = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbTempDnevna = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTempNocni = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dnevni Rezim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nocni Rezim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbOdDnevni
            // 
            this.cbOdDnevni.FormattingEnabled = true;
            this.cbOdDnevni.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbOdDnevni.Location = new System.Drawing.Point(56, 68);
            this.cbOdDnevni.Name = "cbOdDnevni";
            this.cbOdDnevni.Size = new System.Drawing.Size(121, 24);
            this.cbOdDnevni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Od";
            // 
            // cbDoDnevni
            // 
            this.cbDoDnevni.FormattingEnabled = true;
            this.cbDoDnevni.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbDoDnevni.Location = new System.Drawing.Point(56, 113);
            this.cbDoDnevni.Name = "cbDoDnevni";
            this.cbDoDnevni.Size = new System.Drawing.Size(121, 24);
            this.cbDoDnevni.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Do";
            // 
            // cbDoNocni
            // 
            this.cbDoNocni.FormattingEnabled = true;
            this.cbDoNocni.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbDoNocni.Location = new System.Drawing.Point(325, 113);
            this.cbDoNocni.Name = "cbDoNocni";
            this.cbDoNocni.Size = new System.Drawing.Size(121, 24);
            this.cbDoNocni.TabIndex = 7;
            // 
            // cbOdNocni
            // 
            this.cbOdNocni.FormattingEnabled = true;
            this.cbOdNocni.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbOdNocni.Location = new System.Drawing.Point(325, 64);
            this.cbOdNocni.Name = "cbOdNocni";
            this.cbOdNocni.Size = new System.Drawing.Size(121, 24);
            this.cbOdNocni.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Od";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Do";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kraj rada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Dodaj uredjaj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbTempDnevna
            // 
            this.tbTempDnevna.Location = new System.Drawing.Point(28, 185);
            this.tbTempDnevna.Name = "tbTempDnevna";
            this.tbTempDnevna.Size = new System.Drawing.Size(191, 24);
            this.tbTempDnevna.TabIndex = 13;
            this.tbTempDnevna.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Temperatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Temperatura";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbTempNocni
            // 
            this.tbTempNocni.Location = new System.Drawing.Point(295, 185);
            this.tbTempNocni.Name = "tbTempNocni";
            this.tbTempNocni.Size = new System.Drawing.Size(191, 24);
            this.tbTempNocni.TabIndex = 16;
            this.tbTempNocni.Text = "";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 260);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 281);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 41);
            this.button3.TabIndex = 18;
            this.button3.Text = "Sacuvaj podesavanje";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(513, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 41);
            this.button4.TabIndex = 19;
            this.button4.Text = "Zapocni sa radom";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 553);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbTempNocni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTempDnevna);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbOdNocni);
            this.Controls.Add(this.cbDoNocni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDoDnevni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOdDnevni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOdDnevni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDoDnevni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDoNocni;
        private System.Windows.Forms.ComboBox cbOdNocni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox tbTempDnevna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tbTempNocni;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

