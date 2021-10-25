using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Third_Lab
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            if (firstX.Text == "" || firstY.Text == "" || firstZ.Text == "" || secondX.Text == "" || secondY.Text == "" || secondZ.Text == "" ||
                firstX.Text == "-" || firstY.Text == "-" || firstZ.Text == "-" || secondX.Text == "-" || secondY.Text == "-" || secondZ.Text == "-")
            {
                return;
            }
            try
            {
                var x1 = double.Parse(firstX.Text);
                var y1 = double.Parse(firstY.Text);
                var z1 = double.Parse(firstZ.Text);
                var x2 = double.Parse(secondX.Text);
                var y2 = double.Parse(secondY.Text);
                var z2 = double.Parse(secondZ.Text);

                var vector1 = new Vector(x1, y1, z1);
                var vector2 = new Vector(x2, y2, z2);
                var action = actionBox.Text;

                Vector vector3 = new Vector(0, 0, 0);

                switch (action)
                {
                    case "+":
                        vector3 = vector1 + vector2;
                        break;
                    case "-":
                        vector3 = vector1 - vector2;
                        break;
                    case "*":
                        vector3 = vector1 ^ vector2;
                        break;
                }

                resultX.Text = vector3.X.ToString();
                resultY.Text = vector3.Y.ToString();
                resultZ.Text = vector3.Z.ToString();

                scalarProduct.Text = (vector1 * vector2).ToString();
                length1.Text = vector1.Length.ToString();
                length2.Text = vector2.Length.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Values_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back || e.KeyChar == '-')
            { 
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        private void actionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void actionBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
