using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Symulator
{
    class Engine
    {
        private int tank;
        private int capacity;
        private int tankCapacity;

        public Engine(int capacity, int tank)
        {
            this.capacity = capacity;
            this.tank = tank;
            tankCapacity = 50;
        }

        public Engine(int capacity, int tank, int tankCapacity)
        {
            this.capacity = capacity;
            this.tank = tank;
            this.tankCapacity = tankCapacity;
        }

        public int GetCapacity()
        {
            return capacity;
        }

        public int GetTank()
        {
            return tank;
        }

        public int GetTankCapacity()
        {
            return tankCapacity;
        }

        public void SetTank(int tank)
        {
            this.tank = tank;
        }

        public static double ToMPG(double tank)
        {
            return tank / 0.264;
        }

        public static double ToLiters(double tank)
        {
            return tank * 0.264;
        }

        public static double ConvertToImperial(double ConsumptionMetric)
        {
            return 1 / ConsumptionMetric * 100 * 0.621371192 / 0.264172052;
        }
    }
}
