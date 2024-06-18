namespace Array_App2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lstv_transactions = new ListView();
			label1 = new Label();
			txtdescription = new TextBox();
			mc_date_transaction = new MonthCalendar();
			label2 = new Label();
			label3 = new Label();
			txtamount = new TextBox();
			btn_add = new Button();
			btn_calculate = new Button();
			lb_total = new Label();
			cbClients = new ComboBox();
			label4 = new Label();
			lstvClients = new ListView();
			SuspendLayout();
			// 
			// lstv_transactions
			// 
			lstv_transactions.Location = new Point(12, 12);
			lstv_transactions.Name = "lstv_transactions";
			lstv_transactions.Size = new Size(515, 657);
			lstv_transactions.TabIndex = 0;
			lstv_transactions.UseCompatibleStateImageBehavior = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(570, 12);
			label1.Name = "label1";
			label1.Size = new Size(53, 28);
			label1.TabIndex = 1;
			label1.Text = "Date";
			// 
			// txtdescription
			// 
			txtdescription.Location = new Point(570, 499);
			txtdescription.Multiline = true;
			txtdescription.Name = "txtdescription";
			txtdescription.Size = new Size(290, 60);
			txtdescription.TabIndex = 2;
			// 
			// mc_date_transaction
			// 
			mc_date_transaction.BackColor = SystemColors.WindowFrame;
			mc_date_transaction.Location = new Point(570, 49);
			mc_date_transaction.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
			mc_date_transaction.Name = "mc_date_transaction";
			mc_date_transaction.ShowTodayCircle = false;
			mc_date_transaction.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(570, 468);
			label2.Name = "label2";
			label2.Size = new Size(112, 28);
			label2.TabIndex = 4;
			label2.Text = "Description";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(570, 368);
			label3.Name = "label3";
			label3.Size = new Size(83, 28);
			label3.TabIndex = 6;
			label3.Text = "Amount";
			// 
			// txtamount
			// 
			txtamount.Location = new Point(570, 408);
			txtamount.Name = "txtamount";
			txtamount.Size = new Size(169, 27);
			txtamount.TabIndex = 5;
			// 
			// btn_add
			// 
			btn_add.Font = new Font("Segoe UI", 12F);
			btn_add.Location = new Point(570, 590);
			btn_add.Name = "btn_add";
			btn_add.Size = new Size(127, 47);
			btn_add.TabIndex = 7;
			btn_add.Text = "Add";
			btn_add.UseVisualStyleBackColor = true;
			btn_add.Click += btn_add_Click;
			// 
			// btn_calculate
			// 
			btn_calculate.Font = new Font("Segoe UI", 12F);
			btn_calculate.Location = new Point(312, 724);
			btn_calculate.Name = "btn_calculate";
			btn_calculate.Size = new Size(127, 47);
			btn_calculate.TabIndex = 8;
			btn_calculate.Text = "Calculate";
			btn_calculate.UseVisualStyleBackColor = true;
			btn_calculate.Click += btn_calculate_Click;
			// 
			// lb_total
			// 
			lb_total.AutoSize = true;
			lb_total.Font = new Font("Segoe UI", 12F);
			lb_total.Location = new Point(351, 569);
			lb_total.Name = "lb_total";
			lb_total.Size = new Size(0, 28);
			lb_total.TabIndex = 9;
			// 
			// cbClients
			// 
			cbClients.FormattingEnabled = true;
			cbClients.Items.AddRange(new object[] { "Laura García", "Andrés Martínez" });
			cbClients.Location = new Point(570, 311);
			cbClients.Name = "cbClients";
			cbClients.Size = new Size(227, 28);
			cbClients.TabIndex = 10;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F);
			label4.Location = new Point(570, 280);
			label4.Name = "label4";
			label4.Size = new Size(62, 28);
			label4.TabIndex = 11;
			label4.Text = "Client";
			// 
			// lstvClients
			// 
			lstvClients.Location = new Point(12, 685);
			lstvClients.Name = "lstvClients";
			lstvClients.Size = new Size(284, 121);
			lstvClients.TabIndex = 12;
			lstvClients.UseCompatibleStateImageBehavior = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(965, 837);
			Controls.Add(lstvClients);
			Controls.Add(label4);
			Controls.Add(cbClients);
			Controls.Add(lb_total);
			Controls.Add(btn_calculate);
			Controls.Add(btn_add);
			Controls.Add(label3);
			Controls.Add(txtamount);
			Controls.Add(label2);
			Controls.Add(mc_date_transaction);
			Controls.Add(txtdescription);
			Controls.Add(label1);
			Controls.Add(lstv_transactions);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView lstv_transactions;
		private Label label1;
		private TextBox txtdescription;
		private MonthCalendar mc_date_transaction;
		private Label label2;
		private Label label3;
		private TextBox txtamount;
		private Button btn_add;
		private Button btn_calculate;
		private Label lb_total;
		private ComboBox cbClients;
		private Label label4;
		private ListView lstvClients;
	}
}
