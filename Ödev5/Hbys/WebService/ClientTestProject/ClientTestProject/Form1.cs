using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientTestProject.TokenServiceReference;

namespace ClientTestProject
{
    public partial class Form1 : Form
    {
        private TokenSoapClient tokenSoapClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGetToken_Click(object sender, EventArgs e)
        {
            if (tokenSoapClient == null)
                tokenSoapClient = new TokenSoapClient();

            string OMessage;

            string Token = tokenSoapClient.GetToken(TxtApiKey.Text, TxtSecretKey.Text, TxtUsername.Text, TxtPassword.Text, out OMessage);

            if (Token == "")
            {
                MessageBox.Show("Token alınamadı");
            }
            else
            {
                MessageBox.Show("Token alındı, token değeri:" + Token);
                TxtToken.Text = Token;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tokenSoapClient == null)
                tokenSoapClient = new TokenSoapClient();

            string ServerDateTime = tokenSoapClient.GetNow();

            MessageBox.Show(ServerDateTime);
        }

        private void BtnGetDoctorApointments_Click(object sender, EventArgs e)
        {
            if (tokenSoapClient == null)
                tokenSoapClient = new TokenSoapClient();

            List<VwDoctorsApointment> DoctorsApointment = tokenSoapClient.GetDoctorsApointments(TxtSecretKey.Text, TxtToken.Text).ToList();

            DataGridViewDoctorApointments.DataSource = DoctorsApointment;

        }
    }
}
