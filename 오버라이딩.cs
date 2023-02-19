using System;
// 오버라이딩 
class Robot{
  //public void Move(object){
  //  Console.WriteLine("로봇이 움직입니다.");
  public void Move(){
    Console.WriteLine("로봇이 움직입니다.");
  //}
  }
}

class CleanRobot : Robot{
  public void Move(){
    Console.WriteLine("청소로봇이 움직입니다.");
  }
  //public void Clean(){
   // Console.WriteLine("로봇이 청소를 합니다.");
  //}
}

class RescueRobot:Robot{
  public void Move(){
    Console.WriteLine("구조 로봇이 이동합니다.");
  }
}

class Program {
  
  public static void Main (string[] args) {
    //CleanRobot cr = new CleanRobot();
   // cr.Move();
   // cr.Clean();
    CleanRobot cr = new CleanRobot();
    RescueRobot rr = new RescueRobot();
    cr.Move();
    rr.Move();
    
  }
}