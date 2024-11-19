using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MathOperations
{
    // Публичный метод для сложения двух чисел
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Приватный метод для вычисления факториала числа
    private int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}

public class User
{
    public string Username { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public User(string username, string email, int age)
    {
        Username = username;
        Email = email;
        Age = age;
    }

    // Метод для вывода информации о пользователе
    public string DisplayInfo()
    {
        return $"Username: {Username}, Email: {Email}, Age: {Age}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Пример использования класса MathOperations
        MathOperations mathOps = new MathOperations();
        Console.WriteLine($"Сложение 3 + 5: {mathOps.Add(3, 5)}");

        // Пример использования класса User
        User user = new User("YuriyOstrik", "Ostrik384@gmail.com", 18);
        Console.WriteLine(user.DisplayInfo());
    }
}
