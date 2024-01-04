
namespace SmartThermoregulator
{
    partial class Interface
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
            this.endBTN = new System.Windows.Forms.Button();
            this.dodajBTN = new System.Windows.Forms.Button();
            this.tbTempDnevna = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTempNocni = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.saveBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dnevni Rezim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nocni Rezim";
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
            this.cbOdDnevni.Location = new System.Drawing.Point(42, 55);
            this.cbOdDnevni.Margin = new System.Windows.Forms.Padding(2);
            this.cbOdDnevni.Name = "cbOdDnevni";
            this.cbOdDnevni.Size = new System.Drawing.Size(92, 21);
            this.cbOdDnevni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
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
            this.cbDoDnevni.Location = new System.Drawing.Point(42, 92);
            this.cbDoDnevni.Margin = new System.Windows.Forms.Padding(2);
            this.cbDoDnevni.Name = "cbDoDnevni";
            this.cbDoDnevni.Size = new System.Drawing.Size(92, 21);
            this.cbDoDnevni.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
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
            this.cbDoNocni.Location = new System.Drawing.Point(244, 92);
            this.cbDoNocni.Margin = new System.Windows.Forms.Padding(2);
            this.cbDoNocni.Name = "cbDoNocni";
            this.cbDoNocni.Size = new System.Drawing.Size(92, 21);
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
            this.cbOdNocni.Location = new System.Drawing.Point(244, 52);
            this.cbOdNocni.Margin = new System.Windows.Forms.Padding(2);
            this.cbOdNocni.Name = "cbOdNocni";
            this.cbOdNocni.Size = new System.Drawing.Size(92, 21);
            this.cbOdNocni.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Od";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Do";
            // 
            // endBTN
            // 
            this.endBTN.Location = new System.Drawing.Point(385, 406);
            this.endBTN.Margin = new System.Windows.Forms.Padding(2);
            this.endBTN.Name = "endBTN";
            this.endBTN.Size = new System.Drawing.Size(170, 33);
            this.endBTN.TabIndex = 11;
            this.endBTN.Text = "Kraj rada";
            this.endBTN.UseVisualStyleBackColor = true;
            this.endBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodajBTN
            // 
            this.dodajBTN.Location = new System.Drawing.Point(385, 211);
            this.dodajBTN.Margin = new System.Windows.Forms.Padding(2);
            this.dodajBTN.Name = "dodajBTN";
            this.dodajBTN.Size = new System.Drawing.Size(170, 33);
            this.dodajBTN.TabIndex = 12;
            this.dodajBTN.Text = "Dodaj uredjaj";
            this.dodajBTN.UseVisualStyleBackColor = true;
            // 
            // tbTempDnevna
            // 
            this.tbTempDnevna.Location = new System.Drawing.Point(21, 150);
            this.tbTempDnevna.Margin = new System.Windows.Forms.Padding(2);
            this.tbTempDnevna.Name = "tbTempDnevna";
            this.tbTempDnevna.Size = new System.Drawing.Size(144, 20);
            this.tbTempDnevna.TabIndex = 13;
            this.tbTempDnevna.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Temperatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Temperatura";
            // 
            // tbTempNocni
            // 
            this.tbTempNocni.Location = new System.Drawing.Point(221, 150);
            this.tbTempNocni.Margin = new System.Windows.Forms.Padding(2);
            this.tbTempNocni.Name = "tbTempNocni";
            this.tbTempNocni.Size = new System.Drawing.Size(144, 20);
            this.tbTempNocni.TabIndex = 16;
            this.tbTempNocni.Text = "";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 211);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 229);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(385, 277);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(2);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(170, 33);
            this.saveBTN.TabIndex = 18;
            this.saveBTN.Text = "Sacuvaj podesavanje";
            this.saveBTN.UseVisualStyleBackColor = true;
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(385, 340);
            this.startBTN.Margin = new System.Windows.Forms.Padding(2);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(170, 33);
            this.startBTN.TabIndex = 19;
            this.startBTN.Text = "Zapocni sa radom";
            this.startBTN.UseVisualStyleBackColor = true;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 449);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbTempNocni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTempDnevna);
            this.Controls.Add(this.dodajBTN);
            this.Controls.Add(this.endBTN);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Interface";
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
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
        private System.Windows.Forms.Button endBTN;
        private System.Windows.Forms.Button dodajBTN;
        private System.Windows.Forms.RichTextBox tbTempDnevna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tbTempNocni;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button startBTN;
    }
}

