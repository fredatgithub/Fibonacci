using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using FibonacciDemo.Properties;

namespace FibonacciDemo
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    Int64[] FiboList = new long[100];
    private int _compteurFiboList;

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
      if (FiboList[number] != 0)
      {
        return FiboList[number];
      }

      _compteurFiboList++;
      if (_compteurFiboList < 3)
      {
        FiboList[_compteurFiboList] = Fibonacci(number);
      }
      else
      {
        FiboList[_compteurFiboList] = FiboList[_compteurFiboList -1] + FiboList[_compteurFiboList - 2];
      }
      
      return FiboList[_compteurFiboList];
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
        Application.DoEvents();
        progressBar1.Value = (int)i;
      }

      chrono.Stop();
      label1.Text = "Duration is: \n" + ToHourMinuteSecond(chrono.ElapsedMilliseconds);

      progressBar1.Value = progressBar1.Minimum;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      GetWindowValue();
      DisplayTitle();
      label1.Text = "duration recursive :";
      label2.Text = "duration with memory :";
    }

    private void CalculateWithMemoryClick(object sender, EventArgs e)
    {
      const int mini = 1;
      const int maxi = 93;
      progressBar1.Minimum = mini;
      progressBar1.Maximum = maxi;
      Stopwatch chrono = new Stopwatch();
      progressBar1.Value = progressBar1.Minimum;
      listBox2.Items.Clear();
      chrono.Start();
      for (Int64 i = mini; i < maxi; i++)
      {
        listBox2.Items.Add(i + " = " + GetFibonacci(i));
        Application.DoEvents();
        progressBar1.Value = (int)i;
      }

      chrono.Stop();
      label2.Text = "Duration is: \n" + ToHourMinuteSecond(chrono.ElapsedMilliseconds);

      progressBar1.Value = progressBar1.Minimum;
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    public static string ToHourMinuteSecond(long millisecs)
    {
      TimeSpan t = TimeSpan.FromMilliseconds(millisecs);

      string result = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                     t.Hours,
                     t.Minutes,
                     t.Seconds,
                     t.Milliseconds);
      return result;
    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox1.Items.Count > 0)
      {
        listBox1.SelectedItem = listBox2.SelectedItem;
      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox2.Items.Count > 0)
      {
        listBox2.SelectedItem = listBox1.SelectedItem;
      }
    }
  }
}