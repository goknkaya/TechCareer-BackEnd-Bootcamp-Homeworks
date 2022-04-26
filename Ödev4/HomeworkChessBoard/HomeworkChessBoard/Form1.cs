using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkChessBoard
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DrawBoard();
        }
        private void DrawBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Panel Pnl = new Panel();
                    Pnl.Name = "Panel_"+i+"_"+j;
                    Pnl.Size = new Size(100, 100);
                    Pnl.Location = new Point(i*100, j*100);
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Pnl.BackColor = Color.White;
                    }
                    else if (i % 2 == 0 || j % 2 == 0)
                    {
                        Pnl.BackColor = Color.Black;
                    }
                    Controls.Add(Pnl);
                }
            }
        }
    }
}
