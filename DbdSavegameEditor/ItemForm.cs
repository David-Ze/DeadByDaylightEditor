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
    public partial class ItemForm : Form {
        public ItemForm(string default_val, string descr = "") {
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
            if(input_fld.Text.Length > 0) did_save = true;
            this.Close();
        }

        private bool did_save = false;

        private void select_item(object sender, EventArgs e) {
            string curItem = ((ListBox)sender).SelectedItem.ToString();
            string[] tokens = curItem.Split(' ');
            input_fld.Text = tokens[0];
        }
    }
}
