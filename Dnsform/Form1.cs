using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using System.IO;
using System.Net;

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

        private void googlesafesearch_Click(object sender, EventArgs e)
        {
            GoogleSafeSearch.googlesafesearch();
        }

    }


}

