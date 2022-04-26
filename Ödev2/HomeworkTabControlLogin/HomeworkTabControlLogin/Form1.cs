using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTabControlLogin
{
    public partial class FrmLogin : Form
    {
        private enum TLoginType { LtMail, LtUsername }; //Mail ile giriş ve Kullanıcı adı ile giriş adında iki bölümden oluştuğu için Enum tipinde değişkenler tanımladık.
        //private TLoginType LoginType = TLoginType.LtMail;
        private TLoginType LoginType;

        //Kullanıcı adı ile giriş için gereken değişkenlerimizi const string şeklinde admin ve password değerleri alacak şekilde tanımladık (Örnek Veritabanı)

        private const string DbUsername = "admin";
        private const string DbPassword1 = "password";

        //Mail adresi ile giriş için gereken değişkenlerimizi const string şeklinde mail ve password değerleri alacak şekilde tanımladık (Örnek Veritabanı)

        private const string DbMailAddress = "mail";
        private const string DbPassword2 = "password";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void TabLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Eğer TabLogin, Mail ile Giriş seçiliyse indeksi 0 olur ve TLoginType' dan ürettiğimiz LoginType değerimiz LtMail' i aldı. Kullanıcı ile Giriş seçili olsaydı indeksi 1 olacaktı ve TLoginType' dan ürettiğimiz LoginType değerimiz LtUsername' i aldı.
            if (TabLogin.SelectedIndex == 0)
            {
                LoginType = TLoginType.LtMail;
            }
            else if (TabLogin.SelectedIndex==1)
            {
                LoginType = TLoginType.LtUsername;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Username, Password, MailAddress;

            if (LoginType == TLoginType.LtMail) //Eğer LoginType isimli değişken LtMail' e eşitse (Yani kullanıcı mail ile sisteme giriş yapmaya çalışıyorsa)
            {
                if (TxtMailAddress.Text.Trim() == "" || TxtPassword1.Text.Trim() == "") //TxtMailAddress boşsa veya TxtPassword1 boşsa (herhangi birisinin boş olması yeterli)
                {
                    MessageBox.Show("Mail adresi veya şifre boş olamaz");
                }
                else //Eğer boş değillerse
                {
                    MailAddress = TxtMailAddress.Text.Trim();
                    Password = TxtPassword1.Text.Trim();

                    if (DbMailAddress != MailAddress) //TxtMailAddress' teki MailAddress veritabanındaki DbMailAddress' e eşit değilse
                    {
                        MessageBox.Show("Giriş bilgileri hatalı");
                    }
                    else
                    {
                        if (DbPassword1 != Password) //TxtPassword1' deki Password veritabanındaki DbPassword' a eşit değilse
                        {
                            MessageBox.Show("Giriş bilgileri hatalı");
                        }
                        else
                        {
                            if (DbMailAddress == MailAddress && DbPassword1 == Password) //En son şart olarak hem mail hem de parola veritabanındaki değerlere eşitse
                            {
                                MessageBox.Show("Giriş başarılı");
                            }
                        }
                    }
                }
            }

            else //if(LoginType == TLoginType.LtUsername)
            {
                if (TxtUsername.Text.Trim() == "" || TxtPassword2.Text.Trim() == "") //TxtUsername boşsa veya TxtPassword2 boşsa (herhangi birisinin boş olması yeterli)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre boş olamaz");
                }
                else
                {
                    Username = TxtUsername.Text.Trim();
                    Password = TxtPassword2.Text.Trim();

                    if (DbUsername != Username) //TxtUsername' teki Username veritabanındaki DbUsername' e eşit değilse
                    {
                        MessageBox.Show("Giriş bilgileri hatalı");
                    }
                    else
                    {
                        if (DbPassword2 != Password) //TxtPassword2' deki Password veritabanındaki DbPassword' a eşit değilse
                        {
                            MessageBox.Show("Giriş bilgileri hatalı");
                        }
                        else
                        {
                            if (DbUsername==Username && DbPassword2==Password) // En son şart olarak hem kullanıcı adı hem de parola veritabanındaki değerlere eşitse
                            {
                                MessageBox.Show("Giriş başarılı");
                            }
                        }
                    }
                }
            }
        }
    }
}
