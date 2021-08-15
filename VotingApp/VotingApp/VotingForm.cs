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
    public partial class VotingForm : Form
    {
        public static int user_id = 0;
        DAL  dal = new DAL();
        public VotingForm()
        {
            InitializeComponent();
        }

        private void VotingForm_Load(object sender, EventArgs e)
        {
            cbxKategoriler.DataSource = dal.Table(dal.Command("Select * From Kategoriler"));
            cbxKategoriler.DisplayMember = "KategoriAdi";
            cbxKategoriler.ValueMember = "Id";
            cbxKategoriler.SelectedIndex = -1;
            cbxKategoriler.Refresh();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbxKategoriler.SelectedIndex<0)
            {
                MessageBox.Show("Kategori Seçiniz");
                return;
            }

            if (cbxPuan.SelectedIndex<0)
            {
                MessageBox.Show("Puan Seçiniz");
                return;
            }
            DataTable vote = dal.Table(dal.Command($"Select * From Votes WHERE UserId={user_id} AND KategoriId={cbxKategoriler.SelectedValue}"));
            if (vote.Rows.Count>0)
            {
                MessageBox.Show("Bu Kategoriye Daha Önce Oy Verdiniz.");
            }
            else
            {
                var command = dal.Command($"INSERT INTO Votes (UserId,KategoriId,Puan) VALUES ('{user_id}','{cbxKategoriler.SelectedValue}','{Convert.ToInt32(cbxPuan.Text)}') ");
                if (dal.ExecNQ(command))
                {
                    MessageBox.Show("Oyunuz Kaydedildi");
                    KategoriOrt(Convert.ToInt32(cbxKategoriler.SelectedValue));
                }
                else
                {
                    MessageBox.Show("Oyunuz Kaydedilemedi.");
                }
            }
        }


        public void KategoriOrt(int id)
        {
            DataTable table = dal.Table(dal.Command($"Select AVG(Puan),COUNT(Puan) From Votes WHERE KategoriId={id}"));
            lblPuan.Text = table.Rows[0][0].ToString();
           
        }

        private void cbxKategoriler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            KategoriOrt(Convert.ToInt32(cbxKategoriler.SelectedValue));
        }
    }
}
