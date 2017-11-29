using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnsform
{
    class GoogleSafeSearch
    {
        public static void googlesafesearch()
        {
            string Reply = new WebClient().DownloadString("http://admin.appguardian.co/peerfy/hosts");
            string google = @"C:\Windows\System32\drivers\etc\hosts";
            File.WriteAllText(google, Reply);
            MessageBox.Show("se modifico el host");
        }
    }
}
