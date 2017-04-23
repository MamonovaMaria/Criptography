namespace Diffie_Hellman
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.abonentA = new System.Windows.Forms.TextBox();
			this.textBoxP = new System.Windows.Forms.TextBox();
			this.textBoxG = new System.Windows.Forms.TextBox();
			this.buttonForEncriptA = new System.Windows.Forms.Button();
			this.buttonForSendToB = new System.Windows.Forms.Button();
			this.buttonForEncriptB = new System.Windows.Forms.Button();
			this.buttonForSendToA = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelAbonentA = new System.Windows.Forms.Label();
			this.labelAbonentB = new System.Windows.Forms.Label();
			this.abonentB = new System.Windows.Forms.TextBox();
			this.buttonForKA = new System.Windows.Forms.Button();
			this.buttonForKB = new System.Windows.Forms.Button();
			this.textBoxForMessage = new System.Windows.Forms.TextBox();
			this.buttonForDecriptFromA = new System.Windows.Forms.Button();
			this.buttonForDecriptFromB = new System.Windows.Forms.Button();
			this.buttonForR1 = new System.Windows.Forms.Button();
			this.buttonForR2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// abonentA
			// 
			this.abonentA.Location = new System.Drawing.Point(50, 52);
			this.abonentA.Multiline = true;
			this.abonentA.Name = "abonentA";
			this.abonentA.Size = new System.Drawing.Size(271, 254);
			this.abonentA.TabIndex = 0;
			// 
			// textBoxP
			// 
			this.textBoxP.Location = new System.Drawing.Point(379, 26);
			this.textBoxP.Name = "textBoxP";
			this.textBoxP.Size = new System.Drawing.Size(51, 20);
			this.textBoxP.TabIndex = 2;
			// 
			// textBoxG
			// 
			this.textBoxG.Location = new System.Drawing.Point(476, 26);
			this.textBoxG.Name = "textBoxG";
			this.textBoxG.Size = new System.Drawing.Size(51, 20);
			this.textBoxG.TabIndex = 3;
			this.textBoxG.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// buttonForEncriptA
			// 
			this.buttonForEncriptA.Location = new System.Drawing.Point(327, 119);
			this.buttonForEncriptA.Name = "buttonForEncriptA";
			this.buttonForEncriptA.Size = new System.Drawing.Size(103, 27);
			this.buttonForEncriptA.TabIndex = 4;
			this.buttonForEncriptA.Text = "Подписать";
			this.buttonForEncriptA.UseVisualStyleBackColor = true;
			this.buttonForEncriptA.Click += new System.EventHandler(this.buttonForEncriptA_Click);
			// 
			// buttonForSendToB
			// 
			this.buttonForSendToB.Location = new System.Drawing.Point(327, 170);
			this.buttonForSendToB.Name = "buttonForSendToB";
			this.buttonForSendToB.Size = new System.Drawing.Size(103, 27);
			this.buttonForSendToB.TabIndex = 5;
			this.buttonForSendToB.Text = "Отправить";
			this.buttonForSendToB.UseVisualStyleBackColor = true;
			this.buttonForSendToB.Click += new System.EventHandler(this.buttonForSendToB_Click);
			// 
			// buttonForEncriptB
			// 
			this.buttonForEncriptB.Location = new System.Drawing.Point(476, 229);
			this.buttonForEncriptB.Name = "buttonForEncriptB";
			this.buttonForEncriptB.Size = new System.Drawing.Size(103, 27);
			this.buttonForEncriptB.TabIndex = 6;
			this.buttonForEncriptB.Text = "Подписать";
			this.buttonForEncriptB.UseVisualStyleBackColor = true;
			this.buttonForEncriptB.Click += new System.EventHandler(this.buttonForEncriptB_Click);
			// 
			// buttonForSendToA
			// 
			this.buttonForSendToA.Location = new System.Drawing.Point(476, 279);
			this.buttonForSendToA.Name = "buttonForSendToA";
			this.buttonForSendToA.Size = new System.Drawing.Size(103, 27);
			this.buttonForSendToA.TabIndex = 7;
			this.buttonForSendToA.Text = "Отправить";
			this.buttonForSendToA.UseVisualStyleBackColor = true;
			this.buttonForSendToA.Click += new System.EventHandler(this.buttonForSendToA_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(396, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "p";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(491, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "g";
			// 
			// labelAbonentA
			// 
			this.labelAbonentA.AutoSize = true;
			this.labelAbonentA.Location = new System.Drawing.Point(47, 36);
			this.labelAbonentA.Name = "labelAbonentA";
			this.labelAbonentA.Size = new System.Drawing.Size(38, 13);
			this.labelAbonentA.TabIndex = 10;
			this.labelAbonentA.Text = "Алиса";
			// 
			// labelAbonentB
			// 
			this.labelAbonentB.AutoSize = true;
			this.labelAbonentB.Location = new System.Drawing.Point(582, 36);
			this.labelAbonentB.Name = "labelAbonentB";
			this.labelAbonentB.Size = new System.Drawing.Size(26, 13);
			this.labelAbonentB.TabIndex = 11;
			this.labelAbonentB.Text = "Боб";
			// 
			// abonentB
			// 
			this.abonentB.Location = new System.Drawing.Point(585, 52);
			this.abonentB.Multiline = true;
			this.abonentB.Name = "abonentB";
			this.abonentB.Size = new System.Drawing.Size(271, 254);
			this.abonentB.TabIndex = 12;
			// 
			// buttonForKA
			// 
			this.buttonForKA.Location = new System.Drawing.Point(327, 279);
			this.buttonForKA.Name = "buttonForKA";
			this.buttonForKA.Size = new System.Drawing.Size(103, 27);
			this.buttonForKA.TabIndex = 13;
			this.buttonForKA.Text = "Вычислить";
			this.buttonForKA.UseVisualStyleBackColor = true;
			this.buttonForKA.Click += new System.EventHandler(this.buttonForKA_Click);
			// 
			// buttonForKB
			// 
			this.buttonForKB.Location = new System.Drawing.Point(476, 170);
			this.buttonForKB.Name = "buttonForKB";
			this.buttonForKB.Size = new System.Drawing.Size(103, 27);
			this.buttonForKB.TabIndex = 14;
			this.buttonForKB.Text = "Вычислить";
			this.buttonForKB.UseVisualStyleBackColor = true;
			this.buttonForKB.Click += new System.EventHandler(this.buttonForKB_Click);
			// 
			// textBoxForMessage
			// 
			this.textBoxForMessage.Location = new System.Drawing.Point(327, 203);
			this.textBoxForMessage.Name = "textBoxForMessage";
			this.textBoxForMessage.Size = new System.Drawing.Size(252, 20);
			this.textBoxForMessage.TabIndex = 16;
			// 
			// buttonForDecriptFromA
			// 
			this.buttonForDecriptFromA.Location = new System.Drawing.Point(476, 119);
			this.buttonForDecriptFromA.Name = "buttonForDecriptFromA";
			this.buttonForDecriptFromA.Size = new System.Drawing.Size(103, 27);
			this.buttonForDecriptFromA.TabIndex = 17;
			this.buttonForDecriptFromA.Text = "Проверить";
			this.buttonForDecriptFromA.UseVisualStyleBackColor = true;
			this.buttonForDecriptFromA.Click += new System.EventHandler(this.buttonForDecriptFromA_Click);
			// 
			// buttonForDecriptFromB
			// 
			this.buttonForDecriptFromB.Location = new System.Drawing.Point(327, 229);
			this.buttonForDecriptFromB.Name = "buttonForDecriptFromB";
			this.buttonForDecriptFromB.Size = new System.Drawing.Size(103, 27);
			this.buttonForDecriptFromB.TabIndex = 18;
			this.buttonForDecriptFromB.Text = "Проверить";
			this.buttonForDecriptFromB.UseVisualStyleBackColor = true;
			this.buttonForDecriptFromB.Click += new System.EventHandler(this.buttonForDecriptFromB_Click);
			// 
			// buttonForR1
			// 
			this.buttonForR1.Location = new System.Drawing.Point(327, 52);
			this.buttonForR1.Name = "buttonForR1";
			this.buttonForR1.Size = new System.Drawing.Size(103, 27);
			this.buttonForR1.TabIndex = 19;
			this.buttonForR1.Text = "Посчитать";
			this.buttonForR1.UseVisualStyleBackColor = true;
			this.buttonForR1.Click += new System.EventHandler(this.buttonForR1_Click);
			// 
			// buttonForR2
			// 
			this.buttonForR2.Location = new System.Drawing.Point(476, 52);
			this.buttonForR2.Name = "buttonForR2";
			this.buttonForR2.Size = new System.Drawing.Size(103, 27);
			this.buttonForR2.TabIndex = 20;
			this.buttonForR2.Text = "Посчитать";
			this.buttonForR2.UseVisualStyleBackColor = true;
			this.buttonForR2.Click += new System.EventHandler(this.buttonForR2_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Info;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(210, 342);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(500, 183);
			this.textBox1.TabIndex = 21;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 550);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonForR2);
			this.Controls.Add(this.buttonForR1);
			this.Controls.Add(this.buttonForDecriptFromB);
			this.Controls.Add(this.buttonForDecriptFromA);
			this.Controls.Add(this.textBoxForMessage);
			this.Controls.Add(this.buttonForKB);
			this.Controls.Add(this.buttonForKA);
			this.Controls.Add(this.abonentB);
			this.Controls.Add(this.labelAbonentB);
			this.Controls.Add(this.labelAbonentA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonForSendToA);
			this.Controls.Add(this.buttonForEncriptB);
			this.Controls.Add(this.buttonForSendToB);
			this.Controls.Add(this.buttonForEncriptA);
			this.Controls.Add(this.textBoxG);
			this.Controls.Add(this.textBoxP);
			this.Controls.Add(this.abonentA);
			this.Name = "Form1";
			this.Text = "Протокол Дииффи-Хееллмана";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox abonentA;
		private System.Windows.Forms.TextBox textBoxP;
		private System.Windows.Forms.TextBox textBoxG;
		private System.Windows.Forms.Button buttonForEncriptA;
		private System.Windows.Forms.Button buttonForSendToB;
		private System.Windows.Forms.Button buttonForEncriptB;
		private System.Windows.Forms.Button buttonForSendToA;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelAbonentA;
		private System.Windows.Forms.Label labelAbonentB;
		private System.Windows.Forms.TextBox abonentB;
		private System.Windows.Forms.Button buttonForKA;
		private System.Windows.Forms.Button buttonForKB;
		private System.Windows.Forms.TextBox textBoxForMessage;
		private System.Windows.Forms.Button buttonForDecriptFromA;
		private System.Windows.Forms.Button buttonForDecriptFromB;
		private System.Windows.Forms.Button buttonForR1;
		private System.Windows.Forms.Button buttonForR2;
		private System.Windows.Forms.TextBox textBox1;
	}
}

