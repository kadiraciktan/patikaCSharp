using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp
{
    public partial class Form1 : Form
    {
        DAL dal = new DAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt =  dal.Table(dal.Command($"SELECT * FROM users WHERE UserName='{txtUserName.Text}' AND Password='{txtPassword.Text}'"));
            if (dt.Rows.Count>0)
            {
                VotingForm.user_id = int.Parse(dt.Rows[0]["Id"].ToString());
                VotingForm vf = new VotingForm();
                this.Hide();
                vf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Giriş Yapılamadı");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.Table(dal.Command($"SELECT * FROM users WHERE UserName='{txtUserName.Text}'"));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bu isimde bir kullanıcı var.");
            }
            else
            {
                if (dal.ExecNQ(dal.Command($"Insert Into Users (UserName,Password,Role) VALUES ('{txtUserName.Text}','{txtPassword.Text}','User')")))
                {

                    MessageBox.Show("Kayıt Başarılı! Giriş Yapabilirisiniz");
                }
                else
                {
                    MessageBox.Show("Kayıt Yapılamadı");
                }
            }
        }

  
    }
}
