using System;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Configuration;
using TestLibrary;

namespace TestClient
{
    public partial class HelloClientForm : Form
    {
        public HelloClientForm()
        {
            InitializeComponent();
        }

        private void HelloClientForm_Load(object sender, EventArgs e)
        {
            ChannelServices.RegisterChannel(new TcpChannel(), false);
            
            string host = ConfigurationManager.AppSettings.Get("host");
            string portNo = ConfigurationManager.AppSettings.Get("PortNo");
            string objectUri = "tcp://" +
                                host + ":" +
                                portNo + "/" +
                                typeof(HelloRemote).Name;

            RemotingConfiguration.RegisterWellKnownClientType(typeof(HelloRemote), objectUri);
        }

        private void cmdSay_Click(object sender, EventArgs e)
        {
            HelloRemote remoteObject = new HelloRemote();
            remoteObject.Say(textSay.Text);
        }
    }
}
