namespace kalkulator
{
    partial class Calculator
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
            ResultBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            DotBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            ModuloBtn = new Button();
            MultiplyBtn = new Button();
            MinusBtn = new Button();
            PlusMinusBtn = new Button();
            DivideBtn = new Button();
            PlusBtn = new Button();
            ClearBtn = new Button();
            ClearEntryBtn = new Button();
            Display_Label = new Label();
            BackSpaceBtn = new Button();
            SuspendLayout();
            // 
            // ResultBox
            // 
            ResultBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ResultBox.Location = new Point(12, 13);
            ResultBox.Margin = new Padding(3, 4, 3, 4);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(298, 52);
            ResultBox.TabIndex = 0;
            ResultBox.Text = "0";
            ResultBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SevenBtn.Location = new Point(14, 104);
            SevenBtn.Margin = new Padding(3, 4, 3, 4);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(61, 71);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += Btn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FourBtn.Location = new Point(14, 183);
            FourBtn.Margin = new Padding(3, 4, 3, 4);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(61, 71);
            FourBtn.TabIndex = 2;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += Btn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            OneBtn.Location = new Point(14, 261);
            OneBtn.Margin = new Padding(3, 4, 3, 4);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(61, 71);
            OneBtn.TabIndex = 3;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += Btn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ZeroBtn.Location = new Point(14, 340);
            ZeroBtn.Margin = new Padding(3, 4, 3, 4);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(61, 71);
            ZeroBtn.TabIndex = 4;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += Btn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DotBtn.Location = new Point(82, 340);
            DotBtn.Margin = new Padding(3, 4, 3, 4);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(61, 71);
            DotBtn.TabIndex = 8;
            DotBtn.Text = ",";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += Btn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TwoBtn.Location = new Point(82, 261);
            TwoBtn.Margin = new Padding(3, 4, 3, 4);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(61, 71);
            TwoBtn.TabIndex = 7;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += Btn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FiveBtn.Location = new Point(82, 183);
            FiveBtn.Margin = new Padding(3, 4, 3, 4);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(61, 71);
            FiveBtn.TabIndex = 6;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += Btn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EightBtn.Location = new Point(82, 104);
            EightBtn.Margin = new Padding(3, 4, 3, 4);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(61, 71);
            EightBtn.TabIndex = 5;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += Btn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EqualBtn.Location = new Point(151, 340);
            EqualBtn.Margin = new Padding(3, 4, 3, 4);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(61, 71);
            EqualBtn.TabIndex = 12;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ThreeBtn.Location = new Point(151, 261);
            ThreeBtn.Margin = new Padding(3, 4, 3, 4);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(61, 71);
            ThreeBtn.TabIndex = 11;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += Btn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SixBtn.Location = new Point(151, 183);
            SixBtn.Margin = new Padding(3, 4, 3, 4);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(61, 71);
            SixBtn.TabIndex = 10;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += Btn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NineBtn.Location = new Point(151, 104);
            NineBtn.Margin = new Padding(3, 4, 3, 4);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(61, 71);
            NineBtn.TabIndex = 9;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += Btn_Click;
            // 
            // ModuloBtn
            // 
            ModuloBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ModuloBtn.Location = new Point(317, 340);
            ModuloBtn.Margin = new Padding(3, 4, 3, 4);
            ModuloBtn.Name = "ModuloBtn";
            ModuloBtn.Size = new Size(61, 71);
            ModuloBtn.TabIndex = 16;
            ModuloBtn.Text = "%";
            ModuloBtn.UseVisualStyleBackColor = true;
            ModuloBtn.Click += Operator_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MultiplyBtn.Location = new Point(317, 261);
            MultiplyBtn.Margin = new Padding(3, 4, 3, 4);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(61, 71);
            MultiplyBtn.TabIndex = 15;
            MultiplyBtn.Text = "*";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += Operator_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MinusBtn.Location = new Point(317, 183);
            MinusBtn.Margin = new Padding(3, 4, 3, 4);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(61, 71);
            MinusBtn.TabIndex = 14;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += Operator_Click;
            // 
            // PlusMinusBtn
            // 
            PlusMinusBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PlusMinusBtn.Location = new Point(249, 340);
            PlusMinusBtn.Margin = new Padding(3, 4, 3, 4);
            PlusMinusBtn.Name = "PlusMinusBtn";
            PlusMinusBtn.Size = new Size(61, 71);
            PlusMinusBtn.TabIndex = 20;
            PlusMinusBtn.Text = "+/-";
            PlusMinusBtn.UseVisualStyleBackColor = true;
            PlusMinusBtn.Click += PlusMinusBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DivideBtn.Location = new Point(249, 261);
            DivideBtn.Margin = new Padding(3, 4, 3, 4);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(61, 71);
            DivideBtn.TabIndex = 19;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            DivideBtn.Click += Operator_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PlusBtn.Location = new Point(249, 183);
            PlusBtn.Margin = new Padding(3, 4, 3, 4);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(61, 71);
            PlusBtn.TabIndex = 18;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += Operator_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.Location = new Point(249, 104);
            ClearBtn.Margin = new Padding(3, 4, 3, 4);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(61, 71);
            ClearBtn.TabIndex = 17;
            ClearBtn.Text = "C";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // ClearEntryBtn
            // 
            ClearEntryBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ClearEntryBtn.Location = new Point(317, 104);
            ClearEntryBtn.Margin = new Padding(3, 4, 3, 4);
            ClearEntryBtn.Name = "ClearEntryBtn";
            ClearEntryBtn.Size = new Size(61, 71);
            ClearEntryBtn.TabIndex = 21;
            ClearEntryBtn.Text = "Ce";
            ClearEntryBtn.UseVisualStyleBackColor = true;
            ClearEntryBtn.Click += ClearEntryBtn_Click;
            // 
            // Display_Label
            // 
            Display_Label.AutoSize = true;
            Display_Label.ForeColor = SystemColors.ControlDarkDark;
            Display_Label.Location = new Point(14, 16);
            Display_Label.Name = "Display_Label";
            Display_Label.Size = new Size(0, 20);
            Display_Label.TabIndex = 22;
            // 
            // BackSpaceBtn
            // 
            BackSpaceBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BackSpaceBtn.Location = new Point(318, 13);
            BackSpaceBtn.Margin = new Padding(3, 4, 3, 4);
            BackSpaceBtn.Name = "BackSpaceBtn";
            BackSpaceBtn.Size = new Size(61, 52);
            BackSpaceBtn.TabIndex = 23;
            BackSpaceBtn.Text = "<=";
            BackSpaceBtn.UseVisualStyleBackColor = true;
            BackSpaceBtn.Click += BackSpaceBtn_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 433);
            Controls.Add(BackSpaceBtn);
            Controls.Add(Display_Label);
            Controls.Add(ClearEntryBtn);
            Controls.Add(PlusMinusBtn);
            Controls.Add(DivideBtn);
            Controls.Add(PlusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(ModuloBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(MinusBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(ResultBox);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(409, 480);
            MinimumSize = new Size(409, 480);
            Name = "Calculator";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ResultBox;
        private Button OneBtn;
        private Button SevenBtn;
        private Button FourBtn;
        private Button ZeroBtn;
        private Button DotBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button ModuloBtn;
        private Button MultiplyBtn;
        private Button MinusBtn;
        private Button PlusMinusBtn;
        private Button DivideBtn;
        private Button PlusBtn;
        private Button ClearBtn;
        private Button ClearEntryBtn;
        private Label Display_Label;
        private Button BackSpaceBtn;
    }
}