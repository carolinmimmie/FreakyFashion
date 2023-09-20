using FreakyFashion.Data;
using FreakyFashion.Domain;
using static System.Console;

namespace FreakyFashionConsole;

class Program
{
    public static void Main()
    {
        Title = "Freaky Fashion"; //sätter namnet på tabben
        CursorVisible = false; //stänger av markör

        while (true) //Loop som körs tills vi stänger ner den
        {
            WriteLine("1. Lista produkter");

            var keyPressed = ReadKey(true); //hämtar in värdet

            Clear();


            switch (keyPressed.Key)
            {
                case ConsoleKey.D1: //case för menyval1
                case ConsoleKey.NumPad1:

                    ListProductsView();

                    break;

            }
            Clear();

        }
    }

    private static void ListProductsView()
    {

        var products = GetProducts();

        foreach (var product in products)
        {
            WriteLine($"{product.Id}, {product.Name}, {product.Price}");
        }
        WaitUntilKeyPressed(ConsoleKey.Escape);
    }
    private static void WaitUntilKeyPressed(ConsoleKey key)//Håller kvar applikationen i while loopen tills användaren trycker på escape när användaren trycker på escape blir det false då kommer den köra vidare under whileloopen och hoppa tillbaka till menyn
    {
        while (ReadKey(true).Key != key) ;
    }
    private static IEnumerable<Product> GetProducts()//Håller kvar applikationen i while loopen tills användaren trycker på escape när användaren trycker på escape blir det false då kommer den köra vidare under whileloopen och hoppa tillbaka till menyn
    {
        using var context = new ApplicationDbContext();

        var products = context.Product.ToList();

        return products;
    }
}

