using System.Collections.Generic;

namespace PingPong.Models{
  public class PingAndOrPong{
    
    private static bool isDivisibleByThreeOrFive(int number){
      return ((number % 3) == 0) || ((number % 5) == 0);
    }

    private static bool isDivisibleByThreeAndFive(int number){
      return ((number % 3) == 0) && ((number % 5) == 0);
    }

    private static bool isDivisibleByThree(int number){
      return ((number % 3) == 0);
    }

    private static string returnPingOrPongOrPingPong(int number){
      if (!isDivisibleByThreeOrFive(number)){
        return number.ToString();
      }
      if (isDivisibleByThreeAndFive(number)){
        return "ping pong";
      }
      if(isDivisibleByThree(number)){
        return "ping";
      }
      else{
        return "pong";
      }

    }

    public static List<string> createListWithInputNumber(int number){
      List<string> stringReturn = new List<string>();
      for(int i = 0; i <= number; i++){
        stringReturn.Add(returnPingOrPongOrPingPong(i));
      }
      return stringReturn;
    }
  }
}