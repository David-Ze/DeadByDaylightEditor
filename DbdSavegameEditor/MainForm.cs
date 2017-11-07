using Newtonsoft.Json.Linq;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Timers;
using System.ServiceProcess;
using System.Diagnostics;

namespace DbdSavegameEditor
{    
    public partial class MainForm : Form
    {
        string[] main_keys = new string[] { "versionNumber", "UserID", "SelectedCamper", "SelectedSlasher", "Experience", "BonusExperience", "FearTokens", "FirstTimePlaying", "CurrentSeasonTicks", "LastConnectedCharacterIndex", "OngoingGameTime" };
        string cur_json = "";
        JObject json_obj;
        System.Timers.Timer check_game_timer;
        IList<DbdCharacter> dbd_char_list = new List<DbdCharacter>();
        IList<CharEditTab> char_tabs = new List<CharEditTab>();
        int last_idx = -1;
        int item_cnt = 0;

        public System.Windows.Forms.TabControl get_tab_fld() {
            return tab_fld;
        }
        public class CharEditTab {
            public System.Windows.Forms.ListView slasher_list_view;
            public System.Windows.Forms.Button add_item_btn;
            public System.Windows.Forms.Button modify_lvl_btn;
            public System.Windows.Forms.Button copy_btn;
            public System.Windows.Forms.Button paste_btn;
            public System.Windows.Forms.Button modify_amount_btn;
            public System.Windows.Forms.TabPage slasher_tab;
            public string slasher_name;
            public bool has_prestige;
            public MainForm parent;
            public DbdCharacter dbd_char;

            private bool check_has_prestige(string name) {
                if (name == "Dwight") return true;
                if (name == "Meg") return true;
                if (name == "Claudette") return true;
                if (name == "Jake") return true;
                if (name == "Trapper") return true;
                if (name == "Wraith") return true;
                if (name == "Hilly") return true;

                return false;
            }

