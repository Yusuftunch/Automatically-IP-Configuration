using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Net;

namespace IPConfig
{
    public partial class Yeni : Form
    {
        public Yeni()
        {
            InitializeComponent();
            network_adaptor_list();
        }

        private void network_adaptor_list()
        {
            network_adaptor_listBox.Items.Clear();
            NetworkInterface[] arayuzler = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < arayuzler.Length; i++)
                network_adaptor_listBox.Items.Add(arayuzler[i].Name);
        }

        public void DHCP_gizle()
        {
            ip_textBox.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            subnet_textBox.Visible = false;
            label4.Visible = false;
            gateway_textBox.Visible = false;
        }

        public void DHCP_goster()
        {
            ip_textBox.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            subnet_textBox.Visible = true;
            label4.Visible = true;
            gateway_textBox.Visible = true;
        } 

        private void auto_checkBox_Click(object sender, EventArgs e)
        {
            if (!auto_checkBox.Checked) DHCP_goster(); else DHCP_gizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void subnet_textBox_Enter(object sender, EventArgs e)
        {
            if (subnet_textBox.Text == "") subnet_textBox.Text = "255.255.255.0";
        }

        public static bool CheckIPValid(string strIP)
        {
            IPAddress result = null;
            return
                !String.IsNullOrEmpty(strIP) &&
                IPAddress.TryParse(strIP, out result);
        }

        private void ip_textBox_Leave(object sender, EventArgs e)
        {
            if (!CheckIPValid(ip_textBox.Text)) ip_textBox.BackColor = Color.Red;
            else
                ip_textBox.BackColor = Color.White;
        }

        private void subnet_textBox_Leave(object sender, EventArgs e)
        {
            if (!CheckIPValid(subnet_textBox.Text)) subnet_textBox.BackColor = Color.Red;
            else
                subnet_textBox.BackColor = Color.White;
        }

        private void gateway_textBox_Leave(object sender, EventArgs e)
        {
            if (!CheckIPValid(gateway_textBox.Text)) gateway_textBox.BackColor = Color.Red;
            else
                gateway_textBox.BackColor = Color.White;
        }

        private void ipsetname_textBox_Leave(object sender, EventArgs e)
        {
            if (ipsetname_textBox.Text != "") ipsetname_textBox.BackColor = Color.White; else ipsetname_textBox.BackColor = Color.Red;
        }
    }




}
