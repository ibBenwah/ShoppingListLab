//      Shopping List Lab


List<string> items = new List<string>() { "Milk", "Eggs", "Poptarts", "Pop", "Beer", "Chicken nuggets", "Cream Cheese", "Waffles" };
List<string> prices = new List<string>() { "1.99", "1.50", "3.50", "4.75", "10.99", "11.99", "3.49", "5.99" };
List<string> groceryList = new List<string>();
List<string> groceryPrices = new List<string>();
bool isContinue = true;
do
{
    do
    {
        Console.Write("What would you like to add to the cart? ");
        string userInput = Console.ReadLine();
        if (items.Contains(userInput))
        {
            int index = items.IndexOf(userInput);
            Console.Write(items[index] + " ");
            groceryList.Add(items[index]);
            Console.WriteLine(prices[index] + " ");
            groceryPrices.Add(prices[index]);
        }
        else
        {
            Console.Write("Enter a valid item.");
        }

        Console.Write("would you like to keep shopping? (yes or no) ");
        if (Console.ReadLine() == "yes")
        {
            
        }
        else
        {
            Console.Clear();
            break;
        }

    } while (isContinue);

    Console.WriteLine("you ordered: ");
    
    for (int i = 0; i < groceryList.Count ; i++)
    {
        
        Console.WriteLine(groceryPrices[i] +" ");
    }
    for (int j = 0; j < groceryPrices.Count; j++)
    {

        Console.WriteLine(groceryList[j] + " ");
    }

} while (isContinue = false);
Console.WriteLine("Thank You for shopping!");

