namespace DbdSavegameEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.load_profile_btn = new System.Windows.Forms.Button();
            this.save_profile_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.json_tab = new System.Windows.Forms.TabPage();
            this.json_text_field = new System.Windows.Forms.TextBox();
            this.main_tab = new System.Windows.Forms.TabPage();
            this.main_val_listview = new System.Windows.Forms.ListView();
            this.tab_fld = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.json_tab.SuspendLayout();
            this.main_tab.SuspendLayout();
            this.tab_fld.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_profile_btn
            // 
            this.load_profile_btn.Location = new System.Drawing.Point(15, 586);
            this.load_profile_btn.Name = "load_profile_btn";
            this.load_profile_btn.Size = new System.Drawing.Size(251, 42);
            this.load_profile_btn.TabIndex = 0;
            this.load_profile_btn.Text = "Load Profile";
            this.load_profile_btn.UseVisualStyleBackColor = true;
            this.load_profile_btn.Click += new System.EventHandler(this.load_profile_btn_Click);
            // 
            // save_profile_btn
            // 
            this.save_profile_btn.Location = new System.Drawing.Point(275, 586);
            this.save_profile_btn.Name = "save_profile_btn";
            this.save_profile_btn.Size = new System.Drawing.Size(251, 42);
            this.save_profile_btn.TabIndex = 1;
            this.save_profile_btn.Text = "Save Profile";
            this.save_profile_btn.UseVisualStyleBackColor = true;
            this.save_profile_btn.Click += new System.EventHandler(this.save_profile_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(667, 586);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(251, 42);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // json_tab
            // 
            this.json_tab.Controls.Add(this.json_text_field);
            this.json_tab.Location = new System.Drawing.Point(4, 22);
            this.json_tab.Name = "json_tab";
            this.json_tab.Padding = new System.Windows.Forms.Padding(3);
            this.json_tab.Size = new System.Drawing.Size(908, 532);
            this.json_tab.TabIndex = 1;
            this.json_tab.Text = "JSON Data";
            this.json_tab.UseVisualStyleBackColor = true;
            // 
            // json_text_field
            // 
            this.json_text_field.Location = new System.Drawing.Point(6, 6);
            this.json_text_field.MaxLength = 0;
            this.json_text_field.Multiline = true;
            this.json_text_field.Name = "json_text_field";
            this.json_text_field.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.json_text_field.Size = new System.Drawing.Size(899, 495);
            this.json_text_field.TabIndex = 0;
            // 
            // main_tab
            // 
            this.main_tab.AutoScroll = true;
            this.main_tab.Controls.Add(this.main_val_listview);
            this.main_tab.Location = new System.Drawing.Point(4, 22);
            this.main_tab.Name = "main_tab";
            this.main_tab.Padding = new System.Windows.Forms.Padding(3);
            this.main_tab.Size = new System.Drawing.Size(908, 532);
            this.main_tab.TabIndex = 0;
            this.main_tab.Text = "Main Values";
            // 
            // main_val_listview
            // 
            this.main_val_listview.FullRowSelect = true;
            this.main_val_listview.Location = new System.Drawing.Point(6, 6);
            this.main_val_listview.MultiSelect = false;
            this.main_val_listview.Name = "main_val_listview";
            this.main_val_listview.Size = new System.Drawing.Size(896, 495);
            this.main_val_listview.TabIndex = 0;
            this.main_val_listview.UseCompatibleStateImageBehavior = false;
            this.main_val_listview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.main_val_listview_MouseDoubleClick);
            // 
            // tab_fld
            // 
            this.tab_fld.Controls.Add(this.main_tab);
            this.tab_fld.Controls.Add(this.json_tab);
            this.tab_fld.Location = new System.Drawing.Point(12, 12);
            this.tab_fld.MaximumSize = new System.Drawing.Size(916, 668);
            this.tab_fld.MinimumSize = new System.Drawing.Size(916, 558);
            this.tab_fld.Name = "tab_fld";
            this.tab_fld.SelectedIndex = 0;
            this.tab_fld.Size = new System.Drawing.Size(916, 558);
            this.tab_fld.TabIndex = 3;
            this.tab_fld.SelectedIndexChanged += new System.EventHandler(this.tab_fld_TabIndexChanged);
            this.tab_fld.TabIndexChanged += new System.EventHandler(this.tab_fld_TabIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.tab_fld);
            this.Controls.Add(this.save_profile_btn);
            this.Controls.Add(this.load_profile_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DeadByDaylight Savegame Editor";
            this.Load += new System.EventHandler(this.OnLoad);
            this.json_tab.ResumeLayout(false);
            this.json_tab.PerformLayout();
            this.main_tab.ResumeLayout(false);
            this.tab_fld.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_profile_btn;
        private System.Windows.Forms.Button save_profile_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.TabPage json_tab;
        private System.Windows.Forms.TextBox json_text_field;
        private System.Windows.Forms.TabPage main_tab;
        private System.Windows.Forms.ListView main_val_listview;
        private System.Windows.Forms.TabControl tab_fld;
        private System.Windows.Forms.Button button1;
    }
}

