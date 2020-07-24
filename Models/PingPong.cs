namespace PingPong.Models{
  public class PingAndOrPong{
    public static bool isDivisibleByThreeOrFive(int number){
      return ((number % 3) == 0) || ((number % 5) == 0);
    }


  }

}