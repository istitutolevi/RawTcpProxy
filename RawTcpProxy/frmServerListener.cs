using System;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawTcpProxy
{

    public partial class frmServerListener : Form
    {

        public frmServerListener()
        {
            InitializeComponent();
        }

        private TcpListener _listener;

        private async Task Listen()
        {
            _listener = new TcpListener(int.Parse(txtPort.Text));
            _listener.Start();
            while (true)
            {
                var tcpClient = await _listener.AcceptTcpClientAsync();
                frmServerAccept frmServerAccept = new frmServerAccept(tcpClient);
                frmServerAccept.Show();
            }
        }

        private async void btnListen_Click(object sender, EventArgs e)
        {
            await Listen();
        }
    }
}