            private string replace_name(string orig_name) {
                if (orig_name == "surv_0") return "Dwight";
                if (orig_name == "surv_1") return "Meg";
                if (orig_name == "surv_2") return "Claudette";
                if (orig_name == "surv_3") return "Jake";
                if (orig_name == "surv_4") return "Nea";
                if (orig_name == "surv_5") return "Laurie";
                if (orig_name == "surv_6") return "Ace";
                if (orig_name == "surv_7") return "Will";
                if (orig_name == "surv_8") return "Feng";
                if (orig_name == "surv_9") return "David";
                if (orig_name == "surv_11") return "Quentin";
                if (orig_name == "kill_0") return "Trapper";
                if (orig_name == "kill_1") return "Wraith";
                if (orig_name == "kill_2") return "Hilly";
                if (orig_name == "kill_3") return "Nurse";
                if (orig_name == "kill_4") return "Hag";
                if (orig_name == "kill_5") return "Shape";
                if (orig_name == "kill_6") return "Doc";
                if (orig_name == "kill_7") return "Huntress";
                if (orig_name == "kill_8") return "Cannibal";
                if (orig_name == "kill_9") return "Freddy";

                return orig_name;
            }
            public bool IsSender(Object obj) {
                return obj == slasher_list_view || obj == add_item_btn || obj == slasher_tab || obj == modify_amount_btn
                       || obj == copy_btn || obj == paste_btn || obj == modify_lvl_btn;
            }
            public CharEditTab(MainForm parent_form, int char_num, DbdCharacter the_dbd_char) {
                parent = parent_form;
                this.slasher_tab = new System.Windows.Forms.TabPage();
                this.add_item_btn = new System.Windows.Forms.Button();
                this.modify_lvl_btn = new System.Windows.Forms.Button();
                this.copy_btn = new System.Windows.Forms.Button();
                this.paste_btn = new System.Windows.Forms.Button();
                this.modify_amount_btn = new System.Windows.Forms.Button();
                this.slasher_list_view = new System.Windows.Forms.ListView();
                this.slasher_tab.SuspendLayout();
                parent_form.SuspendLayout();

                dbd_char = the_dbd_char;

                this.add_item_btn.Location = new System.Drawing.Point(265, 470);
                this.add_item_btn.Name = "add_item_btn";
                this.add_item_btn.Size = new System.Drawing.Size(251, 40);
                this.add_item_btn.Text = "Add new item";
                this.add_item_btn.UseVisualStyleBackColor = true;
                this.add_item_btn.Click += new System.EventHandler(parent.add_item_btn_Click);

                this.modify_amount_btn.Location = new System.Drawing.Point(5, 470);
                this.modify_amount_btn.Name = "modify_amount_btn";
                this.modify_amount_btn.Size = new System.Drawing.Size(251, 40);
                this.modify_amount_btn.Text = "Modify amount";
                this.modify_amount_btn.UseVisualStyleBackColor = true;
                this.modify_amount_btn.Click += new System.EventHandler(parent.modify_amount_btn_Click);

                this.modify_lvl_btn.Location = new System.Drawing.Point(603, 470);
                this.modify_lvl_btn.Name = "modify_lvl_btn";
                this.modify_lvl_btn.Size = new System.Drawing.Size(48, 40);
                this.modify_lvl_btn.Text = "Level";
                this.modify_lvl_btn.UseVisualStyleBackColor = true;
                this.modify_lvl_btn.Click += new System.EventHandler(parent.set_level_btn_Click);

                this.copy_btn.Location = new System.Drawing.Point(659, 470);
                this.copy_btn.Name = "copy_btn";
                this.copy_btn.Size = new System.Drawing.Size(115, 40);
                this.copy_btn.Text = "Copy";
                this.copy_btn.UseVisualStyleBackColor = true;
                this.copy_btn.Click += new System.EventHandler(parent.copy_items_btn_Click);

                this.paste_btn.Location = new System.Drawing.Point(661+ 115 + 11, 470);
                this.paste_btn.Name = "paste_btn";
                this.paste_btn.Size = new System.Drawing.Size(115, 40);
                this.paste_btn.Text = "Paste";
                this.paste_btn.UseVisualStyleBackColor = true;
                this.paste_btn.Click += new System.EventHandler(parent.paste_items_btn_Click);

                this.slasher_list_view.FullRowSelect = true;
                this.slasher_list_view.Location = new System.Drawing.Point(5, 6);
                this.slasher_list_view.MultiSelect = true;
                this.slasher_list_view.Name = "slasher_list_view_"+char_num;
                this.slasher_list_view.Size = new System.Drawing.Size(896, 448);
                this.slasher_list_view.UseCompatibleStateImageBehavior = false;
                this.slasher_list_view.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(parent.slasher_tab_MouseDoubleClick);

                this.slasher_tab.Controls.Add(this.modify_lvl_btn);
                this.slasher_tab.Controls.Add(this.copy_btn);
                this.slasher_tab.Controls.Add(this.paste_btn);
                this.slasher_tab.Controls.Add(this.add_item_btn);
                this.slasher_tab.Controls.Add(this.modify_amount_btn);
                this.slasher_tab.Controls.Add(this.slasher_list_view);
                this.slasher_tab.Location = new System.Drawing.Point(4, 22);
                this.slasher_tab.Name = "tabPage"+char_num;
                this.slasher_tab.Size = new System.Drawing.Size(908, 507);                
                if(dbd_char.IsKiller()) {
                    this.slasher_name = replace_name("kill_" + dbd_char.TruncDataId());
                    this.slasher_tab.Text = this.slasher_name;                    
                }
                else {
                    this.slasher_name = replace_name("surv_" + dbd_char.TruncDataId());
                    this.slasher_tab.Text = this.slasher_name;
                }
                this.has_prestige = check_has_prestige(this.slasher_name);
                this.slasher_tab.UseVisualStyleBackColor = true;
                fill_tab();

                IntPtr h = parent.get_tab_fld().Handle;
                parent.get_tab_fld().TabPages.Insert(1,this.slasher_tab);
                this.slasher_tab.ResumeLayout(false);
                parent_form.ResumeLayout(false);
            }

