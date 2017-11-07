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
    public partial class PrestigeForm : Form {
        public PrestigeForm(int char_lvl, int prestige_cnt, List<DateTime> prestige_dates, bool has_prestige) {
            InitializeComponent();
            levelSlider.Value = char_lvl;
            DateTime legacy_date = new DateTime(1, 1, 1, 0, 0, 0);
            if (prestige_cnt >= 1) {
                prestige1CheckBox.Checked = true;
                if(prestige_dates[0] == legacy_date) {
                    legacyP1CheckBox.Checked = true;
                }
                else {
                    prestige1Date.Value = prestige_dates[0];
                }
            }
            if (prestige_cnt >= 2) {
                prestige2CheckBox.Checked = true;
                if (prestige_dates[1] == legacy_date) {
                    legacyP2CheckBox.Checked = true;
                }
                else {
                    prestige2Date.Value = prestige_dates[1];
                }
            }
            if (prestige_cnt >= 3) {
                prestige3CheckBox.Checked = true;
                if (prestige_dates[2] == legacy_date) {
                    legacyP3CheckBox.Checked = true;
                }
                else {
                    prestige3Date.Value = prestige_dates[2];
                }
            }

            if(!has_prestige) {
                legacyP1CheckBox.Visible = false;
                legacyP2CheckBox.Visible = false;
                legacyP3CheckBox.Visible = false;
            }

            check_legacy_1(null, null);
            check_legacy_2(null, null);
            check_legacy_3(null, null);
        }

        public bool DidSave() {
            return did_save;
        }

        private void cancel_btn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e) {
            did_save = true;
            pres1 = prestige1CheckBox.Checked;
            pres2 = prestige2CheckBox.Checked;
            pres3 = prestige3CheckBox.Checked;
            legacy1 = legacyP1CheckBox.Checked;
            legacy2 = legacyP2CheckBox.Checked;
            legacy3 = legacyP3CheckBox.Checked;
            t_pres1 = prestige1Date.Value;
            t_pres2 = prestige2Date.Value;
            t_pres3 = prestige3Date.Value;
            level = levelSlider.Value;
            this.Close();
        }

        private bool did_save = false;

        public bool pres1 = false;
        public bool pres2 = false;
        public bool pres3 = false;
        public bool legacy1 = false;
        public bool legacy2 = false;
        public bool legacy3 = false;
        public int level = 0;
        public DateTime t_pres1 = DateTime.Now;
        public DateTime t_pres2 = DateTime.Now;
        public DateTime t_pres3 = DateTime.Now;


        private void level_value_changed(object sender, EventArgs e) {
            levelSlider_text.Text = "Bloodweb Level: " + levelSlider.Value;
        }

        private void check_legacy_1(object sender, EventArgs e) {
            prestige1Date.Enabled = !legacyP1CheckBox.Checked;
        }
        private void check_legacy_2(object sender, EventArgs e) {
            prestige2Date.Enabled = !legacyP2CheckBox.Checked;
        }
        private void check_legacy_3(object sender, EventArgs e) {
            prestige3Date.Enabled = !legacyP3CheckBox.Checked;
        }

    }
}
