using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KatmanliMimari.Entity;

namespace KatmanliMimari.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogrenci1 = new Ogrenci
            {
                Ad = "Ali",
                Soyad = "Yılmaz",
                Bolum = "Bilgisayar Müh."
            };

            Egitmen egitmen1 = new Egitmen
            {
                Ad = "Bülent",
                Soyad = "Başyurt",
                Brans = "Yazılım",
                Maas = 5000,
                Mezuniyet="Bilgisayar Müh."
            };

            ogrenci1.NotHesapla();
        }
    }
}
