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
    public partial class SobelParameters : Form
    {
        private Home _home;

        public SobelParameters()
        {
            InitializeComponent();
        }

        public SobelParameters(Home home)
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
                _home.ApplySobel(
                    (int) numericXOrder.Value, 
                    (int) numericYOrder.Value, 
                    (int) numericAperture.Value);
            }
        }
    }
}
