using System;

public static class Kata
{
  public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
  {
      if(distanceToPump <= mpg * fuelLeft){
      return true;
    }
    else{
      return false;
    }
    throw new NotImplementedException();
  }
}
    
  
