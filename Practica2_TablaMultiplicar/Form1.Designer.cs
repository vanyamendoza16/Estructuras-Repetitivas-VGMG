﻿namespace Practica2_TablaMultiplicar
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 41);
            label1.Name = "label1";
            label1.Size = new Size(297, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduce el valor de la Tabla de Multiplicar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 134);
            label2.Name = "label2";
            label2.Size = new Size(315, 20);
            label2.TabIndex = 2;
            label2.Text = "Límite máximo para la tabla de multiplicación";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 27);
            textBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(125, 210);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(125, 224);
            listBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(137, 453);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 521);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tabla de Multiplicar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
    }
}
