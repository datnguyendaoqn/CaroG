using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CaroG.Manager
{
    public class SeverManager
    {
        #region Sever
        Socket Sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public void Createsever()
        {
            string address = IP;
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), 9999);
            Sever.Bind(ipep);
            Sever.Listen(10);
            Thread acceptclient = new Thread(() =>
            {
                Client = Sever.Accept();
            });
            acceptclient.IsBackground = true;
            acceptclient.Start();

        }
        #endregion
        #region Client
        Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public bool Connectsever()
        {
            string address = IP;
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), 9999);
            try
            {
                Client.Connect(ipep);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        #region Both
        public string IP = "";
        public bool IsSever;
        public object Receive()
        {
            byte[] databyte = new byte[1024];
            bool Isreceive = ReceiveData(Client, databyte);
            return Deserialize(databyte);

        }
        public bool Send(object data)
        {
            Byte[] databyte = Serialize(data);
            return SendData(Client, databyte);
        }
        public bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) == 1 ? true : false;
        }
        public bool ReceiveData(Socket target, byte[] buffer)
        {

            return target.Receive(buffer) == 1 ? true : false;

        }
        public object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            stream.Position = 0;

            return bf.Deserialize(stream);

        }
        public byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter data = new BinaryFormatter();
            data.Serialize(stream, obj);
            return stream.ToArray();
        }
        public string GetIPAddress(NetworkInterfaceType type)
        {
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation i in item.GetIPProperties().UnicastAddresses)
                    {
                        if (i.Address.AddressFamily == AddressFamily.InterNetwork)
                            return i.Address.ToString();
                    }
                }
            }
            return "";
        }
        #endregion

    }
}
