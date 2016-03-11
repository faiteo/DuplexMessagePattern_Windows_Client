using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.Globalization;

namespace DuplexMessagePattern_Client
{
    public partial class Form1 : Form, Update_ServiceReference.IUpdateServiceCallback
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            Update_ServiceReference.UpdateServiceClient client = new Update_ServiceReference.UpdateServiceClient(instanceContext);
            client.ProcessUpdate();
        }

        public void Update(int currentValue)
        {

           lstBoxUpdateValue.Items.Add("@ " + "Date:" + DateTime.Now.Date.ToShortDateString() + "    " + "Time:" + DateTime.Now.ToString("HH:mm:ss tt") + "   " + " Current Value: " + currentValue.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
