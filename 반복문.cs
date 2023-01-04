using System;

class Program {
  public static void Main (string[] args) {
  // for 반복문 
  for(int i = 1; i<11;i++) //i=i+1 1씩 증가
    Console.WriteLine(i);

Console.WriteLine("*********************");
    
  for(int i =10; i>=1; i--)
    Console.WriteLine(i);
Console.WriteLine("*********************");
      // while 반복문
  int ii = 10; // 초기화
  while(ii>=1) //조건식
    Console.WriteLine(ii--); //증분
Console.WriteLine("*********************");
  int j = 1;
  while(true)
    {
      Console.WriteLine(j);
      j++;

      if(j>10)
        break;
      
    }
  }
  


}