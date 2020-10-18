using System;

namespace Symulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool go = false;
            int capacity = 2000;
            int tank = 50;
            int tankCapacity = 50;

            Console.WriteLine("Podaj nazwe samochodu:");
            string mark = Console.ReadLine();

            Console.WriteLine("Podaj nazwe samochodu:");
            string model = Console.ReadLine();

            Car car = new Car(
                new Mark(mark),
                new Model(model),
                new Engine(capacity, tank, tankCapacity)
            );

            do
            {
                int action = Action();
                go = action > 0;
                switch (action){
                    case 1:
                        Console.WriteLine("Podaj ilość km do przejechania:");
                        int distance = int.Parse(Console.ReadLine());
                        Go(car, distance);
                        break;
                    case 2:
                        Console.WriteLine("Podaj ile paliwa zatankować:");
                        int liters = int.Parse(Console.ReadLine());
                        car.Tank(liters);
                        Console.WriteLine("Aktualna ilość zatankowanego paliwa to: {0} litrów", car.getTank().ToString());
                        Action();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Nie ma takiej opcji");
                        Action();
                        break;
                }

            }
            while (go);

            Console.WriteLine("Koniec programu");

            Console.ReadKey();

        }

        public static void Go(Car car, int distance)
        {
            car.Drive(distance);
        }

        public static int Action()
        {
            Console.WriteLine("Wpisz `jedz` aby jechać, `stoj` aby wyjśc z programu lub `tankuj` aby zatankowac");
            string action = Console.ReadLine();

            switch (action)
            {
                case "jedz":
                    return 1;
                case "stoj":
                    return 0;
                case "tankuj":
                    return 2;
                default:
                    return 3;
            }

        }
    }
}
