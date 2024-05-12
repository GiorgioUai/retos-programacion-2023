for (int num = 1; num <= 100; num++)
{
    if (num%3 == 0 && num%5 == 0)
    {
        //imprime por consola "fizzbuzz" si el numero es divisible por 3 y por 5
        Console.WriteLine("fizzbuzz");
    }
    else if(num%3 == 0)
    {
        //imprime por consola "fizz" si el numero es divisible por 3
        Console.WriteLine("fizz");
    }
    else if (num % 5 == 0)
    {
        //imprime por consola "buzz" si el numero es divisible por 5
        Console.WriteLine("buzz");
    }
    else
    {
        //imprime el numero por consola si el mismo no es divisible ni por 3 ni por 5
        Console.WriteLine(num.ToString());
    }
}
