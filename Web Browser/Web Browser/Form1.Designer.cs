namespace Web_Browser
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonFor = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.bntGo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonBack.Location = new System.Drawing.Point(12, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 30);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Backward";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFor
            // 
            this.buttonFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonFor.Location = new System.Drawing.Point(110, 5);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(75, 30);
            this.buttonFor.TabIndex = 3;
            this.buttonFor.Text = "Foward";
            this.buttonFor.UseVisualStyleBackColor = false;
            this.buttonFor.Click += new System.EventHandler(this.buttonFor_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.Color.Khaki;
            this.buttonReload.Location = new System.Drawing.Point(212, 5);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 30);
            this.buttonReload.TabIndex = 4;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(394, 10);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(1392, 20);
            this.txtUrl.TabIndex = 5;
            this.txtUrl.TextChanged += new System.EventHandler(this.textBoxQuery_TextChanged);
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.BackColor = System.Drawing.Color.LightGreen;
            this.buttonGo.Location = new System.Drawing.Point(1792, 5);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 30);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = false;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHome.Location = new System.Drawing.Point(313, 5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 30);
            this.buttonHome.TabIndex = 7;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // bntGo
            // 
            this.bntGo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntGo.BackColor = System.Drawing.SystemColors.Control;
            this.bntGo.Location = new System.Drawing.Point(12, 41);
            this.bntGo.Name = "bntGo";
            this.bntGo.Size = new System.Drawing.Size(1855, 850);
            this.bntGo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1881, 903);
            this.Controls.Add(this.bntGo);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.buttonBack);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel bntGo;
    }
}

