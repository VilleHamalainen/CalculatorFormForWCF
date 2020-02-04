namespace CalculatorFormForWCF
{
	partial class CalculatorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelNumber1 = new System.Windows.Forms.Label();
			this.labelNumber2 = new System.Windows.Forms.Label();
			this.labelNumber3 = new System.Windows.Forms.Label();
			this.tbNumber1 = new System.Windows.Forms.TextBox();
			this.tbNumber2 = new System.Windows.Forms.TextBox();
			this.tbNumber3 = new System.Windows.Forms.TextBox();
			this.btAdd = new System.Windows.Forms.Button();
			this.btSub = new System.Windows.Forms.Button();
			this.btMult = new System.Windows.Forms.Button();
			this.btDiv = new System.Windows.Forms.Button();
			this.btConnect = new System.Windows.Forms.Button();
			this.btDisconnect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelNumber1
			// 
			this.labelNumber1.AutoSize = true;
			this.labelNumber1.Location = new System.Drawing.Point(12, 41);
			this.labelNumber1.Name = "labelNumber1";
			this.labelNumber1.Size = new System.Drawing.Size(70, 13);
			this.labelNumber1.TabIndex = 0;
			this.labelNumber1.Text = "Enter number";
			// 
			// labelNumber2
			// 
			this.labelNumber2.AutoSize = true;
			this.labelNumber2.Location = new System.Drawing.Point(12, 77);
			this.labelNumber2.Name = "labelNumber2";
			this.labelNumber2.Size = new System.Drawing.Size(70, 13);
			this.labelNumber2.TabIndex = 1;
			this.labelNumber2.Text = "Enter number";
			// 
			// labelNumber3
			// 
			this.labelNumber3.AutoSize = true;
			this.labelNumber3.Location = new System.Drawing.Point(12, 118);
			this.labelNumber3.Name = "labelNumber3";
			this.labelNumber3.Size = new System.Drawing.Size(37, 13);
			this.labelNumber3.TabIndex = 2;
			this.labelNumber3.Text = "Result";
			// 
			// tbNumber1
			// 
			this.tbNumber1.Location = new System.Drawing.Point(95, 38);
			this.tbNumber1.Name = "tbNumber1";
			this.tbNumber1.Size = new System.Drawing.Size(100, 20);
			this.tbNumber1.TabIndex = 3;
			// 
			// tbNumber2
			// 
			this.tbNumber2.Location = new System.Drawing.Point(95, 74);
			this.tbNumber2.Name = "tbNumber2";
			this.tbNumber2.Size = new System.Drawing.Size(100, 20);
			this.tbNumber2.TabIndex = 4;
			// 
			// tbNumber3
			// 
			this.tbNumber3.Location = new System.Drawing.Point(95, 115);
			this.tbNumber3.Name = "tbNumber3";
			this.tbNumber3.Size = new System.Drawing.Size(100, 20);
			this.tbNumber3.TabIndex = 5;
			// 
			// btAdd
			// 
			this.btAdd.Location = new System.Drawing.Point(47, 173);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(75, 23);
			this.btAdd.TabIndex = 6;
			this.btAdd.Text = "Add";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// btSub
			// 
			this.btSub.Location = new System.Drawing.Point(135, 173);
			this.btSub.Name = "btSub";
			this.btSub.Size = new System.Drawing.Size(75, 23);
			this.btSub.TabIndex = 7;
			this.btSub.Text = "Sub";
			this.btSub.UseVisualStyleBackColor = true;
			this.btSub.Click += new System.EventHandler(this.btSub_Click);
			// 
			// btMult
			// 
			this.btMult.Location = new System.Drawing.Point(234, 173);
			this.btMult.Name = "btMult";
			this.btMult.Size = new System.Drawing.Size(75, 23);
			this.btMult.TabIndex = 8;
			this.btMult.Text = "Mult";
			this.btMult.UseVisualStyleBackColor = true;
			this.btMult.Click += new System.EventHandler(this.btMult_Click);
			// 
			// btDiv
			// 
			this.btDiv.Location = new System.Drawing.Point(331, 173);
			this.btDiv.Name = "btDiv";
			this.btDiv.Size = new System.Drawing.Size(75, 23);
			this.btDiv.TabIndex = 9;
			this.btDiv.Text = "Div";
			this.btDiv.UseVisualStyleBackColor = true;
			this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
			// 
			// btConnect
			// 
			this.btConnect.Location = new System.Drawing.Point(234, 36);
			this.btConnect.Name = "btConnect";
			this.btConnect.Size = new System.Drawing.Size(97, 23);
			this.btConnect.TabIndex = 10;
			this.btConnect.Text = "Connect service";
			this.btConnect.UseVisualStyleBackColor = true;
			this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
			// 
			// btDisconnect
			// 
			this.btDisconnect.Location = new System.Drawing.Point(365, 36);
			this.btDisconnect.Name = "btDisconnect";
			this.btDisconnect.Size = new System.Drawing.Size(126, 23);
			this.btDisconnect.TabIndex = 11;
			this.btDisconnect.Text = "Disconnect service";
			this.btDisconnect.UseVisualStyleBackColor = true;
			this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
			// 
			// CalculatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 263);
			this.Controls.Add(this.btDisconnect);
			this.Controls.Add(this.btConnect);
			this.Controls.Add(this.btDiv);
			this.Controls.Add(this.btMult);
			this.Controls.Add(this.btSub);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.tbNumber3);
			this.Controls.Add(this.tbNumber2);
			this.Controls.Add(this.tbNumber1);
			this.Controls.Add(this.labelNumber3);
			this.Controls.Add(this.labelNumber2);
			this.Controls.Add(this.labelNumber1);
			this.Name = "CalculatorForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.CalucatorForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelNumber1;
		private System.Windows.Forms.Label labelNumber2;
		private System.Windows.Forms.Label labelNumber3;
		private System.Windows.Forms.TextBox tbNumber1;
		private System.Windows.Forms.TextBox tbNumber2;
		private System.Windows.Forms.TextBox tbNumber3;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btSub;
		private System.Windows.Forms.Button btMult;
		private System.Windows.Forms.Button btDiv;
		private System.Windows.Forms.Button btConnect;
		private System.Windows.Forms.Button btDisconnect;
	}
}

