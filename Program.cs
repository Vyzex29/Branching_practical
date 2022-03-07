// See https://aka.ms/new-console-template for more information
short num1 = -524;
short num2 = 1227;



Console.WriteLine(num1);
Console.WriteLine("Number 1 is:" + num1 + "\n" + "Number 2 is" + "num2"); // "hello "+ " world" + num1
Console.WriteLine("Number 1 is {0}, {1}", num1, num2);
Console.WriteLine($"Number 1 is {num1} \n Number2 is: {num2}");
Console.WriteLine($"The largest number between them is : {Math.Max(num1, num2)}");
Console.WriteLine($"The smallest number between them is : {Math.Min(num1, num2)}");



if (num1 == num2)
{
    Console.WriteLine($"Numbers are equal");
}

if (num1 % 2 == 0)
{
    Console.WriteLine($"{num1} is even");
}
else
{
    Console.WriteLine($"{num1} is uneven");
}

if (num2 % 2 == 0)
{
    Console.WriteLine($"{num2} is even");
}
else
{
    Console.WriteLine($"{num2} is uneven");
}

if (num1 < 0)
{
    Console.WriteLine($"{num1} is negative");
}
else if (num1 > 0)
{
    Console.WriteLine($"{num1} is positive");
}


if (num2 < 0)
{
    Console.WriteLine($"{num2} is negative");
}
else if (num2 > 0)
{
    Console.WriteLine($"{num2} is positive");
}

if (num1 < 100)
{
    Console.WriteLine($"{num1} is less than 100");
}

if (num2 < 100)
{
    Console.WriteLine($"{num2} is less than 100");
}

var sum = num1 + num2;

Console.WriteLine($"The sum of these numbers is {Math.Round((double)sum, 0)}");

var dif = num1 - num2;
var absolute = (double)Math.Abs(Math.Round((double)dif, 2));

Console.WriteLine($"The difference betweem these numbers is {absolute}");



// TASK 2

int time = 8;
int day = 13;
int month = 1;
int year = 2;

if(time < 0)
{
    Console.WriteLine("Time can't be negative!");
}

if (time >= 0 && time < 12)
{
    Console.WriteLine("Good Morning Sunshine!");
}
if ((time >= 13) && (time <= 19))
{
    Console.WriteLine("Good Afternoon. Work Hard!");
}
if ((time >= 20) && (time <= 24))
{
    Console.WriteLine("Good Evening. Get some rest!");
}
if (time > 24)
{
    Console.WriteLine("Time can't be larger than 24!");
}

if (day > 0 && day <= 31)
{
    if(month > 0 && month <= 12)
    {
        if(year > 0)
        {
            string stringDate = $"{year.ToString("0000")}/{month.ToString("00")}/{day.ToString("00")}"; 
            Console.WriteLine(stringDate);
            Console.WriteLine($"{year}/{month}/{day}"); // 2022/01/14
        }
        else
        {
            Console.WriteLine("Year's cannot be negative!");
        }
    }
    else
    {
        Console.WriteLine("Month's can be only between 1 and 12!");
    }
}
else
{
    Console.WriteLine("Day's can be only between 1 and 31!");
}