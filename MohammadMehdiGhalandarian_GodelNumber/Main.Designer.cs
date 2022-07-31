namespace MohammadMehdiGhalandarian_GodelNumber
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_calculate_Pnumber = new System.Windows.Forms.Button();
            this.Panel_interduse = new System.Windows.Forms.Panel();
            this.Pnl_show = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.btn_calculate_Pnumber);
            this.panelMenu.Controls.Add(this.Panel_interduse);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMenu.Location = new System.Drawing.Point(535, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(185, 470);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 82);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Write Program";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_calculate_Pnumber
            // 
            this.btn_calculate_Pnumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_calculate_Pnumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_calculate_Pnumber.FlatAppearance.BorderSize = 0;
            this.btn_calculate_Pnumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculate_Pnumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_calculate_Pnumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_calculate_Pnumber.Location = new System.Drawing.Point(0, 73);
            this.btn_calculate_Pnumber.Name = "btn_calculate_Pnumber";
            this.btn_calculate_Pnumber.Size = new System.Drawing.Size(185, 82);
            this.btn_calculate_Pnumber.TabIndex = 0;
            this.btn_calculate_Pnumber.Text = "Calculate program number";
            this.btn_calculate_Pnumber.UseVisualStyleBackColor = true;
            this.btn_calculate_Pnumber.Click += new System.EventHandler(this.btn_calculate_Pnumber_Click);
            // 
            // Panel_interduse
            // 
            this.Panel_interduse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Panel_interduse.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_interduse.Location = new System.Drawing.Point(0, 0);
            this.Panel_interduse.Name = "Panel_interduse";
            this.Panel_interduse.Size = new System.Drawing.Size(185, 73);
            this.Panel_interduse.TabIndex = 0;
            // 
            // Pnl_show
            // 
            this.Pnl_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_show.Location = new System.Drawing.Point(0, 0);
            this.Pnl_show.Name = "Pnl_show";
            this.Pnl_show.Size = new System.Drawing.Size(535, 470);
            this.Pnl_show.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 470);
            this.Controls.Add(this.Pnl_show);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btn_calculate_Pnumber;
        private Panel Panel_interduse;
        private Button button2;
        private Panel Pnl_show;
        private Button button1;
    }
}