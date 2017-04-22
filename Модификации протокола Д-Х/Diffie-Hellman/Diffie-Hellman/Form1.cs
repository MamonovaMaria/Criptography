using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diffie_Hellman
{
	public partial class Form1 : Form
	{
		string[] arr1;
		string[] arr2;
		int x;
		int y;
		int p;
		int g;
		int R1;
		int R2;
		RSA key;
		//RSACryptoServiceProvider key = new RSACryptoServiceProvider();
		Encoding enc = Encoding.Default;

		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			arr1 = abonentA.Text.Split('\n');
			string tmp = "";
			foreach (var el in arr1)
			{
				tmp += el;
			}
			arr1 = tmp.Split('\r');


			p = Int32.Parse(textBox3.Text);
			g = Int32.Parse(arr1[0]);


			x = Int32.Parse(arr1[1]);
			R1 = Int32.Parse(Math.Pow(g, x).ToString()) % p;
			button1_Click(sender, e);
			abonentB.AppendText("\r\n" + R1.ToString());
		}

		private void button4_Click(object sender, EventArgs e)
		{
			arr2 = abonentB.Text.Split('\n');
			string tmp = "";
			foreach (var el in arr2)
			{
				tmp += el;
			}
			arr2 = tmp.Split('\r');

			y = Int32.Parse(arr2[1]);
			R2 = Int32.Parse(Math.Pow(g, y).ToString()) % p;
			abonentA.AppendText("\r\n" + R2.ToString());
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			abonentA.Text = textBox4.Text;
			abonentB.Text = textBox4.Text;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int K = Int32.Parse(Math.Pow(R2, x).ToString()) % p;
			abonentA.AppendText("\r\n" + K.ToString());
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int K = Int32.Parse(Math.Pow(R1, y).ToString()) % p;
			abonentB.AppendText("\r\n" + K.ToString());
		}



		int H, m, n, q, a, b, k;

		private void button10_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{

		}

		private void createrKyes()
		{
			H = 9;
			m = 11;
			n = 23;
			q = Int32.Parse(Math.Pow(2, ((n - 1) / m)).ToString()) % n;
			a = 7;
			b = Int32.Parse(Math.Pow(q, a).ToString()) % n;

			k = 3;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//int l = byte.Parse(R1.ToString()).ToString().Length;
			createrKyes();
			int r = (Int32.Parse(Math.Pow(q, k).ToString()) % n) % m;
			int s = Foo(k, m) * (H + a * r) % m;
			textBox1.Text = R1.ToString() + " " + r + " " + s;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			createrKyes();
			int d = Foo(k, m);
			abonentB.AppendText("\r\n" + (Foo(k, m) * (H + a * ((Int32.Parse(Math.Pow(q, k).ToString()) % n) % m)) % m).ToString());

		}


		private static int Foo(int a, int m)
		{
			int x, y;
			int g = GCD(a, m, out x, out y);
			return (x % m + m) % m;
		}

		private static int GCD(int a, int b, out int x, out int y)
		{
			if (a == 0)
			{
				x = 0;
				y = 1;
				return b;
			}
			int x1, y1;
			int d = GCD(b % a, a, out x1, out y1);
			x = y1 - (b / a) * x1;
			y = x1;
			return d;
		}
	}
}
