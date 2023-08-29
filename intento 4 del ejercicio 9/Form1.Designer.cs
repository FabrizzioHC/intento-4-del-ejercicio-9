namespace intento_4_del_ejercicio_9
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
            num1 = new TextBox();
            num2 = new TextBox();
            num3 = new TextBox();
            label4 = new Label();
            lblrslt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 60);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "numero_1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 60);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "numero_2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(605, 60);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "numero_3";
            // 
            // num1
            // 
            num1.Location = new Point(253, 92);
            num1.Name = "num1";
            num1.Size = new Size(126, 23);
            num1.TabIndex = 3;
            // 
            // num2
            // 
            num2.Location = new Point(413, 92);
            num2.Name = "num2";
            num2.Size = new Size(126, 23);
            num2.TabIndex = 4;
            // 
            // num3
            // 
            num3.Location = new Point(574, 92);
            num3.Name = "num3";
            num3.Size = new Size(121, 23);
            num3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 34);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 6;
            label4.Text = "que numero es el mayor";
            // 
            // lblrslt
            // 
            lblrslt.Location = new Point(402, 172);
            lblrslt.Name = "lblrslt";
            lblrslt.Size = new Size(150, 52);
            lblrslt.TabIndex = 7;
            lblrslt.Text = "button1";
            lblrslt.UseVisualStyleBackColor = true;
            lblrslt.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblrslt);
            Controls.Add(label4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
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
        private TextBox num1;
        private TextBox num2;
        private TextBox num3;
        private Label label4;
        private Button lblrslt;
    }
}