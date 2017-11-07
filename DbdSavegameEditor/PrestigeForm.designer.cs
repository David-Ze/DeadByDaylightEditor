namespace DbdSavegameEditor {
    partial class PrestigeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.levelSlider_text = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.prestige1Date = new System.Windows.Forms.DateTimePicker();
            this.levelSlider = new System.Windows.Forms.TrackBar();
            this.legacyP1CheckBox = new System.Windows.Forms.CheckBox();
            this.prestige1CheckBox = new System.Windows.Forms.CheckBox();
            this.prestige2CheckBox = new System.Windows.Forms.CheckBox();
            this.legacyP2CheckBox = new System.Windows.Forms.CheckBox();
            this.prestige2Date = new System.Windows.Forms.DateTimePicker();
            this.prestige3CheckBox = new System.Windows.Forms.CheckBox();
            this.legacyP3CheckBox = new System.Windows.Forms.CheckBox();
            this.prestige3Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.levelSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // levelSlider_text
            // 
            this.levelSlider_text.AutoSize = true;
            this.levelSlider_text.Location = new System.Drawing.Point(12, 13);
            this.levelSlider_text.Name = "levelSlider_text";
            this.levelSlider_text.Size = new System.Drawing.Size(95, 13);
            this.levelSlider_text.TabIndex = 3;
            this.levelSlider_text.Text = "Bloodweb Level: 1";
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(234, 202);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(184, 21);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_btn.Location = new System.Drawing.Point(15, 202);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(184, 21);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // prestige1Date
            // 
            this.prestige1Date.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.prestige1Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.prestige1Date.Location = new System.Drawing.Point(218, 91);
            this.prestige1Date.Name = "prestige1Date";
            this.prestige1Date.Size = new System.Drawing.Size(200, 20);
            this.prestige1Date.TabIndex = 4;
            // 
            // levelSlider
            // 
            this.levelSlider.LargeChange = 1;
            this.levelSlider.Location = new System.Drawing.Point(15, 34);
            this.levelSlider.Maximum = 50;
            this.levelSlider.Minimum = 1;
            this.levelSlider.Name = "levelSlider";
            this.levelSlider.Size = new System.Drawing.Size(398, 45);
            this.levelSlider.TabIndex = 5;
            this.levelSlider.Value = 1;
            this.levelSlider.ValueChanged += new System.EventHandler(this.level_value_changed);
            // 
            // legacyP1CheckBox
            // 
            this.legacyP1CheckBox.AutoSize = true;
            this.legacyP1CheckBox.Location = new System.Drawing.Point(119, 93);
            this.legacyP1CheckBox.Name = "legacyP1CheckBox";
            this.legacyP1CheckBox.Size = new System.Drawing.Size(61, 17);
            this.legacyP1CheckBox.TabIndex = 6;
            this.legacyP1CheckBox.Text = "Legacy";
            this.legacyP1CheckBox.UseVisualStyleBackColor = true;
            this.legacyP1CheckBox.Click += new System.EventHandler(this.check_legacy_1);
            // 
            // prestige1CheckBox
            // 
            this.prestige1CheckBox.AutoSize = true;
            this.prestige1CheckBox.Location = new System.Drawing.Point(25, 93);
            this.prestige1CheckBox.Name = "prestige1CheckBox";
            this.prestige1CheckBox.Size = new System.Drawing.Size(73, 17);
            this.prestige1CheckBox.TabIndex = 7;
            this.prestige1CheckBox.Text = "Prestige 1";
            this.prestige1CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.prestige1CheckBox.UseVisualStyleBackColor = true;
            // 
            // prestige2CheckBox
            // 
            this.prestige2CheckBox.AutoSize = true;
            this.prestige2CheckBox.Location = new System.Drawing.Point(25, 123);
            this.prestige2CheckBox.Name = "prestige2CheckBox";
            this.prestige2CheckBox.Size = new System.Drawing.Size(73, 17);
            this.prestige2CheckBox.TabIndex = 10;
            this.prestige2CheckBox.Text = "Prestige 2";
            this.prestige2CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.prestige2CheckBox.UseVisualStyleBackColor = true;
            // 
            // legacyP2CheckBox
            // 
            this.legacyP2CheckBox.AutoSize = true;
            this.legacyP2CheckBox.Location = new System.Drawing.Point(119, 123);
            this.legacyP2CheckBox.Name = "legacyP2CheckBox";
            this.legacyP2CheckBox.Size = new System.Drawing.Size(61, 17);
            this.legacyP2CheckBox.TabIndex = 9;
            this.legacyP2CheckBox.Text = "Legacy";
            this.legacyP2CheckBox.UseVisualStyleBackColor = true;
            this.legacyP2CheckBox.Click += new System.EventHandler(this.check_legacy_2);
            // 
            // prestige2Date
            // 
            this.prestige2Date.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.prestige2Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.prestige2Date.Location = new System.Drawing.Point(218, 121);
            this.prestige2Date.Name = "prestige2Date";
            this.prestige2Date.Size = new System.Drawing.Size(200, 20);
            this.prestige2Date.TabIndex = 8;
            // 
            // prestige3CheckBox
            // 
            this.prestige3CheckBox.AutoSize = true;
            this.prestige3CheckBox.Location = new System.Drawing.Point(25, 153);
            this.prestige3CheckBox.Name = "prestige3CheckBox";
            this.prestige3CheckBox.Size = new System.Drawing.Size(73, 17);
            this.prestige3CheckBox.TabIndex = 13;
            this.prestige3CheckBox.Text = "Prestige 3";
            this.prestige3CheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.prestige3CheckBox.UseVisualStyleBackColor = true;
            // 
            // legacyP3CheckBox
            // 
            this.legacyP3CheckBox.AutoSize = true;
            this.legacyP3CheckBox.Location = new System.Drawing.Point(119, 153);
            this.legacyP3CheckBox.Name = "legacyP3CheckBox";
            this.legacyP3CheckBox.Size = new System.Drawing.Size(61, 17);
            this.legacyP3CheckBox.TabIndex = 12;
            this.legacyP3CheckBox.Text = "Legacy";
            this.legacyP3CheckBox.UseVisualStyleBackColor = true;
            this.legacyP3CheckBox.Click += new System.EventHandler(this.check_legacy_3);
            // 
            // prestige3Date
            // 
            this.prestige3Date.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.prestige3Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.prestige3Date.Location = new System.Drawing.Point(218, 151);
            this.prestige3Date.Name = "prestige3Date";
            this.prestige3Date.Size = new System.Drawing.Size(200, 20);
            this.prestige3Date.TabIndex = 11;
            // 
            // PrestigeForm
            // 
            this.AcceptButton = this.save_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(434, 234);
            this.Controls.Add(this.prestige3CheckBox);
            this.Controls.Add(this.legacyP3CheckBox);
            this.Controls.Add(this.prestige3Date);
            this.Controls.Add(this.prestige2CheckBox);
            this.Controls.Add(this.legacyP2CheckBox);
            this.Controls.Add(this.prestige2Date);
            this.Controls.Add(this.prestige1CheckBox);
            this.Controls.Add(this.legacyP1CheckBox);
            this.Controls.Add(this.levelSlider);
            this.Controls.Add(this.prestige1Date);
            this.Controls.Add(this.levelSlider_text);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PrestigeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level & Prestige";
            ((System.ComponentModel.ISupportInitialize)(this.levelSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label levelSlider_text;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.DateTimePicker prestige1Date;
        private System.Windows.Forms.TrackBar levelSlider;
        private System.Windows.Forms.CheckBox legacyP1CheckBox;
        private System.Windows.Forms.CheckBox prestige1CheckBox;
        private System.Windows.Forms.CheckBox prestige2CheckBox;
        private System.Windows.Forms.CheckBox legacyP2CheckBox;
        private System.Windows.Forms.DateTimePicker prestige2Date;
        private System.Windows.Forms.CheckBox prestige3CheckBox;
        private System.Windows.Forms.CheckBox legacyP3CheckBox;
        private System.Windows.Forms.DateTimePicker prestige3Date;
    }
}