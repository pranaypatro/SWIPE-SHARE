using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwipeShare
{
    class Receiver
    {
        public Receiver()
        {

        }

        string savingPath = "";
        public void SetPath()
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                savingPath = dlg.SelectedPath;
            }
        }

        public string GetIPAddress()
        {
            var host = System.Net.Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Exception");
        }

        public void PerformOperations(int port)
        {
            TcpListener tcpListener = new TcpListener(port);
            tcpListener.Start();

            Socket soc = tcpListener.AcceptSocket();
            Console.WriteLine("Hello... after AcceptSocket() method");
            Stream s = new NetworkStream(soc);
            StreamReader sr = new StreamReader(s);
            StreamWriter sw = new StreamWriter(s);
            try
            {

                ulong totalSize = Convert.ToUInt64(sr.ReadLine());
                int size = (int)totalSize;
                byte[] fileContentsByte = new byte[size];

                Console.WriteLine(size);
                s.Read(fileContentsByte, 0, size);
                var fileName = sr.ReadLine();
                var filePath = savingPath;

                File.WriteAllBytes(Path.Combine(filePath, fileName), fileContentsByte);
                MessageBox.Show("Transfer Completed");

            }
            catch (Exception e)
            {

                Console.WriteLine("Some Exception : " + e);

            }
            finally
            {

                s.Close();
                soc.Close();

            }
        }


    }
}
