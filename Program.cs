using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFormForWCF
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new CalculatorForm());

		//	Uri baseAddress = new Uri("http://localhost:58512/Calculator.svc");
			//ServiceHost selfHost = new ServiceHost(typeof( baseAddress);
		}
	}
}