            private void fill_tab() {
                slasher_list_view.Clear();
                slasher_list_view.Columns.Clear();
                slasher_list_view.Columns.Add("Item", -2, HorizontalAlignment.Left);
                slasher_list_view.Columns.Add("Count", -2, HorizontalAlignment.Left);
                slasher_list_view.View = View.Details;
                slasher_list_view.Sorting = System.Windows.Forms.SortOrder.Ascending;

                foreach (var element in dbd_char.Inventory) {
                    var item = new ListViewItem(new[] { element.Key, "" + element.Value });
                    slasher_list_view.Items.Add(item);
                }
                slasher_list_view.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                slasher_list_view.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            public void Dispose() {
                parent.get_tab_fld().TabPages.Remove(this.slasher_tab);
                this.slasher_tab.Dispose();                
            }
            ~CharEditTab() {                
            }
        }
        

        public class CharacterData {
            public string CharacterDataID { get; set; }
            public JObject CharacterDataValue { get; set; }
        }

        public class InventoryData {
            public string version { get; set; }
            public string name { get; set; }
        }

        public class DbdCharacter {
            public string CharacterDataID { get; set; }

            public int TruncDataId() {
                return Math.Abs(int.Parse(CharacterDataID)) & 0xFF;
            }
            public int EntryNum { get; set; }
            public IDictionary<string, int> Inventory { get; set; }

            public IList<InventoryData> GetInventoryData() {
                IList<InventoryData> res = new List<InventoryData>();
                foreach (var element in Inventory) {
                    for(int i = 0; i < (element.Value); ++i) {
                        InventoryData inv = new InventoryData();
                        inv.version = "16";
                        inv.name = element.Key;
                        res.Add(inv);
                    }                    
                }
                return res;
            }
            public bool IsKiller() {
                return (long.Parse(CharacterDataID) & 0x10000000L) != 0;
            }
            public DbdCharacter(string charId, int entry) {
                CharacterDataID = charId;
                EntryNum = entry;
                Inventory = new Dictionary<string, int>();
            }
        }

        void fill_tabs() {
            if (cur_json.Length == 0) return;
            //Parse json
            try {
                json_obj = JObject.Parse(cur_json);
                
                //Json text
                json_text_field.Text = Newtonsoft.Json.JsonConvert.SerializeObject(json_obj, Newtonsoft.Json.Formatting.Indented);

                dbd_char_list.Clear(); ;
                main_val_listview.Clear();
                main_val_listview.Items.Clear();
                main_val_listview.Columns.Clear();
                main_val_listview.Columns.Add("Key", -2, HorizontalAlignment.Left);
                main_val_listview.Columns.Add("Value", -2, HorizontalAlignment.Left);
                main_val_listview.View = View.Details;
                foreach (string key in main_keys) {
                    var item = new ListViewItem(new[] { key, json_obj.GetValue(key).ToString() });
                    main_val_listview.Items.Add(item);
                }
                main_val_listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                main_val_listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                IList<JToken> results = json_obj["CharacterData"].Children().ToList();
                IList<MainForm.CharacterData> searchResults = new List<MainForm.CharacterData>();
                item_cnt = 0;
                int entry = 0;
                foreach (JToken result in results) {
                    MainForm.CharacterData cc = result.ToObject<MainForm.CharacterData>();
                    searchResults.Add(cc);
                    if (cc.CharacterDataID == "-1") {
                        ++entry;
                        continue;
                    }

                    IList<JToken> item_token = cc.CharacterDataValue["inventoryData"].Children().ToList();
                    DbdCharacter dbd_char = new DbdCharacter(cc.CharacterDataID, entry);
                    foreach (JToken item in item_token) {
                        MainForm.InventoryData inv_item = item.ToObject<MainForm.InventoryData>();
                        if(!dbd_char.Inventory.ContainsKey(inv_item.name)) {
                            dbd_char.Inventory[inv_item.name] = 1;
                        } else {
                            ++dbd_char.Inventory[inv_item.name];
                        }
                        ++item_cnt;
                    }                    
                    dbd_char_list.Add(dbd_char);
                    ++entry;
                }
                
                for (int i = 0; i < char_tabs.Count; ++i) {
                    char_tabs[i].Dispose();
                }
                char_tabs.Clear();

                int cnum = dbd_char_list.Count;
                foreach (DbdCharacter dbd_char in dbd_char_list.Reverse()) {
                    CharEditTab gui_tab = new CharEditTab(this, --cnum, dbd_char);
                    char_tabs.Add(gui_tab);
                }
            } catch (Newtonsoft.Json.JsonReaderException ) {
                MessageBox.Show("Savegame file is not valid :-(");
            }
        }

