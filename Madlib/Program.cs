using System;

namespace Madlib
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me a plural noun");
            string pluralNoun = Console.ReadLine();
			Console.WriteLine("Give me a name");
			string nameOne = Console.ReadLine();
			Console.WriteLine("Give me a verb");
			string verbOne = Console.ReadLine();
			Console.WriteLine("Give me another plural nouns");
			string pluralNounTwo = Console.ReadLine();
			Console.WriteLine("Give me a holiday");
			string holiday = Console.ReadLine();
			Console.WriteLine("Give me a color");
			string color = Console.ReadLine();
			Console.WriteLine("Give me an adjective");
			string adjective = Console.ReadLine();
			Console.WriteLine("Give me another color");
			string colorTwo = Console.ReadLine(); 
			Console.WriteLine("Give me another adjective");
			string adjectiveTwo = Console.ReadLine(); 
			Console.WriteLine("Give me a verb with -ed");
			string verbed = Console.ReadLine(); 
			Console.WriteLine("Give me a vegetable");
			string vegetable = Console.ReadLine();
			Console.WriteLine("Give me another verb with -ed");
			string verbedTwo = Console.ReadLine();
			Console.WriteLine("Give me another name");
			string nameTwo = Console.ReadLine();
			Console.WriteLine("Give me another verb");
			string verbTwo = Console.ReadLine();
			Console.WriteLine("Give me another verb");
			string verbThree = Console.ReadLine();
			Console.WriteLine("Give me another color");
			string colorThree = Console.ReadLine();
            Console.WriteLine("Did you ever have one of those {0}?" +
                              "Well today {1} did! Mom wanted" +
                              "to {2} {3} up for {4}. Not" +
                              "just any lights, {5} lights. {6} {7}" +
                              "lights! {8} bright red lights! The only" +
                              "problem, they are a {9} mess!" +
                              "Not to mention that there are some" +
                              "{10}, yellow and green lights {11}" +
                              "in. '{12}' I yell! This can't be done!" +
                              "She could {13} I was right and went" +
                              "out and {14} some new shiny {15}" +
                              "lights!",pluralNoun ,nameOne, verbOne, pluralNounTwo, 
                              holiday, color, adjective, colorTwo, adjectiveTwo,
                              verbed, vegetable, verbedTwo, nameTwo, verbTwo,
                              verbThree, colorThree);
            Console.ReadLine();
        }
    }
}
