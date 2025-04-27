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
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // OutputTxt
            // 
            OutputTxt.Anchor = AnchorStyles.None;
            OutputTxt.AutoSize = true;
            OutputTxt.BackColor = Color.White;
            OutputTxt.Location = new Point(535, 308);
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
            OutputLbl.BackColor = Color.White;
            OutputLbl.Location = new Point(103, 308);
            OutputLbl.Name = "OutputLbl";
            OutputLbl.Size = new Size(103, 20);
            OutputLbl.TabIndex = 57;
            OutputLbl.Text = "Your output is:";
            // 
            // CbSortOutput
            // 
            CbSortOutput.AutoSize = true;
            CbSortOutput.BackColor = Color.White;
            CbSortOutput.Location = new Point(461, 214);
            CbSortOutput.Name = "CbSortOutput";
            CbSortOutput.Size = new Size(154, 24);
            CbSortOutput.TabIndex = 56;
            CbSortOutput.Text = "Sort output string?";
            CbSortOutput.UseVisualStyleBackColor = false;
            // 
            // CbReturnInput
            // 
            CbReturnInput.AutoSize = true;
            CbReturnInput.BackColor = Color.White;
            CbReturnInput.Location = new Point(185, 214);
            CbReturnInput.Name = "CbReturnInput";
            CbReturnInput.Size = new Size(160, 24);
            CbReturnInput.TabIndex = 55;
            CbReturnInput.Text = "Return input string?";
            CbReturnInput.UseVisualStyleBackColor = false;
            // 
            // NNullLbl
            // 
            NNullLbl.AutoSize = true;
            NNullLbl.BackColor = Color.White;
            NNullLbl.ForeColor = Color.Red;
            NNullLbl.Location = new Point(614, 136);
            NNullLbl.Name = "NNullLbl";
            NNullLbl.Size = new Size(141, 20);
            NNullLbl.TabIndex = 54;
            NNullLbl.Text = "Please Enter a Value";
            NNullLbl.Visible = false;
            // 
            // SNullLbl
            // 
            SNullLbl.AutoSize = true;
            SNullLbl.BackColor = Color.White;
            SNullLbl.ForeColor = Color.Red;
            SNullLbl.Location = new Point(614, 83);
            SNullLbl.Name = "SNullLbl";
            SNullLbl.Size = new Size(141, 20);
            SNullLbl.TabIndex = 53;
            SNullLbl.Text = "Please Enter a Value";
            SNullLbl.Visible = false;
            // 
            // NumErrLbl
            // 
            NumErrLbl.AutoSize = true;
            NumErrLbl.BackColor = Color.White;
            NumErrLbl.ForeColor = Color.Red;
            NumErrLbl.Location = new Point(259, 176);
            NumErrLbl.Name = "NumErrLbl";
            NumErrLbl.Size = new Size(337, 20);
            NumErrLbl.TabIndex = 52;
            NumErrLbl.Text = "Number value must be within -25 to 25. Try again.";
            NumErrLbl.Visible = false;
            NumErrLbl.Click += NumErrLbl_Click;
            // 
            // SErrorLbl
            // 
            SErrorLbl.AutoSize = true;
            SErrorLbl.BackColor = Color.White;
            SErrorLbl.ForeColor = Color.Red;
            SErrorLbl.Location = new Point(185, 241);
            SErrorLbl.Name = "SErrorLbl";
            SErrorLbl.Size = new Size(453, 20);
            SErrorLbl.TabIndex = 51;
            SErrorLbl.Text = "String must be less than 40 characters and all capitalized. Try again.";
            SErrorLbl.Visible = false;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(359, 264);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(94, 29);
            StartBtn.TabIndex = 50;
            StartBtn.Text = "Encode!";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click_1;
            // 
            // NumTb
            // 
            NumTb.Location = new Point(461, 129);
            NumTb.Name = "NumTb";
            NumTb.Size = new Size(125, 27);
            NumTb.TabIndex = 49;
            // 
            // NumLbl
            // 
            NumLbl.AutoSize = true;
            NumLbl.BackColor = Color.White;
            NumLbl.Location = new Point(103, 136);
            NumLbl.Name = "NumLbl";
            NumLbl.Size = new Size(311, 20);
            NumLbl.TabIndex = 48;
            NumLbl.Text = "Enter number of characters to shift (-25 to 25)";
            // 
            // StringTb
            // 
            StringTb.Location = new Point(461, 80);
            StringTb.Name = "StringTb";
            StringTb.Size = new Size(125, 27);
            StringTb.TabIndex = 47;
            // 
            // TextLbl
            // 
            TextLbl.AutoSize = true;
            TextLbl.BackColor = Color.White;
            TextLbl.Location = new Point(103, 87);
            TextLbl.Name = "TextLbl";
            TextLbl.Size = new Size(256, 20);
            TextLbl.TabIndex = 46;
            TextLbl.Text = "Enter string to encode (Capitals Only)";
            // 
            // AppName
            // 
            AppName.AutoSize = true;
            AppName.BackColor = Color.White;
            AppName.FlatStyle = FlatStyle.Flat;
            AppName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppName.Location = new Point(327, 9);
            AppName.Name = "AppName";
            AppName.Size = new Size(178, 31);
            AppName.TabIndex = 45;
            AppName.Text = "TEXT ENCODER";
            AppName.Click += AppName_Click;
            // 
            // ASCIILbl
            // 
            ASCIILbl.AutoSize = true;
            ASCIILbl.BackColor = Color.White;
            ASCIILbl.Location = new Point(103, 360);
            ASCIILbl.Name = "ASCIILbl";
            ASCIILbl.Size = new Size(151, 20);
            ASCIILbl.TabIndex = 59;
            ASCIILbl.Text = "ASCII values of string:";
            ASCIILbl.Click += label1_Click_1;
            // 
            // ASCIITxt
            // 
            ASCIITxt.AutoSize = true;
            ASCIITxt.BackColor = Color.White;
            ASCIITxt.Location = new Point(535, 360);
            ASCIITxt.Name = "ASCIITxt";
            ASCIITxt.Size = new Size(50, 20);
            ASCIITxt.TabIndex = 60;
            ASCIITxt.Text = "label1";
            ASCIITxt.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ASCIITxt);
            panel1.Controls.Add(AppName);
            panel1.Controls.Add(ASCIILbl);
            panel1.Controls.Add(TextLbl);
            panel1.Controls.Add(OutputTxt);
            panel1.Controls.Add(StringTb);
            panel1.Controls.Add(OutputLbl);
            panel1.Controls.Add(NumLbl);
            panel1.Controls.Add(CbSortOutput);
            panel1.Controls.Add(NumTb);
            panel1.Controls.Add(CbReturnInput);
            panel1.Controls.Add(StartBtn);
            panel1.Controls.Add(NNullLbl);
            panel1.Controls.Add(SErrorLbl);
            panel1.Controls.Add(SNullLbl);
            panel1.Controls.Add(NumErrLbl);
            panel1.Location = new Point(166, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 398);
            panel1.TabIndex = 61;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(192, 192, 194);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(136, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 486);
            panel2.TabIndex = 62;
            panel2.Paint += panel2_Paint_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 77, 198);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(843, 39);
            panel4.TabIndex = 65;
            panel4.Paint += panel4_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 194);
            button3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button3.Location = new Point(758, 5);
            button3.Name = "button3";
            button3.Size = new Size(33, 29);
            button3.TabIndex = 63;
            button3.Text = "[]";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 194);
            button2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button2.Location = new Point(797, 5);
            button2.Name = "button2";
            button2.Size = new Size(33, 29);
            button2.TabIndex = 62;
            button2.Text = "x";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 194);
            button1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            button1.Location = new Point(719, 5);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 61;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 31);
            label1.TabIndex = 61;
            label1.Text = "TEXT ENCODER";
            label1.Click += label1_Click_2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(140, 140, 140);
            panel3.Location = new Point(22, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(811, 425);
            panel3.TabIndex = 64;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(192, 192, 194);
            panel5.Location = new Point(-1, 698);
            panel5.Name = "panel5";
            panel5.Size = new Size(1186, 56);
            panel5.TabIndex = 63;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 180, 168);
            ClientSize = new Size(1182, 753);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel5;
    }
}
