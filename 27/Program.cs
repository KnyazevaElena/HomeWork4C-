// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11, 82 -> 10,  9012 -> 12


Console.Clear();
 Console.Write("Введите число : ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {a} = {CountNumbers(a)}");

int CountNumbers(int n) {
    int sum = 0;
    while (n>0){
        sum += n % 10;
        n /= 10;
    }
return sum;

}


