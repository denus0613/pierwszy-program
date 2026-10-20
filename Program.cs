using System.ComponentModel;

Console.WriteLine("Napisz swoja mase ciała: ");
byte masaciala = byte.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Napisz swoj wzrost(Przyklad: 1,75m): ");
double wzrost = double.Parse(Console.ReadLine() ?? "");
double bmi = masaciala / (wzrost*wzrost);
Console.WriteLine($"BMI {bmi}");


// Dopelnienie
 switch (bmi)
 {
     case <16:
       Console.WriteLine("Twoj wynik BMI - wygłodzenie");
     break;
     case >=16 and <=16.9:
      Console.WriteLine("Twoj wynik BMI - wychudzenie");
    break;
    case >=17 and <=18.4:
      Console.WriteLine("Twoj wynik BMI - niedowaga");
    break;
    case >=18.5 and <=24.9:
      Console.WriteLine("Twoj wynik BMI - prawidłowa masa ciała");
    break;
    case >=25 and <=29.9:
      Console.WriteLine("Twoj wynik BMI - nadwaga");
    break;
    case >=30 and <=34.9:
      Console.WriteLine("Twoj wynik BMI - otyłość I stopnia");
    break;
    case >=35 and <=39.9:
      Console.WriteLine("Twoj wynik BMI - otyłość II stopnia");
    break;
    case >40:
      Console.WriteLine("Twoj wynik BMI - otyłość III stopnia (olbrzymia)");
    break;

}


