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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            FormBooking formBooking = new();
            formBooking.ShowDialog();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new();
            formMenu.ShowDialog();
        }
    }
}
