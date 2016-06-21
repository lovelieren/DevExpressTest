using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevWinformTest
{
    public partial class SymmetricalPlumeConfig : DevExpress.XtraEditors.XtraForm
    {
        public SymmetricalPlumeConfig()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MainRibbonForm mainForm = new MainRibbonForm();            
            mainForm.ShowDialog();
            this.Close();            
            this.Dispose();
        }
    }
}