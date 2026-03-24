namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 20, 40, 50, 60, 12, 23, 34, 45, 56, 76, 67, 78, 12, 89, 90, 98, 87, 76, 65, 54, 43, 32, 21 };
            IEnumerable<int> r = from k in numbers
                                 where k % 2 != 0
                                 select k;

            //fetch numbers > 50 
            var result = numbers.Where(n => n > 50);
            var result1 = from int a in numbers
                          where a > 50
                          select a;

            //even num > 50
            result = numbers.Where(n => n > 50 && n % 2 == 0);
            result1 = from a in numbers
                      where a > 50 && a % 2 == 0
                      select a;
            // even numbers > 50 and display in sorted order
            result = numbers.Where(n => n > 50 && n % 2 == 0).OrderBy(n => n);
            result1 = from a in numbers
                      where a > 50 && a % 2 == 0
                      orderby a ascending
                      select a;

            //fetch unique data
            result = numbers.Where(n => n > 50).Distinct();
            result1 = (from a in numbers
                       where a > 50
                       select a).Distinct();
            //fetch 1st 5 values
            result1 = (from a in numbers
                           where a > 50
                           select a).Take(5);

            result = numbers.Where(n => n > 50).Take(5);

            //fetch values to dkip first 3
            result = numbers.Where(n => n > 50).Skip(3);
            result1 = (from a in numbers
                       where a > 50
                       select a).Skip(3);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
