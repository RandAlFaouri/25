using System.Globalization;
using System.Runtime.CompilerServices;

namespace CAExtensionsMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pizza p = new Pizza();
 //           p = PizzaExtentions.AddDough(PizzaExtentions.AddSouce(PizzaExtentions.AddCheeze(PizzaExtentions.AddToppings(p, "black olives", 3.5m), true)), "thin");
   p.AddDough("thin")
                .AddSouce()
                .AddCheeze(true)
                .AddToppings("black olives " ,3.5m );
            Console.WriteLine(p);
            // DateTime dt = DateTime.Now;
            //Console.WriteLine($"DataTime.Now: {dt}");
            //dt = dt.AddDays(4);
            /*Console.WriteLine($"Is weekend : {DataTimeExtension.IsWeekEnd(dt)}"); //dt.IsWeekEnd
            Console.WriteLine($"DataTime.Now: {DataTimeExtension.IsWeekDay(dt)}");*/
            //Console.WriteLine($"Is weekend : {dt.IsWeekEnd()}"); //dt.IsWeekEnd
            //Console.WriteLine($"DataTime.Now: {dt.IsWeekDay()}");
            /*  Console.WriteLine(dt.ToString()); //yyyy-MM-dd hh:mm:ss am/pm
              Console.WriteLine($"DateTime.Now: {dt}");
              dt = new DateTime(2024, 3, 1,11,30,00);
              Console.WriteLine($"DateTime: {dt}");
              DateTimeOffset dts = DateTimeOffset.Now;
              Console.WriteLine($"DateTimeOffset.Now: {dts}");
              dts = DateTimeOffset.UtcNow;
              Console.WriteLine($"DateTimeOffset.UtcNow: {dts}");
              TimeSpan ts = new TimeSpan(2, 15, 0);
              dt = dt.Add(ts);
              Console.WriteLine($"DateTime: {dt}");
              dt=dt.AddDays(4);
              Console.WriteLine($"DateTime+4 Days: {dt}");*/

        }

    }
    static class PizzaExtentions
    {
        public static Pizza AddDough(this Pizza value, string type)
        {
            value.Content += $"\n{type} Dough X $4.00 ";
            value.TotalPrice += 4m;
            return value;
        }
        public static Pizza AddSouce(this Pizza value)
        {
            value.Content += $"\nTomato X $2.00 ";
            value.TotalPrice += 2m;
            return value;
        }
        public static Pizza AddCheeze(this Pizza value, bool extra)
        {
            value.Content += $"{(extra ? "extra" : "regular")}Cheeze sause X ${(extra ? "6.00" : "4.00")}"
                ;
            value.TotalPrice += extra ? 6m : 4m;
            return value;
        }
        public static Pizza AddToppings(this Pizza value, string type, decimal price)

        {
            value.Content += $"{type} X ${price.ToString("#.##")}";
            ;
            value.TotalPrice += price;
            return value;
        }
    }
    class Pizza
    {

        public string Content { get; set; }
        public decimal TotalPrice { get; set; }
        public override string ToString()
        {
            return $"{Content}\n-------------------\nTotal Price: ${TotalPrice.ToString("#.##")}";
        }
        public Pizza AddSouce()
        {
            this.Content += $"\nTOMOTP SAUCE X $2.00 ";
            this.TotalPrice += 2m;
        return this;
        }
    }
}
