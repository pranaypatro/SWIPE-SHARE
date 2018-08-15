using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwipeShare
{
    class Sender
    {
        public Sender(string ipAdd)
        {
            var dlg = new OpenFileDialog();
            var onlyFileName = "";
            string filePath = "";
            string ip = ipAdd;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePath = dlg.FileName;
                onlyFileName = Path.GetFileName(dlg.FileName);
            }

            PerformOperation(ip, 9518, filePath, onlyFileName);
        }

        private void PerformOperation(string ip, int port, string filePath, string fileName)
        {
            TcpClient client = new TcpClient(ip, port);
            NetworkStream s = client.GetStream();
            try
            {
                StreamReader sr = new StreamReader(s);
                StreamWriter sw = new StreamWriter(s);
                sw.AutoFlush = false;
                byte[] fileContentsByte = ReadFile(filePath);
                int totalSize = fileContentsByte.Length;
                // Console.WriteLine(totalSize);
                //int initialSize = 0;
                sw.WriteLine(totalSize);
                sw.Flush();


                s.Write(fileContentsByte, 0, totalSize);
                s.Flush();

                sw.WriteLine(fileName);
                sw.Flush();

            }
            catch (Exception e)
            {
                Console.WriteLine("Some Exception : " + e);
            }
            finally
            {
                s.Close();
                client.Close();
            }
        }

        private byte[] ReadFile(String fileName)
        {
            return File.ReadAllBytes(fileName);
        }

    }
}
