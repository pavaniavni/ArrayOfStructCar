using System;
namespace StructCar
{
    public class ArrayOfStructCar
    {
        struct Car
        {
            public string Model;
            public int a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Cars : ");
            int t = int.Parse(Console.ReadLine());
            Car[] c = new Car[t];

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Enter the Model of Car : ");

                c[i] = new Car()
                {
                    Model = Console.ReadLine(),
                    //Console.WriteLine("Enter the Car Year of Production : "),
                    a = int.Parse(Console.ReadLine())
                };
            }

            // Sort
            for (int i = 0; i < t - 1; i++)
            {
                for (int j = i + 1; j < t; j++)
                {
                    if (c[i].a > c[j].a)
                    {
                        var b = c[i];

                        c[i] = c[j];
                        c[j] = b;
                    }
                }
            }

            // Show
            for (int i = 0; i < t; i++)
            {
                var car = c[i];
                Console.WriteLine("The Car Model is : " + car.Model);
                Console.WriteLine("The Car Year of Production is: " + car.a);
            }
        }
    }
}

