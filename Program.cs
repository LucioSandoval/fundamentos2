// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");
Console.WriteLine("Números del 1 al 255");
static void PrintNumbers()
{
    // Print all of the integers from 1 to 255.
    for (int i = 0; i < 256; i++)
    {
        Console.WriteLine(i);
    }
}

PrintNumbers();
Console.WriteLine("Números impares del 1 al 255");
static void PrintOdds()
{
    // Print all of the odd integers from 1 to 255.
    for (int i = 0; i < 256; i++)
    {
        if(i % 2 == 1){
            Console.WriteLine(i);
        }
    }
}
PrintOdds();
Console.WriteLine("Números enteros del 1 al 255 y suma");
static void PrintSum()
{
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New number: 2 Sum: 3
    int suma =0;
    for (int i = 0; i < 256; i++)
    {
        suma += i;
        Console.WriteLine("New number: " + i+ "  " + "Sum: "+ suma);
    }
}
PrintSum();
Console.WriteLine("Iterar array ------------");
static void LoopArray(int[] numbers)
{
    // Write a function that would iterate through each item of the given integer array and 
    // print each value to the console.
    foreach (int item in numbers)
    {
        // Realiza alguna operación con cada elemento del array
        Console.WriteLine(item);
    } 
}
int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
LoopArray(array);
Console.WriteLine("retornar el valor maximo del array ------------");

static int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > max){
            max = numbers[i];
        }
    }
    return max;
}
int[] numberss = new int[] { 1, 2, -3, 4, 5, 6, -7, 8, 9, -10, 0 };
Console.WriteLine(FindMax(numberss)); 
Console.WriteLine("Obtener promedio --------------");
static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    int prom = 0;
    int sum = 0;
    for (var i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    prom = sum/numbers.Length;
    Console.WriteLine($"El promedio es: {prom}");
}
int[] notas = new int[] { 40, 60, 50, 40, 60};
GetAverage(notas);
Console.WriteLine("Lista con números impares");
static List<int> OddList()
{
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
    List<int> numbers = new List<int>();
    List<int> numbersOdd = new List<int>();
    for (int i = 1; i < 256; i++)
    {
        numbers.Add(i);
    }
    foreach (int num in numbers)
    {
        if(num % 2 == 1){
            numbersOdd.Add(num);
        }
    }
    return numbersOdd;
}
List<int> numbersOdd = OddList(); 
foreach (int num in numbersOdd)
{
    if(num % 2 == 1){
        Console.WriteLine(num);
    }
}

Console.WriteLine("Mayor que Y​");
static int GreaterThanY(List<int> numbers, int y)
{
    // Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
    int count =0;
    foreach (int num in numbers)
    {
        if(num > y){
            count ++;
        }
    }
    return count;
}
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(3);
numbers.Add(5);
numbers.Add(7);
Console.WriteLine(GreaterThanY(numbers,3));
Console.WriteLine("Cuadrar los Valores​ ----------------------");
static void SquareArrayValues(List<int> numbers)
{
    // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
    foreach(int num in numbers){
        Console.WriteLine(num * num);
    }
}
List<int> number = new List<int>();
number.Add(1);
number.Add(5);
number.Add(10);
number.Add(-10);
SquareArrayValues(number);

Console.WriteLine("Cuadrar los Valores​ ----------------------");
static void EliminateNegatives(List<int> numbers)
{
    // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
    List<int> numberss = new List<int>();
    foreach (int num in numbers)
    {
        if( num < 0){
            numberss.Add(0);
        }else{
            numberss.Add(num);
        }
    }

    foreach (int item in numberss)
    {
        Console.WriteLine(item);
    }
}
List<int> nums = new List<int>();
nums.Add(1);
nums.Add(5);
nums.Add(10);
nums.Add(-2);
EliminateNegatives(nums);
