using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using WindowsApplication1.Properties;

namespace WindowsApplication1
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(galleryControl1);
            UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
            Settings.Default.Save();
        }
    }
}