namespace Latih8_WinformEvent
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(840, 239);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(13, 257);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 187);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(353, 103);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(216, 28);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(181, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "ddd, dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(181, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(166, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(353, 14);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 83);
            textBox3.TabIndex = 2;
            textBox3.Validated += textBox3_Validated;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 27);
            textBox2.TabIndex = 1;
            textBox2.Validated += textBox2_Validated;
            // 
            // button1
            // 
            button1.Location = new Point(758, 257);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(864, 508);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox1;
    }
}