        void update_json_change() {
            cur_json = Newtonsoft.Json.JsonConvert.SerializeObject(json_obj, Newtonsoft.Json.Formatting.None);
            fill_tabs();
        }

        public MainForm() {
            InitializeComponent();
            this.json_tab.TabIndex = 9999;
            fill_tabs();
        }

        private void exit_btn_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }

        private void main_val_listview_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (this.main_val_listview.GetItemAt(e.X, e.Y) != null) {
                var enumerator = this.main_val_listview.SelectedIndices.GetEnumerator();
                enumerator.MoveNext();
                var cur_idx = enumerator.Current;

                InputForm inpDiag = new InputForm(json_obj.GetValue(main_keys[(int)cur_idx]).ToString());
                if (inpDiag.ShowDialog(this) == DialogResult.OK) {
                    bool is_int = false;
                    int outp = 0;
                    if(int.TryParse(inpDiag.GetResult(), out outp) && (""+outp)== inpDiag.GetResult()) {
                        if(main_keys[(int)cur_idx] != "OngoingGameTime" &&
                            main_keys[(int)cur_idx] != "CurrentSeasonTicks" &&
                            main_keys[(int)cur_idx] != "UserID") {
                            is_int = true;
                        }
                    }
                    if(is_int) {
                        json_obj[main_keys[(int)cur_idx]] = long.Parse(inpDiag.GetResult());
                    }
                    else {
                        json_obj[main_keys[(int)cur_idx]] = inpDiag.GetResult();
                    }
                    
                    update_json_change();
                }
                inpDiag.Dispose();
            }
        }

        CharEditTab find_sending_tab(object sender) {
            foreach(CharEditTab tab in char_tabs) {
                if(tab.IsSender(sender)) {
                    return tab;
                }
            }
            return null;
        }

        private bool displayed_item_warning = false;
        private void slasher_tab_MouseDoubleClick(object sender, MouseEventArgs e) {
            CharEditTab sending_tab = find_sending_tab(sender);

            if (sending_tab != null && sending_tab.slasher_list_view.GetItemAt(e.X, e.Y) != null) {
                var enumerator = sending_tab.slasher_list_view.SelectedIndices.GetEnumerator();
                enumerator.MoveNext();
                var cur_idx = enumerator.Current;
                string item_name = sending_tab.slasher_list_view.SelectedItems[0].SubItems[0].Text;
                
                NumberForm inpDiag = new NumberForm(sending_tab.dbd_char.Inventory[item_name].ToString());
                if (inpDiag.ShowDialog(this) == DialogResult.OK) {
                    item_cnt -= sending_tab.dbd_char.Inventory[item_name];
                    sending_tab.dbd_char.Inventory[item_name] = int.Parse(inpDiag.GetResult());
                    sending_tab.slasher_list_view.SelectedItems[0].SubItems[1].Text = "" + sending_tab.dbd_char.Inventory[item_name];
                    item_cnt += sending_tab.dbd_char.Inventory[item_name];
                }
                inpDiag.Dispose();
            }
            
            if(item_cnt >= 250000 && !displayed_item_warning) {
                displayed_item_warning = true;
                MessageBox.Show("Warning: Profile has more than 250.000 items. Adding too many items causes freeze issues and crashes (instable game).");
            }
        }

