using System;

class Cat{
  public string Name;

  public Cat(string name){
   Name = name;
   Console.WriteLine("고양이의 이름은 "+Name+"입니다.");
}  
  }


class Program {
  public static void Main (string[] args) {
    Cat coco = new Cat("코코");
    coco.Name="몰리";
    Console.WriteLine("고양이의 이름은 "+coco.Name+"입니다.");
  }
}//클래스의 데이터 전달 - 멤버 변수