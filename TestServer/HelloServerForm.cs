using System;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Configuration;
using TestLibrary;

// http://drinking-masa.cocolog-nifty.com/blog/2012/10/net-remoting-00.html

namespace TestServer
{
    public partial class HelloServerForm : Form
    {
        private HelloRemote instanceHelloRemote;

        public HelloServerForm()
        {
            InitializeComponent();

            instanceHelloRemote = new HelloRemote();
            instanceHelloRemote.doSay += new HelloRemote.doSayEventHandler(instanceHelloRemote_Say);
        }

        private void HelloServerForm_Load(object sender, EventArgs e)
        {
            int portNo = int.Parse(ConfigurationManager.AppSettings.Get("PortNo"));
            ChannelServices.RegisterChannel(new TcpChannel(portNo), false);

            ObjRef oref = RemotingServices.Marshal(instanceHelloRemote, typeof(HelloRemote).Name);
        }

        private void HelloServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RemotingServices.Disconnect(instanceHelloRemote);
        }

        private void instanceHelloRemote_Say(string value)
        {
            Invoke(new SetSayDelegate(Say));
        }

        private delegate void SetSayDelegate(string value);

        private void Say(string value)
        {
            lblSay.Text = value;
        }
    }
}
