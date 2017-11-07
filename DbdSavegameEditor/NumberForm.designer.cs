namespace DbdSavegameEditor {
    partial class NumberForm {
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
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_slider = new System.Windows.Forms.TrackBar();
            this.amount_label = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.input_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_btn.Location = new System.Drawing.Point(12, 87);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(184, 21);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(229, 87);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(184, 21);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose new amount:";
            // 
            // input_slider
            // 
            this.input_slider.LargeChange = 10;
            this.input_slider.Location = new System.Drawing.Point(15, 36);
            this.input_slider.Maximum = 2000;
            this.input_slider.Name = "input_slider";
            this.input_slider.Size = new System.Drawing.Size(398, 45);
            this.input_slider.TabIndex = 4;
            this.input_slider.TickFrequency = 10;
            this.input_slider.Scroll += new System.EventHandler(this.input_slider_Scroll);
            // 
            // amount_label
            // 
            this.amount_label.Location = new System.Drawing.Point(125, 10);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(100, 20);
            this.amount_label.TabIndex = 6;
            this.amount_label.TextChanged += new System.EventHandler(this.amount_label_TextChanged);
            // 
            // NumberForm
            // 
            this.AcceptButton = this.save_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(425, 120);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.input_slider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Value";
            ((System.ComponentModel.ISupportInitialize)(this.input_slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar input_slider;
        private System.Windows.Forms.TextBox amount_label;
    }
}