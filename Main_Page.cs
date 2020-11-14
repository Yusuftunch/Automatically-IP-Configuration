using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;
using Microsoft.Win32;
using System.Net;

namespace IPConfig
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        public void SetDHCP(string networkInterfaceName) //set auto ip, DHCP
        {
            var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(nw => nw.Name == networkInterfaceName);
            var ipProperties = networkInterface.GetIPProperties();
            var ipInfo = ipProperties.UnicastAddresses.FirstOrDefault(ip => ip.Address.AddressFamily == AddressFamily.InterNetwork);
            var currentIPaddress = ipInfo.Address.ToString();
            var currentSubnetMask = ipInfo.IPv4Mask.ToString();
            var isDHCPenabled = ipProperties.GetIPv4Properties().IsDhcpEnabled;

            if (isDHCPenabled)
                return;   // no change necessary
            var process = new Process
            {
                StartInfo = new ProcessStartInfo("netsh", $"interface ip set address \"{networkInterfaceName}\" dhcp") { Verb = "runas" }
            };

            process.Start();
            process.WaitForExit();
            if (process.ExitCode == 0) MessageBox.Show("Successfully has been changed!"); else MessageBox.Show("It has not been done! Unplugged !");
        }

        public void SetIP(string networkInterfaceName, string ipAddress, string subnetMask, string gateway = null)
        {//set any ip and the other network adapto settings..
            var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(nw => nw.Name == networkInterfaceName);
            var ipProperties = networkInterface.GetIPProperties();
            var ipInfo = ipProperties.UnicastAddresses.FirstOrDefault(ip => ip.Address.AddressFamily == AddressFamily.InterNetwork);
            var currentIPaddress = ipInfo.Address.ToString();
            var currentSubnetMask = ipInfo.IPv4Mask.ToString();
            var isDHCPenabled = ipProperties.GetIPv4Properties().IsDhcpEnabled;

            if (!isDHCPenabled && currentIPaddress == ipAddress && currentSubnetMask == subnetMask)
                return;   // no change necessary

            var process = new Process
            {
                StartInfo = new ProcessStartInfo("netsh", $"interface ip set address \"{networkInterfaceName}\" static {ipAddress} {subnetMask}" + (string.IsNullOrWhiteSpace(gateway) ? "" : $"{gateway} 1")) { Verb = "runas" }
            };
            process.Start();
            process.WaitForExit();
            if (process.ExitCode == 0) MessageBox.Show("Successfully has been changed!"); else MessageBox.Show("It has not been done! Unplugged !");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\records.xml"))
            kayit=Deserialize(Application.StartupPath + "\\records.xml");
            for (int i=0;i<kayit.Count;i++)
            {
                setting_listbox.Items.Add(kayit.ElementAt(i).record_name);
            }

            if (acilisa_eklendi_mi()) startWithWindowsToolStripMenuItem.Text = "Cancel Start UP with Windows";
            else
                startWithWindowsToolStripMenuItem.Text = "Start with Windows Start Up";
        }

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
                    record_submask = yeni_ip.subnet_textBox.Text,
                    record_gateway = yeni_ip.gateway_textBox.Text,
                    record_DHCP = yeni_ip.auto_checkBox.Checked
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
            yeni_ip.gateway_textBox.Text = kayit.ElementAt(selected).record_gateway;
            yeni_ip.auto_checkBox.Checked = kayit.ElementAt(selected).record_DHCP;
            if (!kayit.ElementAt(selected).record_DHCP) yeni_ip.DHCP_goster(); else yeni_ip.DHCP_gizle();

            yeni_ip.ShowDialog();
            if (yeni_ip.DialogResult == DialogResult.OK)
            {
                kayit.ElementAt(selected).record_name = yeni_ip.ipsetname_textBox.Text;
                kayit.ElementAt(selected).record_adaptor = yeni_ip.network_adaptor_listBox.GetItemText(yeni_ip.network_adaptor_listBox.SelectedItem);
                kayit.ElementAt(selected).record_ip = yeni_ip.ip_textBox.Text;
                kayit.ElementAt(selected).record_gateway = yeni_ip.gateway_textBox.Text;
                kayit.ElementAt(selected).record_submask = yeni_ip.subnet_textBox.Text;
                kayit.ElementAt(selected).record_DHCP = yeni_ip.auto_checkBox.Checked;
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

            var res = MessageBox.Show(this,"Named as '"+ setting_listbox.GetItemText(setting_listbox.SelectedItem)+"' record will be deleted, do you confirm?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                kayit.RemoveAt(selected);
                setting_listbox.Items.RemoveAt(selected);
            }
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
                if (kayit.ElementAt(selected).record_DHCP) { SetDHCP(kayit.ElementAt(selected).record_adaptor); }

                else
                    SetIP(kayit.ElementAt(selected).record_adaptor, kayit.ElementAt(selected).record_ip, kayit.ElementAt(selected).record_submask, kayit.ElementAt(selected).record_gateway);
            } catch (Exception hata)
            {
                MessageBox.Show(this, hata.ToString(), "Exception !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static void Serialize(List<kaydim> data, string dosya)
        {
            FileStream fs = new FileStream(dosya, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<kaydim>));
            serializer.Serialize(fs, data);
            fs.Close();
        }

        static List<kaydim> Deserialize(string dosya)
        {
            FileStream fs = new FileStream(dosya, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(List<kaydim>));
            List<kaydim> liste = (List<kaydim>)xs.Deserialize(fs);
            fs.Close();
            return liste;
        }

        private void savetofile()
        {
            Serialize(kayit, Application.StartupPath + "\\records.xml");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Serialize(kayit, Application.StartupPath + "\\Records.xml");
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

        public class kaydim
        {
            public string record_name { get; set; }
            public string record_ip { get; set; }
            public string record_adaptor { set; get; }
            public string record_gateway { get; set; }
            public string record_submask { get; set; }
            public bool record_DHCP { get; set; }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "XML Data Base File (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                if (saveFileDialog1.FileName.Contains(".xml"))
                Serialize(kayit, saveFileDialog1.FileName); else Serialize(kayit, saveFileDialog1.FileName+".xml");
            }
        }

        private void ımportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter= "XML Data Base File (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName!="")
            {
                if (File.Exists(openFileDialog1.FileName))
                kayit = Deserialize(openFileDialog1.FileName);
                setting_listbox.Items.Clear();
                for (int i = 0; i < kayit.Count; i++)
                {
                    setting_listbox.Items.Add(kayit.ElementAt(i).record_name);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newrecord();
            savetofile();
        }

        private void editSelectedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editselected();
            savetofile();
        }

        private void deleteSelectedItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteseleceted();
            savetofile();
        }

        private void applyForSelectedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applyselected();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About hakkimda = new About();
            hakkimda.ShowDialog();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            bool cursornotinbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && cursornotinbar)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "Info", "Working in background", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applyselected();
        }

        private void startWithWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acilisa_eklendi_mi()) acilistan_kaldır(); else acilisa_ekle();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void acilisa_ekle()
        {
            string ProgramAdi = Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location);
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
                startWithWindowsToolStripMenuItem.Text = "Cancel Start UP with Windows";
            }
            
        }

        public void acilistan_kaldır()
        {
            string ProgramAdi = Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location);
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.DeleteValue(ProgramAdi, false);
                startWithWindowsToolStripMenuItem.Text = "Start with Windows Start Up";
            }
        }

        private bool acilisa_eklendi_mi()
        {
            string ProgramAdi = Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location);
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                     ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (registryKey.GetValue(ProgramAdi) != null)
            {
                return true;
            }
            return false;
        }

        public void DisplayUpNetworkConnectionsInfo(OperationalStatus durum,string texts)
        {
            Network yeni_sayfa = new Network();
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            yeni_sayfa.label4.Text = texts;
            int no = 0;
            foreach (NetworkInterface adapter in adapters.Where(a => a.OperationalStatus == durum))
            {
                no++;
                yeni_sayfa.richTextBox1.AppendText(no.ToString());
                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                
                yeni_sayfa.richTextBox1.AppendText("Network Name :" + adapter.Name);

                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                yeni_sayfa.richTextBox1.AppendText("Network Description: " + adapter.Description);

                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                yeni_sayfa.richTextBox1.AppendText("Network ID : " + adapter.Id);

                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                yeni_sayfa.richTextBox1.AppendText("Network Interfacetype : " + adapter.NetworkInterfaceType);

                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                try
                {
                    yeni_sayfa.richTextBox1.AppendText("Network IPV4 :");
                    IPAddress ipv4Address = adapter.GetIPProperties().UnicastAddresses[3].Address;
                    yeni_sayfa.richTextBox1.AppendText(ipv4Address.ToString());
                }
                catch { }
                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                try
                {
                    yeni_sayfa.richTextBox1.AppendText("Getaway Address :");
                    IPAddress bakalim = adapter.GetIPProperties().DnsAddresses[0];
                    yeni_sayfa.richTextBox1.AppendText(bakalim.ToString());
                }
                catch { }

                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                IPAddress ipv6Address = adapter.GetIPProperties().UnicastAddresses[0].Address;
                yeni_sayfa.richTextBox1.AppendText("Network IPV6 : " + ipv6Address.ToString());
                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
            }

            yeni_sayfa.ShowDialog();
        }

        private void all_adaptors()
        {
            Network yeni_sayfa = new Network();
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            yeni_sayfa.label4.Text = "All network adaptors on this PC";
            int no = 0;
            foreach (NetworkInterface adapter in adapters.Where(a => a.OperationalStatus == a.OperationalStatus))
            {
                no++;
                yeni_sayfa.richTextBox1.AppendText(no.ToString());
                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);

                yeni_sayfa.richTextBox1.AppendText("Network Name :" + adapter.Name);

                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                yeni_sayfa.richTextBox1.AppendText("Network Description: " + adapter.Description);

                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                yeni_sayfa.richTextBox1.AppendText("Network ID : " + adapter.Id);

                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                yeni_sayfa.richTextBox1.AppendText("Network Interfacetype : " + adapter.NetworkInterfaceType);

                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                try
                {
                    yeni_sayfa.richTextBox1.AppendText("Network IPV4 :");
                    IPAddress ipv4Address = adapter.GetIPProperties().UnicastAddresses[3].Address;
                    yeni_sayfa.richTextBox1.AppendText(ipv4Address.ToString());
                }
                catch { }
                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                try
                {
                    yeni_sayfa.richTextBox1.AppendText("Getaway Address :");
                    IPAddress bakalim = adapter.GetIPProperties().DnsAddresses[0];
                    yeni_sayfa.richTextBox1.AppendText(bakalim.ToString());
                }
                catch { }

                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                IPAddress ipv6Address = adapter.GetIPProperties().UnicastAddresses[0].Address;
                yeni_sayfa.richTextBox1.AppendText("Network IPV6 : " + ipv6Address.ToString());
                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
                yeni_sayfa.richTextBox1.AppendText(Environment.NewLine);
            }

            yeni_sayfa.ShowDialog();
        }

        private void disconnectedNetworkAdaptorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayUpNetworkConnectionsInfo(OperationalStatus.Down, "All network adaptors which disconnected in this PC");
        }

        private void connectedNetworkAdaptorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUpNetworkConnectionsInfo(OperationalStatus.Up, "All network adaptors which connected in this PC");
        }

        private void allNetworkAdaptorsPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            all_adaptors();
        }
    }
}

