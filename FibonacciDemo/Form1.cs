using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace FibonacciDemo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    Int64[] FiboList = new long[100];
    private int compteurFiboList = 0;

    private Int64 Fibonacci(Int64 number)
    {
      if (number <= 2)
      {
        return 1;
      }

      return Fibonacci(number - 1) + Fibonacci(number - 2);
    }

    private Int64 GetFibonacci(Int64 number)
    {
      if (FiboList.Contains(number))
      {
        return FiboList[number];
      }

      compteurFiboList++;
      FiboList[compteurFiboList] = Fibonacci(number);
      return FiboList[compteurFiboList];
    }

    private void buttonCalculate_Click(object sender, EventArgs e)
    {
      const int mini = 1;
      const int maxi = 47;
      progressBar1.Minimum = mini;
      progressBar1.Maximum = maxi;
      Stopwatch chrono = new Stopwatch();
      progressBar1.Value = progressBar1.Minimum;
      listBox1.Items.Clear();
      chrono.Start();
      for (Int64 i = mini; i < maxi; i++)
      {
        listBox1.Items.Add(i + " = " + Fibonacci(i));
        listBox2.Items.Add(GetFibonacci(i));
        Application.DoEvents();
        progressBar1.Value = (int)i;
      }

      chrono.Stop();
      label1.Text = "Duration is: " + chrono.ElapsedMilliseconds;

      progressBar1.Value = progressBar1.Minimum;
    }
  }
}