using BUS;
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
    public partial class Form1 : Form
    {
        DoctorBUS doctorBUS;
        public Form1()
        {
            InitializeComponent();
            doctorBUS = new DoctorBUS();
        }

        private void FindAllDoctor()
        {
            dataGridView1.DataSource = null;
            doctorBUS.FindAllDoctor(dataGridView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FindAllDoctor();
        }
    }
}
