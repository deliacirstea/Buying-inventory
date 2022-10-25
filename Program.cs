using System;

class Program
{
    public static void Main(string[] args)
    {
        int x = 0;

        Console.WriteLine("The following items are available");
        Console.WriteLine("****************************\n");
     
        Console.WriteLine("1 -- Rope");
        Console.WriteLine("2 -- Torches");
        Console.WriteLine("3 -- Climbing Equipment");
        Console.WriteLine("4 -- Clean Water");
        Console.WriteLine("5 -- Machete");
        Console.WriteLine("6 -- Canoe");
        Console.WriteLine("7 -- Food Supplies");

        Console.WriteLine("\nWrite in your choice:");
        x = Convert.ToInt32(Console.ReadLine());


        switch (x)
        {
            case 1: Console.WriteLine("Rope");
                break;
            case 2: Console.WriteLine("Torches");
                break ;
            case 3: Console.WriteLine("CLimbing Equipment");
                break;
            case 4: Console.WriteLine("Clean Water");
                break;
            case 5: Console.WriteLine("Machete");
                break;
            case 6: Console.WriteLine("Canoe");
                break;
            case 7: Console.WriteLine("Food Supplies");
                break;
            default: Console.WriteLine("Choice not available");
                break;
        }


       // Console.WriteLine("Choose a number to see the price of the product:");
        //Console.ReadLine();

        if (x == 1) {
           // Console.Clear();
            Console.WriteLine("10 gold"); }

        else if (x == 2) {
           // Console.Clear();
            Console.WriteLine("15 gold"); }

        else if (x == 3) {
            //Console.Clear();
            Console.WriteLine("25 gold"); }

        else if (x == 4) {
            //Console.Clear();
            Console.WriteLine("1 gold"); }

        else if (x == 5) {
            //Console.Clear();
            Console.WriteLine("20 gold"); }

        else if (x == 6) {
            //Console.Clear();
            Console.WriteLine("200 gold"); }

        else if (x == 7) {
            //Console.Clear();
            Console.WriteLine("1 gold"); }

        else
        {
            Console.Clear();
            Console.WriteLine("You have not made a valid choice!\nGo back to the main menu!");
            Console.WriteLine();

        }
         Console.WriteLine("Choose a number to see the price of the product:");
         Console.ReadLine();

    }
}