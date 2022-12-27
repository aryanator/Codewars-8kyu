using System.Linq;
using System;

public static class Kata 
{
    public static int summation(int num)
    {
      int s=0;
      for (int i=1;i<=num;i++){
        s=s+i;  
      }
      return s;
    }
}
