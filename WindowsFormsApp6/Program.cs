using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Girlen_EnBuyukEnKucuk
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void btnBul_Click(object sender, EventArgs e)
            {
                int sayi1, sayi2, sayi3, enBuyuk, enKucuk;
                sayi1 = Convert.ToInt32(txtSayi1.Text);
                sayi2 = Convert.ToInt32(txtSayi2.Text);
                sayi3 = Convert.ToInt32(txtSayi3.Text);

                //En Büyük Sayıyı Bulma
                if (sayi1 > sayi2 && sayi1 > sayi3)
                    enBuyuk = sayi1;
                else if (sayi2 > sayi3 && sayi2 > sayi1)
                    enBuyuk = sayi2;
                else
                    enBuyuk = sayi3;



                if (sayi1 < sayi2 && sayi1 < sayi3)
                    enKucuk = sayi1;
                else if (sayi2 < sayi3 && sayi2 < sayi1)
                    enKucuk = sayi2;
                else
                    enKucuk = sayi3;


                txtEnBuyuk.Text = enBuyuk.ToString();
                txtEnKucuk.Text = enKucuk.ToString();

            }
        }
    }
}
}
