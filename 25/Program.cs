﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
 Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine ($"Степень числа {A} = {method (A,B)}");

int method (int a, int b){
    int otvet = 1;
    for (int i = 0; i < b; i++){
        otvet *= a;
    }

    return otvet;
}