namespace WinFormsApp2
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
            txtid = new TextBox();
            panel1 = new Panel();
            dgvCat = new DataGridView();
            panel2 = new Panel();
            btdete = new Button();
            btedit = new Button();
            btsave = new Button();
            label3 = new Label();
            label2 = new Label();
            txtname = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCat).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Location = new Point(121, 33);
            txtid.Name = "txtid";
            txtid.Size = new Size(119, 27);
            txtid.TabIndex = 0;
            txtid.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(dgvCat);
            panel1.Location = new Point(335, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 317);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // dgvCat
            // 
            dgvCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCat.Location = new Point(25, 29);
            dgvCat.Name = "dgvCat";
            dgvCat.RowHeadersWidth = 51;
            dgvCat.RowTemplate.Height = 29;
            dgvCat.Size = new Size(403, 265);
            dgvCat.TabIndex = 3;
            dgvCat.CellClick += dgvCat_CellClick;
            dgvCat.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(btdete);
            panel2.Controls.Add(btedit);
            panel2.Controls.Add(btsave);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtname);
            panel2.Controls.Add(txtid);
            panel2.Location = new Point(17, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 319);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btdete
            // 
            btdete.BackColor = Color.Red;
            btdete.Location = new Point(191, 201);
            btdete.Name = "btdete";
            btdete.Size = new Size(80, 56);
            btdete.TabIndex = 3;
            btdete.Text = "ລືບ";
            btdete.UseVisualStyleBackColor = false;
            btdete.Click += btdete_Click;
            // 
            // btedit
            // 
            btedit.BackColor = Color.FromArgb(255, 128, 0);
            btedit.Location = new Point(105, 201);
            btedit.Name = "btedit";
            btedit.Size = new Size(80, 56);
            btedit.TabIndex = 3;
            btedit.Text = "ແກ້ໄຂ";
            btedit.UseVisualStyleBackColor = false;
            btedit.Click += btedit_Click;
            // 
            // btsave
            // 
            btsave.BackColor = Color.Lime;
            btsave.Location = new Point(19, 201);
            btsave.Name = "btsave";
            btsave.Size = new Size(80, 56);
            btsave.TabIndex = 3;
            btsave.Text = "ບັນທຶກ";
            btsave.UseVisualStyleBackColor = false;
            btsave.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "ຊື່ປະເພດສິນຄ້າ";
            label3.Click += ຊື່ພະເພດສິນຄ້າ_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 36);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "ລະຫັດປະເພດ";
            // 
            // txtname
            // 
            txtname.Location = new Point(119, 73);
            txtname.Name = "txtname";
            txtname.Size = new Size(181, 27);
            txtname.TabIndex = 0;
            txtname.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCat).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtid;
        private Panel panel1;
        private DataGridView dgvCat;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Button btdete;
        private Button btedit;
        private Button btsave;
        private TextBox txtname;
    }
}