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
    public partial class NumberForm : Form {
        public NumberForm(string default_val) {
            InitializeComponent();
            int cur_num = int.Parse(default_val);
            int new_max = System.Math.Max(cur_num, this.input_slider.Maximum);
            input_slider.Maximum = new_max;
            input_slider.Value = int.Parse(default_val);
            amount_label.Text = "" + input_slider.Value;
            input_slider.Focus();
        }

        public string GetResult() {
            if(did_save) {
                return ""+input_slider.Value;
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

        private void input_slider_Scroll(object sender, EventArgs e) {
            amount_label.Text = ""+input_slider.Value;
        }
        
        private void amount_label_TextChanged(object sender, EventArgs e) {
            int val = 0;
            if(Int32.TryParse(amount_label.Text, out val)) {
                input_slider.Value = Math.Min(val,input_slider.Maximum);
                amount_label.Text = "" + input_slider.Value;
            }            
        }
    }
}
