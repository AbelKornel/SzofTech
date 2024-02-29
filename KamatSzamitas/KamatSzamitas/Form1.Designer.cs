namespace KamatSzamitas
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
            label1 = new Label();
            textBoxHitelÖsszeg = new TextBox();
            label2 = new Label();
            comboBoxHaviTörlesztés = new ComboBox();
            textBoxHaviKamat = new TextBox();
            label3 = new Label();
            buttonOk = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 47);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Hitel összege:";
            // 
            // textBoxHitelÖsszeg
            // 
            textBoxHitelÖsszeg.Location = new Point(265, 65);
            textBoxHitelÖsszeg.Name = "textBoxHitelÖsszeg";
            textBoxHitelÖsszeg.Size = new Size(100, 23);
            textBoxHitelÖsszeg.TabIndex = 1;
            textBoxHitelÖsszeg.Text = "1000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 47);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Havi törlesztés:";
            // 
            // comboBoxHaviTörlesztés
            // 
            comboBoxHaviTörlesztés.FormattingEnabled = true;
            comboBoxHaviTörlesztés.Items.AddRange(new object[] { "10000", "20000", "30000", "40000", "50000" });
            comboBoxHaviTörlesztés.Location = new Point(391, 65);
            comboBoxHaviTörlesztés.Name = "comboBoxHaviTörlesztés";
            comboBoxHaviTörlesztés.Size = new Size(121, 23);
            comboBoxHaviTörlesztés.TabIndex = 3;
            // 
            // textBoxHaviKamat
            // 
            textBoxHaviKamat.Location = new Point(265, 127);
            textBoxHaviKamat.Name = "textBoxHaviKamat";
            textBoxHaviKamat.Size = new Size(100, 23);
            textBoxHaviKamat.TabIndex = 5;
            textBoxHaviKamat.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 109);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Havi kamat:";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(412, 127);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 6;
            buttonOk.Text = "&OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(123, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(549, 207);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonOk);
            Controls.Add(textBoxHaviKamat);
            Controls.Add(label3);
            Controls.Add(comboBoxHaviTörlesztés);
            Controls.Add(label2);
            Controls.Add(textBoxHitelÖsszeg);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxHitelÖsszeg;
        private Label label2;
        private ComboBox comboBoxHaviTörlesztés;
        private TextBox textBoxHaviKamat;
        private Label label3;
        private Button buttonOk;
        private DataGridView dataGridView1;
    }
}