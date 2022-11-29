using BUS;
using GUI.Doctor;
using GUI.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{ 
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmExamine examine = new frmExamine();
            examine.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeBUS employeeBUS = new EmployeeBUS();
            TiepNhanBenhNhan tiepNhanBenhNhan = new TiepNhanBenhNhan(employeeBUS.findByID("NV01"));
            tiepNhanBenhNhan.ShowDialog();
        }
    }
}
