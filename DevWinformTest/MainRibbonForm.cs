using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DevWinformTest
{
    public partial class MainRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainRibbonForm()
        {
            InitializeComponent();            
        }

        void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            SymmetricalPlumeConfig form = new SymmetricalPlumeConfig();
            form.ShowDialog();
        }

        private void btn_CopyToClipboard_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Clipboard.SetImage(pictureBox1.Image);
                MessageBox.Show("图片已复制到剪切板", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}