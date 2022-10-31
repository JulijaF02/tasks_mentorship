using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double radius, area, perimeter;
            radius = Convert.ToDouble(txtRadius.Text);
            area = (radius * radius) * Math.PI;
            perimeter = 2 * (radius * Math.PI);
            lblArea.Text = $"Area: {area}";
            lblPerimeter.Text = $"Perimeter: {perimeter}";
        }
    }
}
