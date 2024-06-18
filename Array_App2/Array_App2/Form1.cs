using System.Data.Common;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Array_App2
{
	public partial class Form1 : Form
	{
		Transaction[,,] transaction_log;
		double[,] totalAmounts;


		public Form1()
		{
			InitializeComponent();
			lstv_transactions.View = View.Details;
			lstv_transactions.GridLines = true;
			lstv_transactions.Columns.Add("Date");
			lstv_transactions.Columns.Add("Client");
			lstv_transactions.Columns.Add("Description");
			lstv_transactions.Columns.Add("Amount");

			lstvClients.View = View.Details;
			lstvClients.GridLines = true;
			lstvClients.Columns.Add("Name");
			lstvClients.Columns.Add("Total amount in transactions");
			transaction_log = new Transaction[2, 3, 10];
			totalAmounts = new double[2, 2];
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			int clientIndex = cbClients.SelectedIndex;


			DateTime selectedDate = mc_date_transaction.SelectionStart;


			Transaction transaction = new Transaction
			{
				Date = selectedDate,
				Description = txtdescription.Text,
				Amount = Convert.ToDouble(txtamount.Text)
			};


			ListViewItem newItem = new ListViewItem(new[] {
			transaction.Date.ToString(),
			cbClients.Text,
			transaction.Description,
			transaction.Amount.ToString()
			});

			lstv_transactions.Items.Add(newItem);

			for (int dataIndex = 0; dataIndex < 3; dataIndex++)
			{
				for (int placeIndex = 0; placeIndex < 10; placeIndex++)
				{

					if (transaction_log[clientIndex, dataIndex, placeIndex] == null)
					{
						transaction_log[clientIndex, dataIndex, placeIndex] = transaction;
						break;
					}
				}
			}

		}

		private void btn_calculate_Click(object sender, EventArgs e)
		{
		
			foreach (ListViewItem item in lstv_transactions.Items)
			{
				string clientName = item.SubItems[1].Text;
				double amount = Convert.ToDouble(item.SubItems[3].Text);

				if (clientName == "Laura García")
				{
					totalAmounts[0, 0] += amount; // Suma de montos para el Cliente1
				}
				else if (clientName == "Andrés Martínez")
				{
					totalAmounts[1, 0] += amount; // Suma de montos para el Cliente2
				}
			}

			lstvClients.Items.Clear();

			for (int i = 0; i < 2; i++)
			{
				string clientName = (i == 0) ? "Laura García" : "Andrés Martínez"; 

				ListViewItem newItem = new ListViewItem(new[] {
				clientName,
				totalAmounts[i, 0].ToString() 
			     });

				lstvClients.Items.Add(newItem);
			}
		}
	}

}
