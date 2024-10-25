using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop.GUI
{
    public partial class FormManage : Form
    {
        public FormManage()
        {
            InitializeComponent();
        }

        private void mnt_category_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.ShowDialog();
        }

        private void mnt_role_Click(object sender, EventArgs e)
        {
            FormRole formRole = new FormRole(); 
            formRole.ShowDialog();
        }
    }
}
