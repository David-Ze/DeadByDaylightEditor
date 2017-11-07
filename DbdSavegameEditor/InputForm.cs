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
    public partial class InputForm : Form {
        public InputForm(string default_val, string descr = "") {
            InitializeComponent();
            input_fld.Text = default_val;
            input_fld.Focus();
            if(descr.Length >= 1) {
                label1.Text = descr;
            }
        }

        public string GetResult() {
            if(did_save) {
                return input_fld.Text;
            }
            else {
                return null;
            }            
        }

        private void cancel_btn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e) {
            did_save = true;
            this.Close();
        }

        private bool did_save = false;
    }
}
