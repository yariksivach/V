using System;
class HelloWorld {
  static void Main() {
    int age = 12;
    string name = "ZV";
    bool isGoa1 = true;
    Console.WriteLine(age + name) ;
    
    
    if ((age < 10) && (age > 10) ) {
        Console.WriteLine("Loh");
    }
    else {
        Console.WriteLine("Ne loh");
    }
    for (int i = 0; i < 100; i++);
    {
        // Console.WriteLine("Текущий проход по циклу" + i);
    }
    int a = 10;
    while (a <= 100) {
        Console.WriteLine("Текущий проход по циклу" + a);
        a = a + 10 ;
    }
  }
}
