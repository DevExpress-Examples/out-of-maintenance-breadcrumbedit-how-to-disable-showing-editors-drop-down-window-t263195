using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication25 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            customBreadCrumbEdit1.Properties.AllowDropDownButtonSelectedState = checkEdit1.Checked;
        }
    }
}
