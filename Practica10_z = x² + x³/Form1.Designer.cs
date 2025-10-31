namespace Practica10_z___x____x_
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 48);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "z = x² + x³";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 95);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 1;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 95);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 2;
            label3.Text = "x² ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 95);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 3;
            label4.Text = "x³";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(597, 95);
            label5.Name = "label5";
            label5.Size = new Size(16, 20);
            label5.TabIndex = 4;
            label5.Text = "z";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(112, 162);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(80, 164);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(276, 162);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(74, 164);
            listBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(413, 162);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(80, 164);
            listBox3.TabIndex = 8;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(572, 162);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(74, 164);
            listBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(266, 347);
            button1.Name = "button1";
            button1.Size = new Size(215, 29);
            button1.TabIndex = 10;
            button1.Text = "Calcular Valores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Button button1;
    }
}
