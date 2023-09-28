namespace Tugas3_2
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
            panel1 = new Panel();
            panel5 = new Panel();
            buttonOK = new Button();
            panel4 = new Panel();
            textPesan3 = new TextBox();
            panel3 = new Panel();
            textPesan2 = new TextBox();
            panel2 = new Panel();
            textPesan1 = new TextBox();
            splitContainer1 = new SplitContainer();
            panel11 = new Panel();
            label3 = new Label();
            panel10 = new Panel();
            label2 = new Label();
            panel9 = new Panel();
            label1 = new Label();
            panel8 = new Panel();
            lstPekerjaan = new ListBox();
            panel7 = new Panel();
            comboPendidikan = new ComboBox();
            panel6 = new Panel();
            textNama = new TextBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 555);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonOK);
            panel5.Location = new Point(12, 494);
            panel5.Name = "panel5";
            panel5.Size = new Size(438, 47);
            panel5.TabIndex = 2;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(3, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(432, 41);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(textPesan3);
            panel4.Location = new Point(12, 441);
            panel4.Name = "panel4";
            panel4.Size = new Size(438, 47);
            panel4.TabIndex = 2;
            // 
            // textPesan3
            // 
            textPesan3.Enabled = false;
            textPesan3.Location = new Point(3, 3);
            textPesan3.Multiline = true;
            textPesan3.Name = "textPesan3";
            textPesan3.Size = new Size(432, 41);
            textPesan3.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(textPesan2);
            panel3.Location = new Point(12, 388);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 47);
            panel3.TabIndex = 2;
            // 
            // textPesan2
            // 
            textPesan2.Enabled = false;
            textPesan2.Location = new Point(3, 3);
            textPesan2.Multiline = true;
            textPesan2.Name = "textPesan2";
            textPesan2.Size = new Size(432, 41);
            textPesan2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(textPesan1);
            panel2.Location = new Point(12, 335);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 47);
            panel2.TabIndex = 1;
            // 
            // textPesan1
            // 
            textPesan1.Enabled = false;
            textPesan1.Location = new Point(3, 3);
            textPesan1.Multiline = true;
            textPesan1.Name = "textPesan1";
            textPesan1.Size = new Size(432, 41);
            textPesan1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel11);
            splitContainer1.Panel1.Controls.Add(panel10);
            splitContainer1.Panel1.Controls.Add(panel9);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel8);
            splitContainer1.Panel2.Controls.Add(panel7);
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Size = new Size(453, 326);
            splitContainer1.SplitterDistance = 164;
            splitContainer1.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(label3);
            panel11.Location = new Point(9, 118);
            panel11.Name = "panel11";
            panel11.Size = new Size(152, 47);
            panel11.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 16);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Pekerjaan";
            // 
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Location = new Point(9, 65);
            panel10.Name = "panel10";
            panel10.Size = new Size(152, 47);
            panel10.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 14);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Pendidikan";
            // 
            // panel9
            // 
            panel9.Controls.Add(label1);
            panel9.Location = new Point(9, 12);
            panel9.Name = "panel9";
            panel9.Size = new Size(152, 47);
            panel9.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 16);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // panel8
            // 
            panel8.Controls.Add(lstPekerjaan);
            panel8.Location = new Point(3, 115);
            panel8.Name = "panel8";
            panel8.Size = new Size(276, 208);
            panel8.TabIndex = 3;
            // 
            // lstPekerjaan
            // 
            lstPekerjaan.FormattingEnabled = true;
            lstPekerjaan.ItemHeight = 15;
            lstPekerjaan.Items.AddRange(new object[] { "Pedagang", "PNS", "Dosen", "Swasta", "ABRI" });
            lstPekerjaan.Location = new Point(3, 6);
            lstPekerjaan.Name = "lstPekerjaan";
            lstPekerjaan.Size = new Size(270, 199);
            lstPekerjaan.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(comboPendidikan);
            panel7.Location = new Point(3, 62);
            panel7.Name = "panel7";
            panel7.Size = new Size(276, 47);
            panel7.TabIndex = 3;
            // 
            // comboPendidikan
            // 
            comboPendidikan.FormattingEnabled = true;
            comboPendidikan.Items.AddRange(new object[] { "SD", "SMP", "SMA", "Diploma", "Sarjana", "Pascasarjana" });
            comboPendidikan.Location = new Point(3, 15);
            comboPendidikan.Name = "comboPendidikan";
            comboPendidikan.Size = new Size(270, 23);
            comboPendidikan.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(textNama);
            panel6.Location = new Point(3, 9);
            panel6.Name = "panel6";
            panel6.Size = new Size(276, 47);
            panel6.TabIndex = 2;
            // 
            // textNama
            // 
            textNama.Location = new Point(3, 3);
            textNama.Multiline = true;
            textNama.Name = "textNama";
            textNama.Size = new Size(270, 41);
            textNama.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 555);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Tugas3.2";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel9;
        private Panel panel11;
        private Label label3;
        private Panel panel10;
        private Label label2;
        private Label label1;
        private TextBox textNama;
        private Button buttonOK;
        private TextBox textPesan3;
        private TextBox textPesan2;
        private TextBox textPesan1;
        private ListBox lstPekerjaan;
        private ComboBox comboPendidikan;
    }
}