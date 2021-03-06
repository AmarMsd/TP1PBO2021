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
    public partial class menu2 : Form
    {
        List<dataBarang> barang = new List<dataBarang>();
        public menu2(string id)
        {
            InitializeComponent();
            nambah_barang();

            foreach (var data in this.barang)
            {
                if (data.getIdBarang.ToString() == id)
                {
                    tempat_produk.Controls.Add(detailPanel(data.getNamaBarang, data.getHarga, data.getIdBarang, data.getJenisProduk));
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            menu dua = new menu();
            this.Hide(); //agar ketika masuk ke menu, akan menghilang
            dua.Show(); //untuk menampilkan
        }
        void nambah_barang()
        {

            this.barang.Add(new dataBarang("Televisi", 900000, "1", "Elektronik"));
            this.barang.Add(new dataBarang("Roti Cane", 300000, "2", "Makanan"));
            this.barang.Add(new dataBarang("Pizza", 250000, "3", "Makanan"));
            this.barang.Add(new dataBarang("Deus", 100000, "4", "Pakaian"));

        }
        Panel detailPanel(string nama, int harga, string idbarang, string jenisproduk)
        {
            Panel p = new Panel();
            p.Width = 160;
            p.Height = 211;
            p.BackColor = System.Drawing.Color.Blue;
            Button tombol = addButton(idbarang.ToString());
            Label label = addLabel(nama);
            Label label2 = addLabel2(harga.ToString());
            p.Controls.Add(tombol);
            p.Controls.Add(label);
            p.Controls.Add(label2);
            return p;
        }
        Button addButton(string id)
        {

            Button p = new Button();
            /*p.Click += new System.EventHandler(this.detail);*/
            p.Name = id;
            p.Size = new Size(59, 31);
            p.Location = new System.Drawing.Point(40, 145);
            p.BackColor = System.Drawing.Color.White;
            p.Text = "Beli";

            return p;
        }
        Label addLabel(string nama)
        {
            Label p = new Label();
            p.Size = new Size(107, 17);
            p.Location = new System.Drawing.Point(20, 77);
            p.ForeColor = System.Drawing.Color.Black;
            p.Text = nama;

            return p;
        }

        Label addLabel2(string harga)
        {
            Label p = new Label();
            p.Size = new Size(107, 17);
            p.Location = new System.Drawing.Point(20, 110);
            p.ForeColor = System.Drawing.Color.Black;
            p.Text = harga;

            return p;
        }

        private void tempat_produk_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private Panel detailList()
        {

        }*/
    }
}
