using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astraia
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		public double TotalCost(double pCost, double cRate)
		{
			/*Method which is used to calculate*/
			double CR = (cRate + 100) / 100;
			return pCost * CR;
		}
		/*This code would find the amount of VAT the user is going to pay.
		 * We can do this by first working out the total cost of the product including VAT, 
		 * and then we can subtract the new cost from the old cost.*/
		public double vatAmount(double pCost, double cRate)
		{
			double vA = (cRate + 100) / 100;
			double tCost = pCost * vA;
			double result = tCost - pCost;
			return result;
		}
		/*final calculation we are going to work out the amount of VAT paid and the original
		 * price when VAT is already included. We can work this out by first getting the
		 * percentage multiplier for the current VAT rate
		 * then divide the product cost by the percentage multiplier*/
		public double origPrice(double incVAT, double cRate)
		{
			double cPrice = (cRate + 100) / 100;
			double oPrice = incVAT / cPrice;
			return incVAT - oPrice;
		}
	}
}




