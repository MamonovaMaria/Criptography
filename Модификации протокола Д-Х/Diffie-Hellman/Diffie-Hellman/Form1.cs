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
		int H, m, n, q, a, b, k, s, r;
		string message;

		public Form1()
		{
			InitializeComponent();
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			abonentA.Text = textBoxG.Text;
			abonentB.Text = textBoxG.Text;
		}


		private void buttonForR1_Click(object sender, EventArgs e)
		{
			arr1 = abonentA.Text.Split('\n');
			string tmp = "";
			foreach (var el in arr1)
			{
				tmp += el;
			}
			arr1 = tmp.Split('\r');


			p = Int32.Parse(textBoxP.Text);
			g = Int32.Parse(arr1[0]);


			x = Int32.Parse(arr1[1]);
			R1 = Int32.Parse(Math.Pow(g, x).ToString()) % p;
			abonentA.AppendText("\r\n" + R1.ToString());
		}

		private void buttonForR2_Click(object sender, EventArgs e)
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
			abonentB.AppendText("\r\n" + R2.ToString());
		}


		private void buttonForEncriptA_Click(object sender, EventArgs e)
		{
			createrKyes(R1);
			r = (Int32.Parse(Math.Pow(q, k).ToString()) % n) % m;
			s = Foo(k, m) * (H + a * r) % m;
			message = R1.ToString() + " " + r + " " + s;
		}

		private void buttonForEncriptB_Click(object sender, EventArgs e)
		{
			createrKyes(R2);
			r = (Int32.Parse(Math.Pow(q, k).ToString()) % n) % m;
			s = Foo(k, m) * (H + a * r) % m;
			message = R2.ToString() + " " + r + " " + s;
		}


		private void buttonForSendToB_Click(object sender, EventArgs e)
		{
			textBoxForMessage.Text = message;
		}

		private void buttonForSendToA_Click(object sender, EventArgs e)
		{
			textBoxForMessage.Text = message;
		}


		private void buttonForDecriptFromA_Click(object sender, EventArgs e)
		{
			string[] tmp = textBoxForMessage.Text.Split(' ');
			H = Int32.Parse(tmp[0]);
			int w = Foo(s, m) % m;
			int u1 = H * w % m;
			int u2 = r * w % m;
			double v = ((Math.Pow(q, u1)*Math.Pow(b, u2)) % n) % m;
			if (v == r)
				abonentB.AppendText("\r\n" + R1.ToString());
			else
				abonentB.AppendText("\r\n" + "Злоумышленник на линии!");
		}

		private void buttonForDecriptFromB_Click(object sender, EventArgs e)
		{
			string[] tmp = textBoxForMessage.Text.Split(' ');
			H = Int32.Parse(tmp[0]);
			int w = Foo(s, m) % m;
			int u1 = H * w % m;
			int u2 = r * w % m;
			double v = ((Math.Pow(q, u1) * Math.Pow(b, u2)) % n) % m;
			if (v == r)
				abonentA.AppendText("\r\n" + R2.ToString());
			else
				abonentA.AppendText("\r\n" + "Злоумышленник на линии!");
		}



		private void buttonForKA_Click(object sender, EventArgs e)
		{
			int K = Int32.Parse(Math.Pow(R2, x).ToString()) % p;
			abonentA.AppendText("\r\n" + K.ToString());
		}

		private void buttonForKB_Click(object sender, EventArgs e)
		{
			int K = Int32.Parse(Math.Pow(R1, y).ToString()) % p;
			abonentB.AppendText("\r\n" + K.ToString());
		}



		private void createrKyes(int tmp)
		{
			H = tmp.GetHashCode();
			m = 11;
			n = 23;
			q = Int32.Parse(Math.Pow(2, ((n - 1) / m)).ToString()) % n;
			a = 7;
			b = Int32.Parse(Math.Pow(q, a).ToString()) % n;

			k = 3;
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
