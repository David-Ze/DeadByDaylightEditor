using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbdSavegameEditor {
    public partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();
        }
        
        private void cancel_btn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
