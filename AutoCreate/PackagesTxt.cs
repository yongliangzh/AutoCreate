using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCreate
{
    public partial class PackagesTxt : Form
    {
        public PackagesTxt(string txtRcd,string txtInto1,string txtAs1)
        {
            InitializeComponent();
            txtRecord.Text = txtRcd;
            txtInto.Text = txtInto1;
            txtAs.Text = txtAs1;
        }
    }
}
