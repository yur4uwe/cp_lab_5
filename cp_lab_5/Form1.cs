using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cp_lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            double a, b, eps;
            int kmax;

            try
            {
                a = double.Parse(ABox.Text);
                b = double.Parse(BBox.Text);
                eps = double.Parse(EpsBox.Text);
                kmax = int.Parse(KmaxBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Input value is too large or too small");
                return;
            }

            if (a >= b) (a, b) = (b, a);

            if (eps <= 0 || kmax <= 0)
            {
                MessageBox.Show("Epsilon and Kmax must be positive");
                return;
            }

            RootFinder rf = new RootFinder(eps, kmax, msg => RootBox.Text = msg, msg => MessageBox.Show(msg), msg => IterBox.Text = msg);

            switch (EquasionBox.SelectedIndex)
            {
                case 0:
                    rf.ChangeFunction(x => x * x - 4);
                    break;
                case 1:
                    rf.ChangeFunction(x => 3 * x - 4 * Math.Log(x) - 5);
                    break;
                case 2:
                    rf.ChangeFunction(x => Math.Exp(x) - 3 * x);
                    break;
                default:
                    MessageBox.Show("Select an equation");
                    return;
            }

            Method method;
            try
            {
                method = (Method)MethodBox.SelectedIndex;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            rf.FindRoot(a, b, method);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox box)
                {
                    box.Clear();
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
