using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    public interface ICalculator
    {
        double Price(Session item);
    }
    public class DayCalculator : ICalculator
    {
        public double Price(Session item)
        {
            var now = DateTime.Now;
            var dt = now - item.Start;
            return 5 * dt.TotalMinutes * 0.5;
        }
    }

    public class NightCalculator : ICalculator
    {
        public double Price(Session item)
        {
            var now = DateTime.Now;
            var dt = now - item.Start;
            return 3 * dt.TotalMinutes * 0.5;
        }
    }

    public abstract class BaseTimer
    {
        protected List<ICalculator> list;
        protected virtual double GetPriceFromCalculators(Session s)
        {
            double result = 0;
            foreach (var item in list)
            {
                result += item.Price(s);
            }
            return result;
        }
        protected abstract double Filter(Session s, double price);

        public double Process(Session s)
        {
            double result = GetPriceFromCalculators(s);
            result = Filter(s, result);
            return result;
        }
    }

    public class TotalTimer500 : BaseTimer
    {
        public TotalTimer500()
        {
            list = new List<ICalculator>()
            {
                new DayCalculator(),
                new NightCalculator()
            };
        }

        protected override double Filter(Session s, double price)
        {
            return Math.Min(price, 500);
        }
    }

    public class TotalTimer600 : BaseTimer
    {
        public TotalTimer600()
        {
            list = new List<ICalculator>()
            {
                new DayCalculator(),
                new NightCalculator()
            };
        }

        protected override double Filter(Session s, double price)
        {
            return Math.Min(price, 600);
        }
    }

    public class Session
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class Person
    { 
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name={Name}, Age = {Age}";
        }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            var s = new Session()
            {
                Start = new DateTime(2018, 10, 14, 12, 0, 0)
            };
            var timer = new TotalTimer500();
            var price = timer.Process(s);
            Console.WriteLine(price);
            Console.ReadLine();
        }
    }
}
