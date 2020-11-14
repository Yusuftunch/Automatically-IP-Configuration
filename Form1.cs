using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Xml.Linq;

namespace IPConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool SetIP(string networkInterfaceName, string ipAddress, string subnetMask, string gateway = null)
        {
            var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(nw => nw.Name == networkInterfaceName);
            var ipProperties = networkInterface.GetIPProperties();
            var ipInfo = ipProperties.UnicastAddresses.FirstOrDefault(ip => ip.Address.AddressFamily == AddressFamily.InterNetwork);
            var currentIPaddress = ipInfo.Address.ToString();
            var currentSubnetMask = ipInfo.IPv4Mask.ToString();
            var isDHCPenabled = ipProperties.GetIPv4Properties().IsDhcpEnabled;

            if (!isDHCPenabled && currentIPaddress == ipAddress && currentSubnetMask == subnetMask)
                return true;    // no change necessary

            var process = new Process
            {
                StartInfo = new ProcessStartInfo("netsh", $"interface ip set address \"{networkInterfaceName}\" static {ipAddress} {subnetMask}" + (string.IsNullOrWhiteSpace(gateway) ? "" : $"{gateway} 1")) { Verb = "runas" }
            };
            process.Start();
            bool sonuc = false;
            process.WaitForExit();
            if (process.ExitCode == 0) sonuc = true;
            process.Dispose();
            return sonuc;
        }

       

        public bool SetDHCP(string networkInterfaceName)
        {
            var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(nw => nw.Name == networkInterfaceName);
            var ipProperties = networkInterface.GetIPProperties();
            var ipInfo = ipProperties.UnicastAddresses.FirstOrDefault(ip => ip.Address.AddressFamily == AddressFamily.InterNetwork);
            var currentIPaddress = ipInfo.Address.ToString();
            var currentSubnetMask = ipInfo.IPv4Mask.ToString();
            var isDHCPenabled = ipProperties.GetIPv4Properties().IsDhcpEnabled;

            if (isDHCPenabled)
                return true;    // no change necessary

            var process = new Process
            {
                StartInfo = new ProcessStartInfo("netsh", $"interface ip set address \"{networkInterfaceName}\" dhcp") { Verb = "runas" }
            };

            process.Start();
            bool sonuc = false;
            process.WaitForExit();
            if (process.ExitCode == 0) sonuc = true;
            process.Dispose();
            MessageBox.Show("Unplugged adaptor can not be changed to DHCP (auto)");
            return sonuc;
        }



        //public bool SetDHCP(string networkInterfaceName)
        //{
        //    var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(nw => nw.Name == networkInterfaceName);
        //    var ipProperties = networkInterface.GetIPProperties();
        //    var isDHCPenabled = ipProperties.GetIPv4Properties().IsDhcpEnabled;

        //    if (isDHCPenabled)
        //        return true;    // no change necessary

        //    var process = new Process
        //    {
        //        StartInfo = new ProcessStartInfo("netsh", $"interface ip set address \"{networkInterfaceName}\" dhcp") { Verb = "runas" }
        //    };
        //    process.Start();
        //    process.WaitForExit();
        //    var successful = process.ExitCode == 0;
        //    process.Dispose();
        //    return successful;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //NetworkInterface[] arayuzler = NetworkInterface.GetAllNetworkInterfaces();
            //listBox1.Items.Clear();
            //for (int i = 0; i < arayuzler.Length; i++)
            //listBox1.Items.Add(arayuzler[i].Name);
        }

        List<string> set_names = new List<string>();
        List<string> adaptor_list = new List<string>();
        List<string> ip_list = new List<string>();
        List<string> gateway_list = new List<string>();
        List<string> submask_list = new List<string>();
        List<bool> DHCP_list = new List<bool>();

        List<kaydim> kayit = new List<kaydim>();

        private void newrecord()
        {
            Yeni yeni_ip = new Yeni();
            yeni_ip.ShowDialog();
            if (yeni_ip.DialogResult == DialogResult.OK)
            {
                kayit.Add(new kaydim
                {
                    record_name = yeni_ip.ipsetname_textBox.Text,
                    record_adaptor = yeni_ip.network_adaptor_listBox.GetItemText(yeni_ip.network_adaptor_listBox.SelectedItem),
                    record_ip = yeni_ip.ip_textBox.Text,
                    record_submask= yeni_ip.gateway_textBox.Text,
                    record_gateway= yeni_ip.subnet_textBox.Text,
                    record_DHCP= yeni_ip.auto_checkBox.Checked
                }
                );
                setting_listbox.Items.Add(yeni_ip.ipsetname_textBox.Text);
                MessageBox.Show("Successfully saved !", "Info");
            }
        }

        private void editselected()
        {
            int selected = setting_listbox.SelectedIndex;
            if (selected < 0)
            {
                MessageBox.Show(this, "Please select a settings name in the listbox !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Yeni yeni_ip = new Yeni();

            yeni_ip.ipsetname_textBox.Text = kayit.ElementAt(selected).record_name;
            yeni_ip.network_adaptor_listBox.SetSelected(yeni_ip.network_adaptor_listBox.FindString(kayit.ElementAt(selected).record_adaptor), true);
            yeni_ip.ip_textBox.Text = kayit.ElementAt(selected).record_ip;
            yeni_ip.subnet_textBox.Text = kayit.ElementAt(selected).record_submask;
            yeni_ip.gateway_textBox.Text = gateway_list[selected];
            yeni_ip.auto_checkBox.Checked = DHCP_list[selected];
            if (!DHCP_list[selected]) yeni_ip.DHCP_goster(); else yeni_ip.DHCP_gizle();

            yeni_ip.ShowDialog();
            if (yeni_ip.DialogResult == DialogResult.OK)
            {
                set_names[selected] = yeni_ip.ipsetname_textBox.Text;
                adaptor_list[selected] = yeni_ip.network_adaptor_listBox.GetItemText(yeni_ip.network_adaptor_listBox.SelectedItem);
                ip_list[selected] = yeni_ip.ip_textBox.Text;
                gateway_list[selected] = yeni_ip.gateway_textBox.Text;
                submask_list[selected] = yeni_ip.subnet_textBox.Text;
                setting_listbox.Items[selected] = yeni_ip.ipsetname_textBox.Text;
            }
        }

        private void deleteseleceted()
        {
            int selected = setting_listbox.SelectedIndex;
            if (selected < 0)
            {
                MessageBox.Show(this, "Please select a settings name in the listbox !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            kayit.RemoveAt(selected);
            setting_listbox.Items.RemoveAt(selected);

        }

        private void applyselected()
        {
            int selected = setting_listbox.SelectedIndex;
            if (selected < 0)
            {
                MessageBox.Show(this, "Please select a settings name in the listbox !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (DHCP_list[selected]) SetDHCP(adaptor_list[selected]);
                else
                    SetIP(adaptor_list[selected], ip_list[selected], submask_list[selected], gateway_list[selected]);
            } catch (Exception hata)
            {
                MessageBox.Show(this, hata.ToString(), "Exception !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void savetofile()
        {
            var xmlSavePath = new XElement("Records",
            from emp in kayit
            select new XElement(emp.record_name,
                   new XElement("name", emp.record_adaptor),
                   new XElement("ip", emp.record_ip),
                   new XElement("submask", emp.record_submask),
                   new XElement("gateway", emp.record_gateway),
                   new XElement("DHCP",emp.record_DHCP)
               ));
            xmlSavePath.Save(Application.StartupPath+"\\records.xml");
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            newrecord();
            savetofile();
        }

        private void setting_listbox_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(setting_listbox.GetItemText(setting_listbox.SelectedItem));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editselected();
            savetofile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteseleceted();
            savetofile();
        }

        private void newIPSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newrecord();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editselected();
        }

        private void deleteSelectedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteseleceted();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            applyselected();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savetofile();
        }



    }

    public class kaydim
    {
        public string record_name { get; set; }
        public string record_ip { get; set; }
        public string record_adaptor { set; get; }
        public string record_gateway { get; set; }
        public string record_submask { get; set; }
        public bool record_DHCP { get; set; }
    }
}
