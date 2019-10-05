using System;


namespace _1_first_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = "Kasia";
            Console.WriteLine("Masz na imię: " + name); // + konkatenacja

            Console.WriteLine("Masz na imię {0}",name);

            int age = 20;
            Console.WriteLine("Masz na imię: {0}, wiek {1}", name, age);

            sbyte age1 = 20;
            Console.WriteLine("Masz na imię: {0}, wiek {1}", name, age1);

            /*
             *Użytkownik podaje z klawiatury długość boku
             *oblicz pole kwadratu
             */
            Console.Write("Podaj bok a:");
            string a = Console.ReadLine();
            //Console.WriteLine("Bok a wynosi: {0}", a);



            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wymosi: {0}", result);


            /*
             *Oblicz pole trójkata
             *
             *
             */

            Console.Write("Podaj bok a:");
            string a = Console.ReadLine();



            Console.Write("Podaj wysokość h:");
            string h = Console.ReadLine();


            double pol = 0,5;
            double P =0,5 ble.Parse(a) * double.Parse(h



                uint = 10;


            Console.ReadKey();
        }
    }
}