        private void copy_items_btn_Click(object sender, EventArgs e) {
            CharEditTab sending_tab = find_sending_tab(sender);

            if (sending_tab != null) {
                var enumerator = sending_tab.slasher_list_view.SelectedIndices.GetEnumerator();
                int ind = 0;
                string items_string = "";

                while (enumerator.MoveNext()) {
                    if (ind != 0) {
                        //Add ','
                        items_string += ",";
                    }
                    string item_name = sending_tab.slasher_list_view.SelectedItems[ind].SubItems[0].Text;
                    items_string += item_name;
                    items_string += "=";
                    items_string += sending_tab.slasher_list_view.SelectedItems[ind].SubItems[1].Text;
                    ++ind;
                }

                if(items_string.Length == 0) {
                    MessageBox.Show("Please select some items to be copied.");
                }
                else {
                    System.Windows.Forms.Clipboard.SetText(items_string);
                    MessageBox.Show("Copied " + ind.ToString() + " items to clipboard.");
                }                
            }
        }

        private void set_level_btn_Click(object sender, EventArgs e) {
            CharEditTab sending_tab = find_sending_tab(sender);

            if (sending_tab != null) {
                // First read level
                int char_lvl = int.Parse(json_obj["CharacterData"][sending_tab.dbd_char.EntryNum]["CharacterDataValue"]["bloodWebLevel"].ToString());
                int char_prestige_count = int.Parse(json_obj["CharacterData"][sending_tab.dbd_char.EntryNum]["CharacterDataValue"]["prestigeLevel"].ToString());
                List<DateTime> prestige_dates = json_obj["CharacterData"][sending_tab.dbd_char.EntryNum]["CharacterDataValue"]["PrestigeEarnedDates"].ToObject<List<DateTime>>();

                PrestigeForm inpDiag = new PrestigeForm(char_lvl, char_prestige_count, prestige_dates, sending_tab.has_prestige);
                if (inpDiag.ShowDialog(this) == DialogResult.OK && inpDiag.DidSave() == true) {
                    DateTime legacy_date = new DateTime(1, 1, 1, 0, 0, 0);
                    List<DateTime> new_dates = new List<DateTime>();
                    int prestige_count = 0;
                    if (inpDiag.pres1) {
                        ++prestige_count;
                        if (inpDiag.legacy1) {
                            new_dates.Add(legacy_date);
                        }
                        else {
                            new_dates.Add(inpDiag.t_pres1);
                        }

                        if (inpDiag.pres2) {
                            ++prestige_count;
                            if (inpDiag.legacy2) {
                                new_dates.Add(legacy_date);
                            } else {
                                new_dates.Add(inpDiag.t_pres2);
                            }

                            if (inpDiag.pres3) {
                                ++prestige_count;
                                if (inpDiag.legacy3) {
                                    new_dates.Add(legacy_date);
                                } else {
                                    new_dates.Add(inpDiag.t_pres3);
                                }
                            }
                        }
                    }

                    int new_lvl = inpDiag.level;

                    //Assign everything
                    json_obj["CharacterData"][sending_tab.dbd_char.EntryNum]["CharacterDataValue"]["bloodWebLevel"] = new_lvl;
                    json_obj["CharacterData"][sending_tab.dbd_char.EntryNum]["CharacterDataValue"]["prestigeLevel"] = prestige_count;
                    json_obj["CharacterData"][sending_tab.dbd_char.EntryNum]["CharacterDataValue"]["PrestigeEarnedDates"] = JToken.FromObject(new_dates);
                } else {
                    //MessageBox.Show("Canceled");
                }
                inpDiag.Dispose();
            }
        }

