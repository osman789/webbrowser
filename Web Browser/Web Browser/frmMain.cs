using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using EasyTabs;

namespace Web_Browser
{
    public partial class frmMain : Form
    {

        ChromiumWebBrowser browser;

        public frmMain()
        {
            InitializeComponent();
        }

        private void textBoxQuery_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                browser.Load(txtUrl.Text);
   
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            browser.Load(txtUrl.Text);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(txtUrl.Text);
            browser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(browser);
        }
    }   
}
