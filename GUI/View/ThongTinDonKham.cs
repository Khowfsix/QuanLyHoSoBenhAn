using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View
{
    public partial class ThongTinDonKham : Form
    {
        private func_getExamWithID_Result singleExam = null;

        public ThongTinDonKham(func_getExamWithID_Result thisExam)
        {
            singleExam = thisExam;
            InitializeComponent();
        }
    }
}
