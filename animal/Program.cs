using System;

namespace animal
{




    class Animals
    {
        private string dog = "Dogs were domesticated from wolves over 15,000 years ago,";
        private string cat = "Domestic cats typically live between 12 to 18 years, though some can live into their 20s with good care";
        private string mouse = "In the wild, mice typically live for about 1 to 2 years ";
        private string lion = "king of the jungle";
        public string cow = "Cows typically live around 18-22 years, though some can live longer under good care.";
        public string donkey = "Donkeys typically live between 25 to 30 years, but with good care, some can live up to 50 years. ";
        public string monkey = "There are over 260 species of monkeys divided into two main groups";
        public string wolf = "Did you know that wolves can travel great distances? They have been known to cover up to 12 miles in a single day while searching for food.";

        public void printinfo()
        {
            Console.WriteLine("Cow: \n" + cow);
            Console.WriteLine("Donkey\n" + donkey);
            Console.WriteLine("Monkey \n" + monkey);
            Console.WriteLine("Wolf \n" + wolf);
            Console.WriteLine("Dog \n" + dog);
            Console.WriteLine("Cat \n" + cat);
            Console.WriteLine("Mouse \n" + mouse);
            Console.WriteLine("lion \n" + lion);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();
            animals.printinfo();
            
        }
    }
}