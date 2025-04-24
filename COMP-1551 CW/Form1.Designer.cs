namespace COMP_1551_CW
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
            OutputTxt = new Label();
            OutputLbl = new Label();
            CbSortOutput = new CheckBox();
            CbReturnInput = new CheckBox();
            NNullLbl = new Label();
            SNullLbl = new Label();
            NumErrLbl = new Label();
            SErrorLbl = new Label();
            StartBtn = new Button();
            NumTb = new TextBox();
            NumLbl = new Label();
            StringTb = new TextBox();
            TextLbl = new Label();
            AppName = new Label();
            ASCIILbl = new Label();
            ASCIITxt = new Label();
            SuspendLayout();
            // 
            // OutputTxt
            // 
            OutputTxt.Anchor = AnchorStyles.None;
            OutputTxt.AutoSize = true;
            OutputTxt.Location = new Point(689, 387);
            OutputTxt.Name = "OutputTxt";
            OutputTxt.Size = new Size(103, 20);
            OutputTxt.TabIndex = 58;
            OutputTxt.Text = "Your output is:";
            OutputTxt.Visible = false;
            // 
            // OutputLbl
            // 
            OutputLbl.Anchor = AnchorStyles.None;
            OutputLbl.AutoSize = true;
            OutputLbl.Location = new Point(257, 387);
            OutputLbl.Name = "OutputLbl";
            OutputLbl.Size = new Size(103, 20);
            OutputLbl.TabIndex = 57;
            OutputLbl.Text = "Your output is:";
            // 
            // CbSortOutput
            // 
            CbSortOutput.AutoSize = true;
            CbSortOutput.Location = new Point(615, 293);
            CbSortOutput.Name = "CbSortOutput";
            CbSortOutput.Size = new Size(154, 24);
            CbSortOutput.TabIndex = 56;
            CbSortOutput.Text = "Sort output string?";
            CbSortOutput.UseVisualStyleBackColor = true;
            // 
            // CbReturnInput
            // 
            CbReturnInput.AutoSize = true;
            CbReturnInput.Location = new Point(339, 293);
            CbReturnInput.Name = "CbReturnInput";
            CbReturnInput.Size = new Size(160, 24);
            CbReturnInput.TabIndex = 55;
            CbReturnInput.Text = "Return input string?";
            CbReturnInput.UseVisualStyleBackColor = true;
            // 
            // NNullLbl
            // 
            NNullLbl.AutoSize = true;
            NNullLbl.ForeColor = Color.Red;
            NNullLbl.Location = new Point(768, 215);
            NNullLbl.Name = "NNullLbl";
            NNullLbl.Size = new Size(141, 20);
            NNullLbl.TabIndex = 54;
            NNullLbl.Text = "Please Enter a Value";
            NNullLbl.Visible = false;
            // 
            // SNullLbl
            // 
            SNullLbl.AutoSize = true;
            SNullLbl.ForeColor = Color.Red;
            SNullLbl.Location = new Point(768, 162);
            SNullLbl.Name = "SNullLbl";
            SNullLbl.Size = new Size(141, 20);
            SNullLbl.TabIndex = 53;
            SNullLbl.Text = "Please Enter a Value";
            SNullLbl.Visible = false;
            // 
            // NumErrLbl
            // 
            NumErrLbl.AutoSize = true;
            NumErrLbl.ForeColor = Color.Red;
            NumErrLbl.Location = new Point(413, 255);
            NumErrLbl.Name = "NumErrLbl";
            NumErrLbl.Size = new Size(337, 20);
            NumErrLbl.TabIndex = 52;
            NumErrLbl.Text = "Number value must be within -25 to 25. Try again.";
            NumErrLbl.Visible = false;
            // 
            // SErrorLbl
            // 
            SErrorLbl.AutoSize = true;
            SErrorLbl.ForeColor = Color.Red;
            SErrorLbl.Location = new Point(339, 255);
            SErrorLbl.Name = "SErrorLbl";
            SErrorLbl.Size = new Size(453, 20);
            SErrorLbl.TabIndex = 51;
            SErrorLbl.Text = "String must be less than 40 characters and all capitalized. Try again.";
            SErrorLbl.Visible = false;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(513, 343);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(94, 29);
            StartBtn.TabIndex = 50;
            StartBtn.Text = "Encode!";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click_1;
            // 
            // NumTb
            // 
            NumTb.Location = new Point(615, 208);
            NumTb.Name = "NumTb";
            NumTb.Size = new Size(125, 27);
            NumTb.TabIndex = 49;
            // 
            // NumLbl
            // 
            NumLbl.AutoSize = true;
            NumLbl.Location = new Point(257, 215);
            NumLbl.Name = "NumLbl";
            NumLbl.Size = new Size(311, 20);
            NumLbl.TabIndex = 48;
            NumLbl.Text = "Enter number of characters to shift (-25 to 25)";
            // 
            // StringTb
            // 
            StringTb.Location = new Point(615, 159);
            StringTb.Name = "StringTb";
            StringTb.Size = new Size(125, 27);
            StringTb.TabIndex = 47;
            // 
            // TextLbl
            // 
            TextLbl.AutoSize = true;
            TextLbl.Location = new Point(257, 166);
            TextLbl.Name = "TextLbl";
            TextLbl.Size = new Size(256, 20);
            TextLbl.TabIndex = 46;
            TextLbl.Text = "Enter string to encode (Capitals Only)";
            // 
            // AppName
            // 
            AppName.AutoSize = true;
            AppName.FlatStyle = FlatStyle.Flat;
            AppName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppName.Location = new Point(446, 92);
            AppName.Name = "AppName";
            AppName.Size = new Size(246, 31);
            AppName.TabIndex = 45;
            AppName.Text = "CONVERSION EDITOR";
            // 
            // ASCIILbl
            // 
            ASCIILbl.AutoSize = true;
            ASCIILbl.Location = new Point(257, 439);
            ASCIILbl.Name = "ASCIILbl";
            ASCIILbl.Size = new Size(151, 20);
            ASCIILbl.TabIndex = 59;
            ASCIILbl.Text = "ASCII values of string:";
            ASCIILbl.Click += label1_Click_1;
            // 
            // ASCIITxt
            // 
            ASCIITxt.AutoSize = true;
            ASCIITxt.Location = new Point(689, 439);
            ASCIITxt.Name = "ASCIITxt";
            ASCIITxt.Size = new Size(50, 20);
            ASCIITxt.TabIndex = 60;
            ASCIITxt.Text = "label1";
            ASCIITxt.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 753);
            Controls.Add(ASCIITxt);
            Controls.Add(ASCIILbl);
            Controls.Add(OutputTxt);
            Controls.Add(OutputLbl);
            Controls.Add(CbSortOutput);
            Controls.Add(CbReturnInput);
            Controls.Add(NNullLbl);
            Controls.Add(SNullLbl);
            Controls.Add(NumErrLbl);
            Controls.Add(SErrorLbl);
            Controls.Add(StartBtn);
            Controls.Add(NumTb);
            Controls.Add(NumLbl);
            Controls.Add(StringTb);
            Controls.Add(TextLbl);
            Controls.Add(AppName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OutputTxt;
        private Label OutputLbl;
        private CheckBox CbSortOutput;
        private CheckBox CbReturnInput;
        private Label NNullLbl;
        private Label SNullLbl;
        private Label NumErrLbl;
        private Label SErrorLbl;
        private Button StartBtn;
        private TextBox NumTb;
        private Label NumLbl;
        private TextBox StringTb;
        private Label TextLbl;
        private Label AppName;
        private Label ASCIILbl;
        private Label ASCIITxt;
    }
}
