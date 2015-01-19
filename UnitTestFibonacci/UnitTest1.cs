using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciDemo;

namespace UnitTestFibonacci
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestToHourMinuteSecond()
    {
      Assert.AreEqual("00h:00m:00s:019ms", FormMain.ToHourMinuteSecond(19));
      Assert.AreEqual("00h:00m:01s:000ms", FormMain.ToHourMinuteSecond(1000));
      Assert.AreEqual("00h:01m:00s:000ms", FormMain.ToHourMinuteSecond(60000));
      Assert.AreEqual("01h:00m:00s:000ms", FormMain.ToHourMinuteSecond(3600000));
      Assert.AreEqual("00h:00m:00s:000ms", FormMain.ToHourMinuteSecond(0));
    }

    [TestMethod]
    public void TestMethod1()
    {
      Assert.AreEqual(0, 0);
    }
  }
}