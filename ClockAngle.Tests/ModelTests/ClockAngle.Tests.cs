using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngleA;

namespace ClockAngleA.Tests
{
  [TestClass]
  public class ClockAngleClassTest
  {
    [TestMethod]
    public void clock_Angle()
    {
        // ClockAngleClass testClockAngle = new ClockAngleClass();
        Assert.AreEqual(150, ClockAngleClass.GiveAngle(7,00));
    }
    [TestMethod]
    public void clock_Angle1()
    {
        // ClockAngleClass testClockAngle = new ClockAngleClass();
        Assert.AreEqual(90, ClockAngleClass.GiveAngle(3,00));
    }
    [TestMethod]
    public void clock_Angle2()
    {
        // ClockAngleClass testClockAngle = new ClockAngleClass();
        Assert.AreEqual(60, ClockAngleClass.GiveAngle(5,15));
    }
  }
}
