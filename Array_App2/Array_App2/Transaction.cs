using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_App2
{
	public class Transaction
	{
		private DateTime _date;

		public DateTime Date
		{
			get { return _date; }
			set { _date = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private double _amount;

		public double Amount
		{
			get { return _amount; }
			set { _amount = value; }
		}


		public override string ToString()
		{
			string formattedDate = Date.ToString("yyyy-MM-dd");
			string formattedAmount = Amount.ToString("#.##");
			return $"Date: {formattedDate}, Description: {Description}, Amount: {formattedAmount}";
		}
	}
}
