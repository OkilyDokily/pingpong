using System.Collections.Generic;

namespace PingPong.Models{
  public class PingAndOrPong{
    private static List<string> _string = new List<string>();
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
      for(int i = 0; i <= number; i++){
        _string.Add(returnPingOrPongOrPingPong(i));
      }

      return _string;
    }

  }

}