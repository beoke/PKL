﻿namespace Latih10_KoneksiDatabase
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            btn_new = new Button();
            tabPage2 = new TabPage();
            btn_save = new Button();
            btn_delete = new Button();
            panel2 = new Panel();
            txt_kota = new TextBox();
            label5 = new Label();
            cb_gender = new ComboBox();
            txt_alamat = new TextBox();
            label4 = new Label();
            dtp_tgl = new DateTimePicker();
            txt_tempatlahir = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txt_NIS = new TextBox();
            label3 = new Label();
            txt_name = new TextBox();
            label = new Label();
            txt_siswaID = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(661, 475);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btn_new);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(653, 442);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(648, 341);
            dataGridView1.TabIndex = 2;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // btn_new
            // 
            btn_new.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_new.Location = new Point(530, 365);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(94, 29);
            btn_new.TabIndex = 1;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PaleTurquoise;
            tabPage2.Controls.Add(btn_save);
            tabPage2.Controls.Add(btn_delete);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(653, 442);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Input Data";
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_save.Location = new Point(551, 383);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 10;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_delete
            // 
            btn_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete.Location = new Point(451, 383);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(txt_kota);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cb_gender);
            panel2.Controls.Add(txt_alamat);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtp_tgl);
            panel2.Controls.Add(txt_tempatlahir);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(331, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 369);
            panel2.TabIndex = 1;
            // 
            // txt_kota
            // 
            txt_kota.Anchor = AnchorStyles.None;
            txt_kota.Location = new Point(15, 295);
            txt_kota.Name = "txt_kota";
            txt_kota.Size = new Size(281, 27);
            txt_kota.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(21, 182);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 6;
            label5.Text = " Alamat - Kota";
            // 
            // cb_gender
            // 
            cb_gender.Anchor = AnchorStyles.None;
            cb_gender.FormattingEnabled = true;
            cb_gender.Location = new Point(18, 141);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(276, 28);
            cb_gender.TabIndex = 6;
            // 
            // txt_alamat
            // 
            txt_alamat.Anchor = AnchorStyles.None;
            txt_alamat.Location = new Point(15, 213);
            txt_alamat.Multiline = true;
            txt_alamat.Name = "txt_alamat";
            txt_alamat.Size = new Size(281, 76);
            txt_alamat.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(15, 116);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // dtp_tgl
            // 
            dtp_tgl.Anchor = AnchorStyles.None;
            dtp_tgl.Location = new Point(15, 68);
            dtp_tgl.Name = "dtp_tgl";
            dtp_tgl.Size = new Size(279, 27);
            dtp_tgl.TabIndex = 5;
            // 
            // txt_tempatlahir
            // 
            txt_tempatlahir.Anchor = AnchorStyles.None;
            txt_tempatlahir.Location = new Point(15, 31);
            txt_tempatlahir.Name = "txt_tempatlahir";
            txt_tempatlahir.Size = new Size(281, 27);
            txt_tempatlahir.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(8, 8);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 0;
            label2.Text = "Tempat/Tgl Lahir";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(txt_NIS);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label);
            panel1.Controls.Add(txt_siswaID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 371);
            panel1.TabIndex = 0;
            // 
            // txt_NIS
            // 
            txt_NIS.Anchor = AnchorStyles.None;
            txt_NIS.Location = new Point(8, 156);
            txt_NIS.Name = "txt_NIS";
            txt_NIS.Size = new Size(280, 27);
            txt_NIS.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(8, 133);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 4;
            label3.Text = "Nomor Induk Siswa";
            // 
            // txt_name
            // 
            txt_name.Anchor = AnchorStyles.None;
            txt_name.Location = new Point(8, 93);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(280, 27);
            txt_name.TabIndex = 2;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.None;
            label.AutoSize = true;
            label.Location = new Point(8, 70);
            label.Name = "label";
            label.Size = new Size(90, 20);
            label.TabIndex = 2;
            label.Text = "Siswa Name";
            // 
            // txt_siswaID
            // 
            txt_siswaID.Anchor = AnchorStyles.None;
            txt_siswaID.Location = new Point(8, 31);
            txt_siswaID.Name = "txt_siswaID";
            txt_siswaID.Size = new Size(280, 27);
            txt_siswaID.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Siswa ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 475);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btn_new;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox txt_NIS;
        private Label label3;
        private TextBox txt_name;
        private Label label;
        private TextBox txt_siswaID;
        private Label label1;
        private Panel panel2;
        private DateTimePicker dtp_tgl;
        private TextBox txt_tempatlahir;
        private Label label2;
        private Button btn_save;
        private Button btn_delete;
        private TextBox txt_kota;
        private Label label5;
        private ComboBox cb_gender;
        private TextBox txt_alamat;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
