namespace WinFormCalculatorApp
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            textBoxCalculation = new TextBox();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            n0 = new Button();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMult = new Button();
            buttonDecimal = new Button();
            buttonClear = new Button();
            buttonDivide = new Button();
            buttonEnter = new Button();
            SuspendLayout();
            // 
            // textBoxCalculation
            // 
            textBoxCalculation.BackColor = SystemColors.ControlLightLight;
            textBoxCalculation.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCalculation.Location = new Point(12, 12);
            textBoxCalculation.Name = "textBoxCalculation";
            textBoxCalculation.ReadOnly = true;
            textBoxCalculation.Size = new Size(417, 66);
            textBoxCalculation.TabIndex = 17;
            textBoxCalculation.Text = "0";
            textBoxCalculation.TextAlign = HorizontalAlignment.Right;
            // 
            // n1
            // 
            n1.Font = new Font("Segoe UI", 25F);
            n1.Location = new Point(32, 101);
            n1.Name = "n1";
            n1.Size = new Size(76, 63);
            n1.TabIndex = 1;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += n1_Click;
            n1.KeyDown += KeyboardInput;
            // 
            // n2
            // 
            n2.Font = new Font("Segoe UI", 25F);
            n2.Location = new Point(131, 101);
            n2.Name = "n2";
            n2.Size = new Size(76, 63);
            n2.TabIndex = 2;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += n2_Click;
            n2.KeyDown += KeyboardInput;
            // 
            // n3
            // 
            n3.Font = new Font("Segoe UI", 25F);
            n3.Location = new Point(231, 101);
            n3.Name = "n3";
            n3.Size = new Size(76, 63);
            n3.TabIndex = 3;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += n3_Click;
            n3.KeyDown += KeyboardInput;
            // 
            // n4
            // 
            n4.Font = new Font("Segoe UI", 25F);
            n4.Location = new Point(32, 190);
            n4.Name = "n4";
            n4.Size = new Size(76, 63);
            n4.TabIndex = 4;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += n4_Click;
            n4.KeyDown += KeyboardInput;
            // 
            // n5
            // 
            n5.Font = new Font("Segoe UI", 25F);
            n5.Location = new Point(131, 190);
            n5.Name = "n5";
            n5.Size = new Size(76, 63);
            n5.TabIndex = 5;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += n5_Click;
            n5.KeyDown += KeyboardInput;
            // 
            // n6
            // 
            n6.Font = new Font("Segoe UI", 25F);
            n6.Location = new Point(231, 190);
            n6.Name = "n6";
            n6.Size = new Size(76, 63);
            n6.TabIndex = 6;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += n6_Click;
            n6.KeyDown += KeyboardInput;
            // 
            // n7
            // 
            n7.Font = new Font("Segoe UI", 25F);
            n7.Location = new Point(32, 284);
            n7.Name = "n7";
            n7.Size = new Size(76, 63);
            n7.TabIndex = 7;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += n7_Click;
            n7.KeyDown += KeyboardInput;
            // 
            // n8
            // 
            n8.Font = new Font("Segoe UI", 25F);
            n8.Location = new Point(131, 284);
            n8.Name = "n8";
            n8.Size = new Size(76, 63);
            n8.TabIndex = 8;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += n8_Click;
            n8.KeyDown += KeyboardInput;
            // 
            // n9
            // 
            n9.Font = new Font("Segoe UI", 25F);
            n9.Location = new Point(231, 284);
            n9.Name = "n9";
            n9.Size = new Size(76, 63);
            n9.TabIndex = 9;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += n9_Click;
            n9.KeyDown += KeyboardInput;
            // 
            // n0
            // 
            n0.Font = new Font("Segoe UI", 25F);
            n0.Location = new Point(131, 380);
            n0.Name = "n0";
            n0.Size = new Size(76, 63);
            n0.TabIndex = 10;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += n0_Click;
            n0.KeyDown += KeyboardInput;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 25F);
            buttonAdd.Location = new Point(337, 101);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(76, 63);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonSub
            // 
            buttonSub.Font = new Font("Segoe UI", 25F);
            buttonSub.Location = new Point(337, 190);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(76, 63);
            buttonSub.TabIndex = 12;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            // 
            // buttonMult
            // 
            buttonMult.Font = new Font("Segoe UI", 25F);
            buttonMult.Location = new Point(337, 284);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(76, 63);
            buttonMult.TabIndex = 13;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = true;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Segoe UI", 25F);
            buttonDecimal.Location = new Point(32, 380);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(76, 63);
            buttonDecimal.TabIndex = 14;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 18F);
            buttonClear.Location = new Point(231, 380);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(76, 63);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI", 25F);
            buttonDivide.Location = new Point(337, 380);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(76, 63);
            buttonDivide.TabIndex = 16;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            // 
            // buttonEnter
            // 
            buttonEnter.Font = new Font("Segoe UI", 25F);
            buttonEnter.Location = new Point(131, 470);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(76, 63);
            buttonEnter.TabIndex = 17;
            buttonEnter.Text = "=";
            buttonEnter.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(440, 547);
            Controls.Add(buttonEnter);
            Controls.Add(buttonDivide);
            Controls.Add(buttonClear);
            Controls.Add(buttonDecimal);
            Controls.Add(buttonMult);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(n0);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(textBoxCalculation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCalculation;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMult;
        private Button buttonDecimal;
        private Button buttonClear;
        private Button buttonDivide;
        private Button buttonEnter;
    }
}
