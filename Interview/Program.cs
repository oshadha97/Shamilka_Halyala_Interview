// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// Display numbers 1 to 100 , if nmber is divisible by 3 display as Fizzy, 
// if number divisible by 5 dissplay as Buzzy , if number divisible both 3 and 5 dispalay 
//as Buzzy and Fizzy

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("Fizz Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine("{0}", i);
    }
}