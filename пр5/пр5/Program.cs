using System;
class Program
{ public static void Main()
    { Console.WriteLine("Введіть два слова :");
        var word1 = Console.ReadLine();
        var word2 = Console.ReadLine(); 
        var fullWord = word1 + word2; 
        Console.WriteLine("Лише ті літери слів, які зустрічаються в обох словах лише один раз:"); 
        for (int i = 0; i < fullWord.Length; i++)
        { var c = fullWord[i].ToString();
            if (fullWord.IndexOf(c) == fullWord.LastIndexOf(c))
            { Console.WriteLine(c); 
            }
        } 
    }
}