        private void paste_items_btn_Click(object sender, EventArgs e) {
            CharEditTab sending_tab = find_sending_tab(sender);

            if (sending_tab != null) {
                string clipboard_text = System.Windows.Forms.Clipboard.GetText();
                string[] words = clipboard_text.Split(',');
                int pasted_amount = 0;

                foreach (string s in words) {
                    string[] assignment = s.Split('=');
                    if(assignment.Count() != 2) {
                        MessageBox.Show("Invalid format: " + s);
                        return;
                    }
                    int count = int.Parse(assignment[1]);

                    if (sending_tab.dbd_char.Inventory.ContainsKey(assignment[0])) {
                        sending_tab.dbd_char.Inventory[assignment[0]] = count;
                        for(int i = 0; i < sending_tab.slasher_list_view.SelectedItems.Count; ++i) {
                            if(sending_tab.slasher_list_view.SelectedItems[i].SubItems[0].Text.Equals(assignment[0])) {
                                sending_tab.slasher_list_view.SelectedItems[i].SubItems[1].Text = "" + sending_tab.dbd_char.Inventory[assignment[0]];
                            }
                        }                        
                    } else {
                        sending_tab.dbd_char.Inventory.Add(assignment[0], count);
                        var item = new ListViewItem(new[] { assignment[0], assignment[1] });
                        sending_tab.slasher_list_view.Items.Add(item);
                    }

                    ++pasted_amount;
                }

                MessageBox.Show("Pasted " + pasted_amount.ToString() + " items.");
            }
        }

        private void modify_amount_btn_Click(object sender, EventArgs e) {
            CharEditTab sending_tab = find_sending_tab(sender);

            if (sending_tab != null) {
                var enumerator = sending_tab.slasher_list_view.SelectedIndices.GetEnumerator();
                bool first = true;
                List<string> selected_items = new List<string>();
                int ind = 0;
                string items_string = "";

                while (enumerator.MoveNext()) {
                    if (!first) {
                        //Add ','
                        items_string += ",";
                    }
                    var cur_idx = enumerator.Current;
                    string item_name = sending_tab.slasher_list_view.SelectedItems[ind].SubItems[0].Text;
                    selected_items.Add(item_name);
                    items_string += item_name;
                    first = false;
                    ++ind;
                }

                if(ind == 0) {
                    return; //Nothing selected!
                }

                int max_amount = 0;
                foreach (string item in selected_items) {
                    if(sending_tab.dbd_char.Inventory[item] > max_amount) {
                        max_amount = sending_tab.dbd_char.Inventory[item];
                    }
                }
                
                NumberForm inpDiag = new NumberForm(max_amount.ToString());
                if (inpDiag.ShowDialog(this) == DialogResult.OK) {
                    int j = 0;
                    foreach (string item in selected_items) {
                        item_cnt -= sending_tab.dbd_char.Inventory[item];
                        sending_tab.dbd_char.Inventory[item] = int.Parse(inpDiag.GetResult());
                        sending_tab.slasher_list_view.SelectedItems[j].SubItems[1].Text = "" + sending_tab.dbd_char.Inventory[item];
                        item_cnt += sending_tab.dbd_char.Inventory[item];
                        ++j;
                    }                    
                }
                inpDiag.Dispose();
            }

            if (item_cnt >= 250000 && !displayed_item_warning) {
                displayed_item_warning = true;
                MessageBox.Show("Warning: Profile has more than 250.000 items. Adding too many items causes freeze issues and crashes (instable game).");
            }
        }

