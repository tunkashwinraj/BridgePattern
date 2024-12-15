using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern_1262774
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBridgeBasic_Click(object sender, EventArgs e)
        {
            Abstraction abs = new Abstraction(new ImplementationA());
            string res1 = abs.Operation();
            string res2 = abs.OperationGreet("Bill");
            MessageBox.Show(res1 + "\n" + res2);

            // Switch to a different implementation
            abs = new Abstraction(new ImplementationB());
            res1 = abs.Operation();
            res2 = abs.OperationGreet("Bill");
            MessageBox.Show(res1 + "\n" + res2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRefinedAbstraction_Click(object sender, EventArgs e)
        {
            RefinedAbstraction rabs = new RefinedAbstraction(new ImplementationA());
            string res1 = rabs.Operation();
            string res2 = rabs.OperationGreet("Bill");
            string res3 = rabs.OperationGreetTime("Sally");
            MessageBox.Show(res1 + "\n" + res2 + "\n" + res3);
        }

    }
}
