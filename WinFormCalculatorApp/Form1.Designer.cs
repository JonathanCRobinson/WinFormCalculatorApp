namespace WinFormCalculatorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            buttonPosNeg = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // textBoxCalculation
            // 
            textBoxCalculation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCalculation.BackColor = SystemColors.ControlLightLight;
            textBoxCalculation.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCalculation.Location = new Point(12, 12);
            textBoxCalculation.MaximumSize = new Size(626, 99);
            textBoxCalculation.MinimumSize = new Size(417, 66);
            textBoxCalculation.Name = "textBoxCalculation";
            textBoxCalculation.PlaceholderText = "0";
            textBoxCalculation.ReadOnly = true;
            textBoxCalculation.Size = new Size(417, 66);
            textBoxCalculation.TabIndex = 17;
            textBoxCalculation.TextAlign = HorizontalAlignment.Right;
            // 
            // n1
            // 
            n1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n1.AutoEllipsis = true;
            n1.AutoSize = true;
            n1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            n1.Font = new Font("Segoe UI", 25F);
            n1.Location = new Point(12, 291);
            n1.MaximumSize = new Size(150, 90);
            n1.MinimumSize = new Size(100, 60);
            n1.Name = "n1";
            n1.Size = new Size(100, 60);
            n1.TabIndex = 1;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += N1_Click;
            n1.KeyDown += KeyboardInput;
            // 
            // n2
            // 
            n2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n2.AutoEllipsis = true;
            n2.AutoSize = true;
            n2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            n2.Font = new Font("Segoe UI", 25F);
            n2.Location = new Point(118, 291);
            n2.MaximumSize = new Size(150, 90);
            n2.MinimumSize = new Size(100, 60);
            n2.Name = "n2";
            n2.Size = new Size(100, 60);
            n2.TabIndex = 2;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += N2_Click;
            n2.KeyDown += KeyboardInput;
            // 
            // n3
            // 
            n3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n3.AutoEllipsis = true;
            n3.AutoSize = true;
            n3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            n3.Font = new Font("Segoe UI", 25F);
            n3.Location = new Point(224, 291);
            n3.MaximumSize = new Size(150, 90);
            n3.MinimumSize = new Size(100, 60);
            n3.Name = "n3";
            n3.Size = new Size(100, 60);
            n3.TabIndex = 3;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += N3_Click;
            n3.KeyDown += KeyboardInput;
            // 
            // n4
            // 
            n4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n4.AutoEllipsis = true;
            n4.AutoSize = true;
            n4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            n4.Font = new Font("Segoe UI", 25F);
            n4.Location = new Point(12, 225);
            n4.MaximumSize = new Size(150, 90);
            n4.MinimumSize = new Size(100, 60);
            n4.Name = "n4";
            n4.Size = new Size(100, 60);
            n4.TabIndex = 4;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += N4_Click;
            n4.KeyDown += KeyboardInput;
            // 
            // n5
            // 
            n5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n5.AutoEllipsis = true;
            n5.AutoSize = true;
            n5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            n5.Font = new Font("Segoe UI", 25F);
            n5.Location = new Point(118, 225);
            n5.MaximumSize = new Size(150, 90);
            n5.MinimumSize = new Size(100, 60);
            n5.Name = "n5";
            n5.Size = new Size(100, 60);
            n5.TabIndex = 5;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += N5_Click;
            n5.KeyDown += KeyboardInput;
            // 
            // n6
            // 
            n6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n6.AutoEllipsis = true;
            n6.AutoSize = true;
            n6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            n6.Font = new Font("Segoe UI", 25F);
            n6.Location = new Point(224, 225);
            n6.MaximumSize = new Size(150, 90);
            n6.MinimumSize = new Size(100, 60);
            n6.Name = "n6";
            n6.Size = new Size(100, 60);
            n6.TabIndex = 6;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += N6_Click;
            n6.KeyDown += KeyboardInput;
            // 
            // n7
            // 
            n7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n7.AutoEllipsis = true;
            n7.AutoSize = true;
            n7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            n7.Font = new Font("Segoe UI", 25F);
            n7.Location = new Point(12, 159);
            n7.MaximumSize = new Size(150, 90);
            n7.MinimumSize = new Size(100, 60);
            n7.Name = "n7";
            n7.Size = new Size(100, 60);
            n7.TabIndex = 7;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += N7_Click;
            n7.KeyDown += KeyboardInput;
            // 
            // n8
            // 
            n8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n8.AutoEllipsis = true;
            n8.AutoSize = true;
            n8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            n8.Font = new Font("Segoe UI", 25F);
            n8.Location = new Point(118, 159);
            n8.MaximumSize = new Size(150, 90);
            n8.MinimumSize = new Size(100, 60);
            n8.Name = "n8";
            n8.Size = new Size(100, 60);
            n8.TabIndex = 8;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += N8_Click;
            n8.KeyDown += KeyboardInput;
            // 
            // n9
            // 
            n9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n9.AutoEllipsis = true;
            n9.AutoSize = true;
            n9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            n9.Font = new Font("Segoe UI", 25F);
            n9.Location = new Point(224, 159);
            n9.MaximumSize = new Size(150, 90);
            n9.MinimumSize = new Size(100, 60);
            n9.Name = "n9";
            n9.Size = new Size(100, 60);
            n9.TabIndex = 9;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += N9_Click;
            n9.KeyDown += KeyboardInput;
            // 
            // n0
            // 
            n0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            n0.AutoEllipsis = true;
            n0.AutoSize = true;
            n0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            n0.Font = new Font("Segoe UI", 25F);
            n0.Location = new Point(118, 357);
            n0.MaximumSize = new Size(150, 90);
            n0.MinimumSize = new Size(100, 60);
            n0.Name = "n0";
            n0.Size = new Size(100, 60);
            n0.TabIndex = 10;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += N0_Click;
            n0.KeyDown += KeyboardInput;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.AutoEllipsis = true;
            buttonAdd.AutoSize = true;
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.Font = new Font("Segoe UI", 25F);
            buttonAdd.Location = new Point(330, 225);
            buttonAdd.MaximumSize = new Size(150, 90);
            buttonAdd.MinimumSize = new Size(100, 60);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 60);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += Add_Click;
            // 
            // buttonSub
            // 
            buttonSub.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSub.AutoEllipsis = true;
            buttonSub.AutoSize = true;
            buttonSub.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSub.Font = new Font("Segoe UI", 25F);
            buttonSub.Location = new Point(330, 159);
            buttonSub.MaximumSize = new Size(150, 90);
            buttonSub.MinimumSize = new Size(100, 60);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(100, 60);
            buttonSub.TabIndex = 12;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += Sub_Click;
            // 
            // buttonMult
            // 
            buttonMult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMult.AutoEllipsis = true;
            buttonMult.AutoSize = true;
            buttonMult.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonMult.Font = new Font("Segoe UI", 25F);
            buttonMult.Location = new Point(118, 93);
            buttonMult.MaximumSize = new Size(150, 90);
            buttonMult.MinimumSize = new Size(100, 60);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(100, 60);
            buttonMult.TabIndex = 13;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += Mult_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDecimal.AutoEllipsis = true;
            buttonDecimal.AutoSize = true;
            buttonDecimal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDecimal.Font = new Font("Segoe UI", 25F);
            buttonDecimal.Location = new Point(224, 357);
            buttonDecimal.MaximumSize = new Size(150, 90);
            buttonDecimal.MinimumSize = new Size(100, 60);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(100, 60);
            buttonDecimal.TabIndex = 14;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += Decimal_Click;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonClear.AutoEllipsis = true;
            buttonClear.AutoSize = true;
            buttonClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonClear.Font = new Font("Segoe UI", 18F);
            buttonClear.Location = new Point(12, 93);
            buttonClear.MaximumSize = new Size(150, 90);
            buttonClear.MinimumSize = new Size(100, 60);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(100, 60);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += Clear_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDivide.AutoEllipsis = true;
            buttonDivide.AutoSize = true;
            buttonDivide.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDivide.Font = new Font("Segoe UI", 25F);
            buttonDivide.Location = new Point(224, 93);
            buttonDivide.MaximumSize = new Size(150, 90);
            buttonDivide.MinimumSize = new Size(100, 60);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(100, 60);
            buttonDivide.TabIndex = 16;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += Divide_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEnter.AutoEllipsis = true;
            buttonEnter.AutoSize = true;
            buttonEnter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEnter.Font = new Font("Segoe UI", 25F);
            buttonEnter.Location = new Point(330, 291);
            buttonEnter.MaximumSize = new Size(150, 189);
            buttonEnter.MinimumSize = new Size(100, 126);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(100, 126);
            buttonEnter.TabIndex = 17;
            buttonEnter.Text = "=";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += Equal_Click;
            // 
            // buttonPosNeg
            // 
            buttonPosNeg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPosNeg.AutoEllipsis = true;
            buttonPosNeg.AutoSize = true;
            buttonPosNeg.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonPosNeg.Font = new Font("Segoe UI", 18F);
            buttonPosNeg.Location = new Point(12, 357);
            buttonPosNeg.MaximumSize = new Size(150, 90);
            buttonPosNeg.MinimumSize = new Size(100, 60);
            buttonPosNeg.Name = "buttonPosNeg";
            buttonPosNeg.Size = new Size(100, 60);
            buttonPosNeg.TabIndex = 18;
            buttonPosNeg.Text = "+/-";
            buttonPosNeg.UseVisualStyleBackColor = true;
            buttonPosNeg.Click += PosNeg_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBack.AutoEllipsis = true;
            buttonBack.AutoSize = true;
            buttonBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonBack.Font = new Font("Segoe UI", 18F);
            buttonBack.Location = new Point(330, 93);
            buttonBack.MaximumSize = new Size(150, 90);
            buttonBack.MinimumSize = new Size(100, 60);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 60);
            buttonBack.TabIndex = 19;
            buttonBack.Text = "<-";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(440, 434);
            Controls.Add(buttonBack);
            Controls.Add(buttonPosNeg);
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
            MaximumSize = new Size(685, 710);
            MinimumSize = new Size(456, 473);
            Name = "Form1";
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
        private Button buttonPosNeg;
        private Button buttonBack;
    }
}
