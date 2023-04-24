using System;
class Program
{
    enum SoftwareProducts
    {
        OPERA,
        SAFARI,
        MOZILLA_FIREFOX,
        CHROME,
        Eclipse,
        Microsoft_Visual_Studio,
        Net_Beans,
        ActiveState_Komodo
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Список програмних продуктiв:");
        Console.WriteLine($"{(int)SoftwareProducts.OPERA}.{SoftwareProducts.OPERA}");
        Console.WriteLine($"{(int)SoftwareProducts.SAFARI}.{SoftwareProducts.SAFARI}");
        Console.WriteLine($"{(int)SoftwareProducts.MOZILLA_FIREFOX}.{SoftwareProducts.MOZILLA_FIREFOX}");
        Console.WriteLine($"{(int)SoftwareProducts.CHROME}.{SoftwareProducts.CHROME}");
        Console.WriteLine($"{(int)SoftwareProducts.Eclipse}.{SoftwareProducts.Eclipse}");
        Console.WriteLine($"{(int)SoftwareProducts.Microsoft_Visual_Studio}.{SoftwareProducts.Microsoft_Visual_Studio}");
        Console.WriteLine($"{(int)SoftwareProducts.Net_Beans}.{SoftwareProducts.Net_Beans}");
        Console.WriteLine($"{(int)SoftwareProducts.ActiveState_Komodo}.{SoftwareProducts.ActiveState_Komodo}");

        Console.WriteLine("Введiть номери програмних продуктiв,якi Ви вважаєте бiльш популярними i зручними,записати через кому:");
        string input=Console.ReadLine();
        string[] selectedSoftwareProductsNumbers = input.Split(',');
        Console.WriteLine("Вибранi браузери aбо IDE:");
        foreach(string SoftwareProductsNumbers in selectedSoftwareProductsNumbers) 
        {
            int softwareproducts = int.Parse(SoftwareProductsNumbers);
            switch(softwareproducts)
            {
                case (int)SoftwareProducts.OPERA:
                case (int)SoftwareProducts.SAFARI:
                case (int)SoftwareProducts.MOZILLA_FIREFOX:
                case (int)SoftwareProducts.CHROME:
                    Console.WriteLine($"{softwareproducts}.браузер-{((SoftwareProducts)softwareproducts).ToString()}");
                    break;
                case (int)SoftwareProducts.Eclipse:
                case (int)SoftwareProducts.Microsoft_Visual_Studio:
                case (int)SoftwareProducts.Net_Beans:
                case (int)SoftwareProducts.ActiveState_Komodo:
                    Console.WriteLine($"{softwareproducts}.IDE-{((SoftwareProducts)softwareproducts).ToString()}");
                    break;
                default:
                    Console.WriteLine($"{softwareproducts}.Невiдомо");
                    break;



            }
        }
        Console.WriteLine("Автор програми: Любченко Вiкторiя ");
    }

}
