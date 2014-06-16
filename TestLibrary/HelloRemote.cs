using System;
using System.Runtime.Remoting.Messaging;

namespace TestLibrary
{
    public class HelloRemote : MarshalByRefObject
    {
        [OneWay]
        public void Say(string value)
        {
            doSay(value);
        }

        public delegate void doSayEventHandler(string value);
        public event doSayEventHandler doSay;
    }
}
