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

            double a = 0, b = 1, eps = 1e-6;
            int kmax = 100;
            var tip = new ToolTip();

            try
            {
                a = double.Parse(ABox.Text);
            }
            catch
            {
                tip.Show("Defaulted to 0", ABox, 0, -20, 2000);
                a = 0;
            }

            try
            {
                b = double.Parse(BBox.Text);
            }
            catch
            {
                tip.Show("Defaulted to 1", BBox, 0, -20, 2000);
                b = 1;
            }

            try
            {
                eps = double.Parse(EpsBox.Text);
            }
            catch
            {
                tip.Show("Defaulted to 1e-6", EpsBox, 0, -20, 2000);
                eps = 1e-6;
            }

            if (method == Method.Newton)
            {
                try
                {
                    kmax = int.Parse(KmaxBox.Text);
                }
                catch
                {
                    tip.Show("Defaulted to 100", KmaxBox, 0, -20, 2000);
                    kmax = 100;
                }
            }

            if (a >= b) (a, b) = (b, a);

            if (eps <= 0)
            {
                MessageBox.Show("Epsilon must be positive");
                return;
            }

            if (method == Method.Newton && kmax <= 0)
            {
                MessageBox.Show("Max iterations must be positive");
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
