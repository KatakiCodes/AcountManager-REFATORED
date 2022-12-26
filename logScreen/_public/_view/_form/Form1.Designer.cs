namespace logScreen
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.log_Container = new System.Windows.Forms.Panel();
            this.link_ToggleControl = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 446);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 333);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // log_Container
            // 
            this.log_Container.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_Container.Location = new System.Drawing.Point(321, 0);
            this.log_Container.Name = "log_Container";
            this.log_Container.Size = new System.Drawing.Size(376, 376);
            this.log_Container.TabIndex = 1;
            // 
            // link_ToggleControl
            // 
            this.link_ToggleControl.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.link_ToggleControl.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_ToggleControl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_ToggleControl.LinkColor = System.Drawing.Color.DodgerBlue;
            this.link_ToggleControl.Location = new System.Drawing.Point(321, 381);
            this.link_ToggleControl.Name = "link_ToggleControl";
            this.link_ToggleControl.Size = new System.Drawing.Size(376, 23);
            this.link_ToggleControl.TabIndex = 2;
            this.link_ToggleControl.TabStop = true;
            this.link_ToggleControl.Text = "linkLabel1";
            this.link_ToggleControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_ToggleControl.VisitedLinkColor = System.Drawing.Color.DarkOrange;
            this.link_ToggleControl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ToggleControl_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 446);
            this.Controls.Add(this.link_ToggleControl);
            this.Controls.Add(this.log_Container);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(713, 485);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel log_Container;
        private System.Windows.Forms.LinkLabel link_ToggleControl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

