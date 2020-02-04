using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace CalculatorFormForWCF
{
	public partial class CalculatorForm : Form
	{
        ServiceReference1.CalculatorClient laskin;
        public CalculatorForm()
		{
			InitializeComponent();
		}

  
        // creating object(some times called Proxi) of service under ServiceReferences1
        private void CalucatorForm_Load(object sender, EventArgs e)
        {
            
          //  laskin = new ServiceReference1.CalculatorClient();
            tbNumber3.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           tbNumber3.Text = laskin.Add (Convert.ToDouble(tbNumber1.Text), Convert.ToDouble(tbNumber2.Text)).ToString();
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            tbNumber3.Text = laskin.Subtract(Convert.ToDouble(tbNumber1.Text), Convert.ToDouble(tbNumber2.Text)).ToString();
        }

        private void btMult_Click(object sender, EventArgs e)
        {

           tbNumber3.Text = laskin.Multiply(Convert.ToDouble(tbNumber1.Text), Convert.ToDouble(tbNumber2.Text)).ToString();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            // using the operatiContrscted methos of service cotrcted in WCF of ICalculator which is defined in Calculator service

            tbNumber3.Text = laskin.Divide(Convert.ToDouble(tbNumber1.Text), Convert.ToDouble(tbNumber2.Text)).ToString();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try { 
            
            laskin = new ServiceReference1.CalculatorClient();
          //  laskin.Open();
            btDisconnect.Enabled = true;
            btDisconnect.Enabled = false;
            MessageBox.Show("Connection open");
          
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try { 
            laskin.Close();
            btDisconnect.Enabled = true;
            btDisconnect.Enabled = false;
            MessageBox.Show("Connection closed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