        private void add_item_btn_Click(object sender, EventArgs e) {
            CharEditTab sending_tab = find_sending_tab(sender);
            if (sending_tab == null) return;

            ItemForm inpDiag = new ItemForm("", "Enter name of new item:");
            if (inpDiag.ShowDialog(this) == DialogResult.OK && inpDiag.GetResult() != null) {
                if(sending_tab.dbd_char.Inventory.ContainsKey(inpDiag.GetResult())) {
                    MessageBox.Show("Can't add an item that already exists...");
                }
                else {
                    sending_tab.dbd_char.Inventory.Add(inpDiag.GetResult(), 1);
                    var item = new ListViewItem(new[] { inpDiag.GetResult(), "1" });
                    sending_tab.slasher_list_view.Items.Add(item);
                }                
            }
            inpDiag.Dispose();
        }

        void write_tab_to_json(int tab_id) {
            if(tab_id > 0 && tab_id < tab_fld.TabCount-1) {
                DbdCharacter last_char = dbd_char_list[tab_id - 1];
                json_obj["CharacterData"][last_char.EntryNum]["CharacterDataValue"]["inventoryData"] = JToken.FromObject(last_char.GetInventoryData());
                cur_json = Newtonsoft.Json.JsonConvert.SerializeObject(json_obj, Newtonsoft.Json.Formatting.None);
            }
            else if(tab_id == tab_fld.TabCount - 1) {
                cur_json = json_text_field.Text;
                json_obj = JObject.Parse(cur_json);
                //Compactify
                cur_json = Newtonsoft.Json.JsonConvert.SerializeObject(json_obj, Newtonsoft.Json.Formatting.None);
            }
        }

        private bool avoid_reenter_tab_idx = false;
        private void tab_fld_TabIndexChanged(object sender, EventArgs e) {
            if (cur_json.Length == 0) return;
            if (avoid_reenter_tab_idx) return;
            avoid_reenter_tab_idx = true;
            int cur_idx = tab_fld.SelectedIndex;
            write_tab_to_json(last_idx);

            if (cur_idx == tab_fld.TabCount - 1) {
                update_json_change();
            }
            else if(last_idx == tab_fld.TabCount - 1) {
                this.SuspendLayout();
                tab_fld.SelectedIndex = 0;
                fill_tabs();
                this.ResumeLayout(false);
            }            

            last_idx = tab_fld.SelectedIndex;
            avoid_reenter_tab_idx = false;
        }

        private void save_profile_btn_Click(object sender, EventArgs e) {
            if (cur_json.Length == 0) {
                MessageBox.Show("Can't save without anything loaded...");
                return;
            }

            SaveFileDialog save_dlg = new SaveFileDialog();
            save_dlg.Filter = "DBD Profile|*.profjce";
            save_dlg.Title = "Save profile";
            save_dlg.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (save_dlg.FileName != "") {
                write_tab_to_json(tab_fld.SelectedIndex);
                tab_fld.SelectedIndex = 0;
                try {
                    var pattern = @"(?<=:\d\d)Z";
                    var output = Regex.Replace(cur_json, pattern, ".000Z").Trim();
                    writeJsonDataToProfileAndVerify(save_dlg.FileName, output);
                    fill_tabs();
                } catch (Newtonsoft.Json.JsonReaderException ) {
                    MessageBox.Show("You messed up (JSON is invalid).");
                }            
            }
        }

        public static bool IsX64() {
            if (IntPtr.Size == 8) {
                return true;
            }
            return false;
        }

