List<int> numbers = new List<int> { 18, 12, 20, 1, 10, 4, -20, 2, -5, -8 };

// Çift Sayılar
var evenNumbers = numbers.Where(x => x % 2 == 0);
Console.WriteLine("Çift Sayılar:");
foreach (var n in evenNumbers) Console.WriteLine(n);
Console.WriteLine("------------------------------");

// Tek Sayılar
var oddNumbers = numbers.Where(x => x % 2 != 0);
Console.WriteLine("Tek Sayılar:");
foreach (var n in oddNumbers) Console.WriteLine(n);
Console.WriteLine("------------------------------");

// Negatif Sayılar
var negativeNumbers = numbers.Where(x => x < 0);
Console.WriteLine("Negatif Sayılar:");
foreach (var n in negativeNumbers) Console.WriteLine(n);
Console.WriteLine("------------------------------");

// Pozitif Sayılar
var positiveNumbers = numbers.Where(x => x > 0);
Console.WriteLine("Pozitif Sayılar:");
foreach (var n in positiveNumbers) Console.WriteLine(n);
Console.WriteLine("------------------------------");

// 15'ten büyük 22'den küçük sayılar
var between15and22 = numbers.Where(x => x > 15 && x < 22);
Console.WriteLine("15'ten büyük 22'den küçük sayılar:");
foreach (var n in between15and22) Console.WriteLine(n);
Console.WriteLine("------------------------------");

// Sayıların kareleri
var squares = numbers.Select(x => x * x);
Console.WriteLine("Sayıların Kareleri:");
foreach (var n in squares) Console.WriteLine(n);
