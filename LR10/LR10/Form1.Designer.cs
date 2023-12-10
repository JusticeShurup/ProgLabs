namespace LR10
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
            labelP = new Label();
            FirstMethod = new RadioButton();
            SecondMethod = new RadioButton();
            textBoxP = new TextBox();
            button1 = new Button();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            labelB = new Label();
            labelC = new Label();
            textBoxN = new TextBox();
            labelN = new Label();
            labelR = new Label();
            textBoxR = new TextBox();
            SuspendLayout();
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.Location = new Point(137, 177);
            labelP.Name = "labelP";
            labelP.Size = new Size(14, 15);
            labelP.TabIndex = 3;
            labelP.Text = "P";
            // 
            // FirstMethod
            // 
            FirstMethod.AutoSize = true;
            FirstMethod.Location = new Point(188, 129);
            FirstMethod.Name = "FirstMethod";
            FirstMethod.Size = new Size(112, 19);
            FirstMethod.TabIndex = 0;
            FirstMethod.TabStop = true;
            FirstMethod.Text = "Первый способ";
            FirstMethod.UseVisualStyleBackColor = true;
            FirstMethod.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // SecondMethod
            // 
            SecondMethod.AutoSize = true;
            SecondMethod.Location = new Point(514, 129);
            SecondMethod.Name = "SecondMethod";
            SecondMethod.Size = new Size(108, 19);
            SecondMethod.TabIndex = 1;
            SecondMethod.TabStop = true;
            SecondMethod.Text = "Второй способ";
            SecondMethod.UseVisualStyleBackColor = true;
            SecondMethod.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBoxP
            // 
            textBoxP.Location = new Point(188, 174);
            textBoxP.Name = "textBoxP";
            textBoxP.Size = new Size(100, 23);
            textBoxP.TabIndex = 2;
            textBoxP.KeyPress += TextBoxDoubleValidation;
            // 
            // button1
            // 
            button1.Location = new Point(338, 415);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 4;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(514, 174);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 5;
            textBoxB.Visible = false;
            textBoxB.KeyPress += TextBoxDoubleValidation;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(514, 229);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(100, 23);
            textBoxC.TabIndex = 6;
            textBoxC.Visible = false;
            textBoxC.KeyPress += TextBoxDoubleValidation;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(471, 177);
            labelB.Name = "labelB";
            labelB.Size = new Size(14, 15);
            labelB.TabIndex = 8;
            labelB.Text = "b";
            labelB.Visible = false;
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(471, 232);
            labelC.Name = "labelC";
            labelC.Size = new Size(13, 15);
            labelC.TabIndex = 9;
            labelC.Text = "c";
            labelC.Visible = false;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(361, 31);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(100, 23);
            textBoxN.TabIndex = 10;
            textBoxN.KeyPress += TextBoxIntValidation;
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.Location = new Point(317, 34);
            labelN.Name = "labelN";
            labelN.Size = new Size(16, 15);
            labelN.TabIndex = 11;
            labelN.Text = "N";
            // 
            // labelR
            // 
            labelR.AutoSize = true;
            labelR.Location = new Point(470, 278);
            labelR.Name = "labelR";
            labelR.Size = new Size(14, 15);
            labelR.TabIndex = 13;
            labelR.Text = "R";
            // 
            // textBoxR
            // 
            textBoxR.Location = new Point(514, 275);
            textBoxR.Name = "textBoxR";
            textBoxR.Size = new Size(100, 23);
            textBoxR.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelR);
            Controls.Add(textBoxR);
            Controls.Add(labelN);
            Controls.Add(textBoxN);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(button1);
            Controls.Add(labelP);
            Controls.Add(textBoxP);
            Controls.Add(SecondMethod);
            Controls.Add(FirstMethod);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton FirstMethod;
        private RadioButton SecondMethod;
        private TextBox textBoxP;
        private Label labelP;
        private Button button1;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Label labelB;
        private Label labelC;
        private TextBox textBoxN;
        private Label labelN;
        private Label labelR;
        private TextBox textBoxR;
    }
}