        [DllImport(@"DbdCrypter_x64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern void getJsonDataFromProfileX64(byte[] file_name, byte[] buffer);
        [DllImport(@"DbdCrypter_x64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern void writeJsonDataToProfileX64(byte[] file_name, byte[] buffer);

        [DllImport(@"DbdCrypter_x86.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern void getJsonDataFromProfileX86(byte[] file_name, byte[] buffer);
        [DllImport(@"DbdCrypter_x86.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        private static extern void writeJsonDataToProfileX86(byte[] file_name, byte[] buffer);

        public string getJsonDataFromProfile(string file_name) {
            byte[] buf = new byte[0x10000000];
            byte[] filename_bytes = System.Text.Encoding.Unicode.GetBytes(file_name);
            buf[0] = 0;
            if(IsX64()) {
                getJsonDataFromProfileX64(filename_bytes, buf);
            }
            else {
                getJsonDataFromProfileX86(filename_bytes, buf);
            }            
            long str_len = 0;
            while (buf[str_len] != 0 && str_len != 0x10000000) ++str_len;
            if (str_len == 0) return "";
            string json_dat = System.Text.Encoding.ASCII.GetString(buf);
            json_dat = json_dat.TrimEnd('\x00');
            return (json_dat.Trim());
        }

        public bool validateJson(string js) {
            try {
                JToken.Parse(js);
                return true;
            } catch (Newtonsoft.Json.JsonReaderException ) {                
                return false;
            } catch (Exception ) {
                return false;
            }
        }
        public bool match_js(string json_dat, string written_json) {
            if(Math.Abs(json_dat.Length - written_json.Length) >= 1000) {
                return false;
            }

            if(!validateJson(written_json)) {
                return false;
            }

            return true;
        }

        public void writeJsonDataToProfileAndVerify(string file_name, string json_dat) {
            string temp_file = file_name + ".tmp";
            writeJsonDataToProfile(temp_file, json_dat);
            string verification = getJsonDataFromProfile(temp_file);
            //Verify
            if(match_js(json_dat, verification)) {
                if (File.Exists(file_name)) {
                    File.Delete(file_name);
                }
                File.Move(temp_file, file_name);
            }
            else {
                MessageBox.Show("Failed to write the savegame, please try again!");
            }
        }

        public void writeJsonDataToProfile(string file_name, string json_dat) {
            byte[] filename_bytes = System.Text.Encoding.Unicode.GetBytes(file_name);
            byte[] profile_bytes = Encoding.ASCII.GetBytes(json_dat);
            
            if (IsX64()) {
                writeJsonDataToProfileX64(filename_bytes, profile_bytes);
            } else {
                writeJsonDataToProfileX86(filename_bytes, profile_bytes);
            }
        }

        private void load_profile_btn_Click(object sender, EventArgs e) {
            OpenFileDialog open_dlg = new OpenFileDialog();
            open_dlg.Filter = "DBD Profile|*.profjce";
            open_dlg.Title = "Open profile";
            open_dlg.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (open_dlg.FileName != "") {
                string prof = getJsonDataFromProfile(open_dlg.FileName);
                cur_json = prof;
                fill_tabs();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            AboutForm diag = new AboutForm();
            diag.ShowDialog(this);
            diag.Dispose();
        }

        private bool CheckForEACService()
        {
            string service_name = "EasyAntiCheat";
            if (!ServiceController.GetServices().Any(serviceController => serviceController.ServiceName.Equals(service_name))) {
                return false;
            }

            ServiceController sc = new ServiceController(service_name);
            return sc.Status != ServiceControllerStatus.Stopped;
        }
        
        private bool CheckForDbd()
        {
            if (Process.GetProcessesByName("DeadByDaylight").Length > 0) return true;
            if (Process.GetProcessesByName("DeadByDaylight-Win64-Shipping").Length > 0) return true;
            return false;
        }

        // Exit asap as EAC of DBD was found.
        private void Panic()
        {
            System.Environment.Exit(1);
        }

        // Check if DBD or EAC is running (panic).
        private void CheckForGame(object sender, EventArgs e)
        {
            if(CheckForEACService() || CheckForDbd()) {
                Panic();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            check_game_timer = new System.Timers.Timer();
            check_game_timer.Elapsed += new ElapsedEventHandler(CheckForGame);
            check_game_timer.Interval = 30;
            check_game_timer.Enabled = true;
        }
    }

    
}
