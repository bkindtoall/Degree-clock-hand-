using System;
using System.Linq;
using System.Collections.Generic;


namespace ClockAngleA
{
  public static class ClockAngleClass
  {
    public static int GiveAngle(int hour, int minutes)
    {

      int fullHour = hour*5;
      if(minutes>30){
        minutes=60-minutes;
      }
      int diff = fullHour-minutes;

      int angle = diff * 6;
      if(angle>180){
        angle=360-angle;
      }

      return Math.Abs(angle);
    }
      public static void Main()
    {
      Console.WriteLine("Please enter time in hours: ");
      string userInputHour = Console.ReadLine();
      int hour = int.Parse(userInputHour);
      Console.WriteLine("Please enter time in Minutes: ");
      string userInputMin = Console.ReadLine();
      int minutes = int.Parse(userInputMin);

      Console.WriteLine("The angle in the clock is: " + GiveAngle(hour,minutes)+ "degrees");
    }
  }
}
