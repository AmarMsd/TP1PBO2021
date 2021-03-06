using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class form_login : Form
    {
        string username_str;
        string password_str;

        public form_login()
        {
            InitializeComponent();
        }

        /*private void button_login(object sender, EventArgs e)
        {
            this.username_str = username.Text;
            this.password_str = password.Text;
            if (this.username_str != null && this.password_str == "pbo123")
            {
                menu dua = new menu();
                dua.Show();
            }
        }*/

        private void username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }

        /*private void button_login_Click(object sender, EventArgs e)
        {
            this.username_str = username.Text;
            this.password_str = password.Text;
            if (this.username_str != null && this.password_str == "pbo123")
            {
                menu dua = new menu();
                this.Hide(); //agar ketika masuk ke menu, akan menghilang
                dua.Show(); //untuk menampilkan
            }
            else
            {
                MessageBox.Show("Akun Tidak Terdaftar");
            }
        }*/

        private void button_login_Click_1(object sender, EventArgs e)
        {
            this.username_str = username.Text;
            this.password_str = password.Text;
            if (this.username_str != null && this.password_str == "pbo123")
            {
                menu dua = new menu();
                this.Hide(); //agar ketika masuk ke menu, akan menghilang
                dua.Show(); //untuk menampilkan
            }
            else
            {
                MessageBox.Show("Akun Tidak Terdaftar");
            }
        }
    }
}
