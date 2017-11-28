using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnsform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opendns_Click(object sender, EventArgs e)
        {
            dns.SetDNS("208.67.222.123,208.67.220.123");
            MessageBox.Show("Se cambiaron los Dns por los Open dns");
        }

        private void nortodns_Click(object sender, EventArgs e)
        {
            dns.SetDNS("199.85.126.30,199.85.127.30");
            MessageBox.Show("Se cambiaron los Dns por los Norton dns");
        }

        private void Originales_Click(object sender, EventArgs e)
        {
            dns.OriginalesNDS();
            MessageBox.Show("Se restablecieron por los dns de fabrica");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
