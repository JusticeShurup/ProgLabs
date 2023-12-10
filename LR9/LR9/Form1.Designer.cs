namespace LR9
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
            textBoxF = new TextBox();
            Arg1 = new Label();
            label2 = new Label();
            textBoxW = new TextBox();
            label3 = new Label();
            textBoxT = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxF
            // 
            textBoxF.Location = new Point(192, 188);
            textBoxF.Name = "textBoxF";
            textBoxF.Size = new Size(108, 23);
            textBoxF.TabIndex = 0;
            textBoxF.KeyPress += TextBoxValidation;
            // 
            // Arg1
            // 
            Arg1.AutoSize = true;
            Arg1.Location = new Point(242, 170);
            Arg1.Name = "Arg1";
            Arg1.Size = new Size(11, 15);
            Arg1.TabIndex = 1;
            Arg1.Text = "f";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 170);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 5;
            label2.Text = "w";
            // 
            // textBoxW
            // 
            textBoxW.Location = new Point(345, 188);
            textBoxW.Name = "textBoxW";
            textBoxW.Size = new Size(108, 23);
            textBoxW.TabIndex = 4;
            textBoxW.KeyPress += TextBoxValidation;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(551, 170);
            label3.Name = "label3";
            label3.Size = new Size(11, 15);
            label3.TabIndex = 7;
            label3.Text = "t";
            // 
            // textBoxT
            // 
            textBoxT.Location = new Point(500, 188);
            textBoxT.Name = "textBoxT";
            textBoxT.Size = new Size(108, 23);
            textBoxT.TabIndex = 6;
            textBoxT.KeyPress += TextBoxValidation;
            // 
            // button1
            // 
            button1.Location = new Point(366, 379);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Calculate;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(288, 9);
            label4.Name = "label4";
            label4.Size = new Size(235, 32);
            label4.TabIndex = 9;
            label4.Text = "Крутой калькулятор";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBoxT);
            Controls.Add(label2);
            Controls.Add(textBoxW);
            Controls.Add(Arg1);
            Controls.Add(textBoxF);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxF;
        private Label Arg1;
        private Label label2;
        private TextBox textBoxW;
        private Label label3;
        private TextBox textBoxT;
        private Button button1;
        private Label label4;
    }
}