using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Symulator
{
    class Car
    {
        private Mark mark;
        private Model model;
        private Engine engine;

        public Car(Mark mark, Model model, Engine engine)
        {
            this.mark = mark;
            this.model = model;
            this.engine = engine;
        }

        public Car(Mark mark, Model model, int capacity, int tank)
        {
            this.mark = mark;
            this.model = model;
            this.engine = new Engine(capacity, tank);
        }

        public Car(Mark mark, Model model, int capacity, int tank, int tankCapacity)
        {
            this.mark = mark;
            this.model = model;
            this.engine = new Engine(capacity, tank, tankCapacity);
        }

        public Mark GetMark()
        {
            return this.mark;
        }

        public Model GetModel()
        {
            return this.model;
        }

        public Engine GetEngine()
        {
            return this.engine;
        }

        public void Drive(int distance)
        {
            int time = distance / 100 * 100;
            int tank = (this.engine.GetCapacity() / 1000) * 4;
            int tankDistance = distance / 100;
            int newTank = this.engine.GetTank() - tankDistance * tank;
            if (newTank < 0)
            {
                Console.WriteLine("\nZa mało paliwa aby jechać!\n");
                return;
            }

            Thread.Sleep(time);
            this.Run(newTank);
        }

        public void Run(int fuel)
        {
            this.engine.SetTank(fuel);
            Console.WriteLine("\nJestem na miejscu!, Ilośc pozostałego paliwa to: {0} litrów\n", this.engine.GetTank().ToString());
        }

        public int getTank()
        {
            return this.engine.GetTank();
        }

        public void Tank(int tank)
        {

            if(this.engine.GetTank() + tank > this.engine.GetTankCapacity())
            {
                Console.WriteLine("\nMaksymalna ilość paliwa w zbiorniku to {0}!\n", this.engine.GetTankCapacity());

                return;
            }
            this.engine.SetTank(tank);
        }
    }
}
