using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkCalculatorAdvance
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void DoSetOffButton()
        {
            foreach (Control BtnControl in PnlNumbers.Controls)
            {
                Button button = BtnControl as Button;
                button.Click += NumberButtonsClick;
                string Number = button.Name.Replace("Btn", "").Replace("Dot", ",");
                button.Text = Number;
            }
        }

        private void NumberButtonsClick(object sender, EventArgs e)
        {
            string ANumber = ((Button)sender).Text;
            DoAddTextIntoTxtResult(ANumber);
        }
        private void DoAddTextIntoTxtResult(string AKey)
        {
            if (AKey.Trim() == "")
                return;

            if (AKey == ",")
            {
                if (TxtResult.Text.IndexOf(",") > -1)
                    return;
                if (TxtResult.Text.Length == 0)
                    AKey = "0,";
            }

            if (TxtResult.Text == "0")
                TxtResult.Text = "0,";

            TxtResult.Text += AKey;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DoSetOffButton();
        }
    }
}
