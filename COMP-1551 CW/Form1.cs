using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace COMP_1551_CW
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            string inputS = StringTb.Text;
            int numN;

            SNullLbl.Visible = false;
            NNullLbl.Visible = false;
            SErrorLbl.Visible = false;
            NumErrLbl.Visible = false;
            ASCIITxt.Visible = false;

            if (string.IsNullOrWhiteSpace(inputS))
            {
                SNullLbl.Visible = true;
                ASCIITxt.Visible = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(NumTb.Text))
            {
                NNullLbl.Visible = true;
                ASCIITxt.Visible = false;
                return;
            }

            if (!int.TryParse(NumTb.Text, out numN))
            {
                NumErrLbl.Visible = true;
                ASCIITxt.Visible = false;
            }


            if (!inputS.All(char.IsUpper) || inputS.Length > 40)
            {
                SErrorLbl.Visible = true;
                ASCIITxt.Visible = false;
                return;
            }

            if (!int.TryParse(NumTb.Text, out numN) || numN < -25 || numN > 25)
            {
                NumErrLbl.Visible = true;
                ASCIITxt.Visible = false;
                return;
            }


            StringProcessing processor = new StringProcessing(inputS, numN);
            string output = processor.Print();
            string ASCIIValues = "";


            if (CbReturnInput.Checked)
            {
                output = inputS;
                ASCIIValues = processor.InputCode(output);

                if (CbSortOutput.Checked)
                {
                    output = processor.SelectionSort(inputS);
                    ASCIIValues = processor.InputCode(output);
                }
            }
            else
            {
                output = processor.Print();
                ASCIIValues = processor.OutputCode();

                if (CbSortOutput.Checked)
                {
                    string decoderesult = processor.Print();
                    output = processor.SelectionSort(decoderesult);
                    ASCIIValues = processor.InputCode(output);
                }
            }

            OutputTxt.Visible = true;
            ASCIITxt.Visible = true;
            ASCIITxt.Text = ASCIIValues;
            OutputTxt.Text = output;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AppName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void NumErrLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

