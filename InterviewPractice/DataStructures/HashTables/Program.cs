using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {

            string[][] dishes =
            {
                new string[] {"Salad", "Tomato", "Cucumber", "Salad", "Sauce"},
                new string[] {"Pizza", "Tomato", "Sausage", "Sauce", "Dough"},
                new string[] {"Quesadilla", "Chicken", "Cheese", "Sauce"},
                new string[] {"Sandwich", "Salad", "Bread", "Tomato", "Cheese"}
            };

            string str1 = "EximjeTCXsmDxOPaklH";
            string str2 = "E";
            
            Lexico l = new Lexico();
            
            Console.Out.WriteLine(l.Compare(str1,str2));

            GrouppingDishes gd = new GrouppingDishes();
    
            gd.groupingDishes(dishes);
        }
    }
}
