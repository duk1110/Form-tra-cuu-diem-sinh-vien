namespace WinFormsApp7
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 477);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(214, 477);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Sửa ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(415, 477);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 270);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 4;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 324);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 5;
            label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 375);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 6;
            label3.Text = "Lớp";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(398, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 318);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(398, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 369);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(398, 31);
            textBox3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(515, 225);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(751, 84);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 11;
            button4.Text = "Tra cứu ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(618, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(397, 31);
            textBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 428);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 13;
            label4.Text = "Điểm";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 422);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(398, 31);
            textBox5.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 619);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Button button4;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
    }
}
