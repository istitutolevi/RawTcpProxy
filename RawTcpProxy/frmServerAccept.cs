using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawTcpProxy
{
    public partial class frmServerAccept : Form
    {

        private readonly TcpClient _sourceConnection;
        private StreamReader _sourceConnectionReader;
        private StreamWriter _sourceConnectionWriter;

        private TcpClient _targetConnection;
        private StreamReader _targetConnectionReader;
        private StreamWriter _targetConnectionWriter;

        /// <summary>
        /// Crea una nuova istanza della classe ed imposta il client che ha richiesto la connessione
        /// </summary>
        /// <param name="tcpClient">Client che ha richiesto la connessione</param>
        public frmServerAccept(TcpClient tcpClient)
        {
            InitializeComponent();
            _sourceConnection = tcpClient;
        }

        private async void frmServerAccept_Load(object sender, EventArgs e)
        {
            await Accept();
        }

        private async Task Accept()
        {
            // Creo gli stream di lettura e scrittura della connesione
            _sourceConnectionReader = new StreamReader(_sourceConnection.GetStream());
            _sourceConnectionWriter = new StreamWriter(_sourceConnection.GetStream());
            _sourceConnectionWriter.AutoFlush = true;

            string request;
            while ((request = await _sourceConnectionReader.ReadLineAsync()) != null)
            {
                txtClientInput.Text += request + "\r\n";
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            await ConnectTarget();
        }

        private async Task ConnectTarget()
        {
            _targetConnection = new TcpClient(txtServer.Text, int.Parse(txtPort.Text));
            
            // Creo gli stream di lettura e scrittura della connesione
            _targetConnectionReader = new StreamReader(_targetConnection.GetStream());
            _targetConnectionWriter = new StreamWriter(_targetConnection.GetStream());
            _targetConnectionWriter.AutoFlush = true;

            string request;
            while ((request = await _targetConnectionReader.ReadLineAsync()) != null)
            {
                txtServerInput.Text += request + "\r\n";
            }
        }

        private void btnSendToClient_Click(object sender, EventArgs e)
        {
            _sourceConnectionWriter.Write(txtServerInput.Text.Replace("\r\n", "\n"));
            txtServerInput.Clear();
        }

        private void btnSendToServer_Click(object sender, EventArgs e)
        {
            _targetConnectionWriter.Write(txtClientInput.Text.Replace("\r\n", "\n"));
            txtClientInput.Clear();
        }
    }

}
