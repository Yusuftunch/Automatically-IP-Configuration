using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPConfig
{
    public partial class Network : Form
    {
        public Network()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Network_Load(object sender, EventArgs e)
        {
            richTextBox1.Select(0, 1);
        }
    }
}
