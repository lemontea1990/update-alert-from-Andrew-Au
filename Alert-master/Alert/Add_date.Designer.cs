namespace Alert
{
    partial class Add_date
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_date = new System.Windows.Forms.Label();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_alert_title = new System.Windows.Forms.Label();
            this.txtbox_at = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(73, 41);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(166, 42);
            this.lb_date.TabIndex = 0;
            this.lb_date.Text = "Choose Date";
            // 
            // dtp_time
            // 
            this.dtp_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time.Location = new System.Drawing.Point(351, 97);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.ShowUpDown = true;
            this.dtp_time.Size = new System.Drawing.Size(228, 42);
            this.dtp_time.TabIndex = 1;
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(60, 97);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(207, 42);
            this.dtp_date.TabIndex = 2;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(376, 41);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(170, 42);
            this.lb_time.TabIndex = 3;
            this.lb_time.Text = "Choose Time";
            // 
            // lb_alert_title
            // 
            this.lb_alert_title.AutoSize = true;
            this.lb_alert_title.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alert_title.Location = new System.Drawing.Point(334, 207);
            this.lb_alert_title.Name = "lb_alert_title";
            this.lb_alert_title.Size = new System.Drawing.Size(142, 42);
            this.lb_alert_title.TabIndex = 4;
            this.lb_alert_title.Text = "Alert Title";
            // 
            // txtbox_at
            // 
            this.txtbox_at.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_at.Location = new System.Drawing.Point(362, 252);
            this.txtbox_at.Name = "txtbox_at";
            this.txtbox_at.Size = new System.Drawing.Size(294, 35);
            this.txtbox_at.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(649, 334);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(253, 63);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_run
            // 
            this.btn_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run.Location = new System.Drawing.Point(49, 334);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(253, 63);
            this.btn_run.TabIndex = 7;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // Add_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 421);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtbox_at);
            this.Controls.Add(this.lb_alert_title);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.lb_date);
            this.Name = "Add_date";
            this.Text = "Add_date";
            this.Load += new System.EventHandler(this.Add_date_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_alert_title;
        private System.Windows.Forms.TextBox txtbox_at;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_run;
    }
}