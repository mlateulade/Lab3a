using System;

class MainClass {
  public static void Main (string[] args){


    Console.WriteLine("Enter temperature in Celsius");
    var temp = Console.ReadLine();

    double cel = Convert.ToDouble(temp);
    double far = (cel * 9/5) + 32;
    Console.WriteLine("Farenheit equivalent for " + temp + " degree celsius is " + far);

    if(far <= 32)
    {
      Console.WriteLine("This temperature is below freezing temperature of 32 degree Farenheit");
    }
    else if (far >= 212)
    {
      Console.WriteLine("This temperature is above boiling point temperature of 212 degree Farenheit");
    }
    //I added this part for practice and see if it would work. I'm sorry if isn't part of the assignment, please delete if not allowed
    else
    {
      Console.WriteLine("This temperature is neither freezing nor boiling!");
    }



    


  }
}