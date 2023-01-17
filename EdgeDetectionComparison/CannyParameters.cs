using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgeDetectionComparison
{
    public partial class CannyParameters : Form
    {
        private Home _home;

        public CannyParameters()
        {
            InitializeComponent();
        }

        public CannyParameters(Home home)
        {
            InitializeComponent();
            _home = home;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_home != null)
            {
                _home.ApplyCanny((double)numericThreshold.Value, 
                    (double)numericThresholdLink.Value);
            }
        }
    }
}
