﻿namespace Diffie_Hellman
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
			this.abonentA = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelAbonentA = new System.Windows.Forms.Label();
			this.labelAbonentB = new System.Windows.Forms.Label();
			this.abonentB = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// abonentA
			// 
			this.abonentA.Location = new System.Drawing.Point(31, 130);
			this.abonentA.Multiline = true;
			this.abonentA.Name = "abonentA";
			this.abonentA.Size = new System.Drawing.Size(271, 331);
			this.abonentA.TabIndex = 0;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(374, 55);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(51, 20);
			this.textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(532, 55);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(51, 20);
			this.textBox4.TabIndex = 3;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(322, 206);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 27);
			this.button1.TabIndex = 4;
			this.button1.Text = "Подписать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(322, 277);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 27);
			this.button2.TabIndex = 5;
			this.button2.Text = "Отправить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(532, 206);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(103, 27);
			this.button3.TabIndex = 6;
			this.button3.Text = "Подписать";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(532, 336);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(103, 27);
			this.button4.TabIndex = 7;
			this.button4.Text = "Отправить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(391, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "p";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(547, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "g";
			// 
			// labelAbonentA
			// 
			this.labelAbonentA.AutoSize = true;
			this.labelAbonentA.Location = new System.Drawing.Point(28, 114);
			this.labelAbonentA.Name = "labelAbonentA";
			this.labelAbonentA.Size = new System.Drawing.Size(38, 13);
			this.labelAbonentA.TabIndex = 10;
			this.labelAbonentA.Text = "Алиса";
			// 
			// labelAbonentB
			// 
			this.labelAbonentB.AutoSize = true;
			this.labelAbonentB.Location = new System.Drawing.Point(657, 114);
			this.labelAbonentB.Name = "labelAbonentB";
			this.labelAbonentB.Size = new System.Drawing.Size(26, 13);
			this.labelAbonentB.TabIndex = 11;
			this.labelAbonentB.Text = "Боб";
			// 
			// abonentB
			// 
			this.abonentB.Location = new System.Drawing.Point(660, 130);
			this.abonentB.Multiline = true;
			this.abonentB.Name = "abonentB";
			this.abonentB.Size = new System.Drawing.Size(271, 331);
			this.abonentB.TabIndex = 12;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(322, 434);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(103, 27);
			this.button5.TabIndex = 13;
			this.button5.Text = "Вычислить";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(532, 434);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(103, 27);
			this.button6.TabIndex = 14;
			this.button6.Text = "Вычислить";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(434, 544);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(103, 27);
			this.button7.TabIndex = 15;
			this.button7.Text = "Отправить";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(322, 310);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(313, 20);
			this.textBox1.TabIndex = 16;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(532, 277);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(103, 27);
			this.button8.TabIndex = 17;
			this.button8.Text = "Проверить";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(322, 336);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(103, 27);
			this.button9.TabIndex = 18;
			this.button9.Text = "Проверить";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(322, 130);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(103, 27);
			this.button10.TabIndex = 19;
			this.button10.Text = "Посчитать";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(532, 130);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(103, 27);
			this.button11.TabIndex = 20;
			this.button11.Text = "Посчитать";
			this.button11.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 598);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.abonentB);
			this.Controls.Add(this.labelAbonentB);
			this.Controls.Add(this.labelAbonentA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.abonentA);
			this.Name = "Form1";
			this.Text = "Протокол Дииффи-Хееллмана";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox abonentA;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelAbonentA;
		private System.Windows.Forms.Label labelAbonentB;
		private System.Windows.Forms.TextBox abonentB;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
	}
}

