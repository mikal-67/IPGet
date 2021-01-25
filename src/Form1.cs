using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPGet
{
    public partial class GetForm : Form
    {
        public GetForm()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "")
                {
                    MessageBox.Show("You forgot the domain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IPHostEntry hostname = Dns.GetHostEntry(textBox1.Text);
                    IPAddress[] ip = hostname.AddressList;
                    IPV4Box.Text = ip[1].ToString();
                    IPV6Box.Text = ip[0].ToString();
                }
            }
            catch(System.Net.Sockets.SocketException)
            {
                MessageBox.Show("That domain is invalid or doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(IndexOutOfRangeException)
            {
                IPHostEntry hostname = Dns.GetHostEntry(textBox1.Text);
                IPAddress[] ip = hostname.AddressList;
                IPV4Box.Text = ip[0].ToString();
                IPV6Box.Text = "None";
            }
        }
    }
}
