using System;
using System.Text.Json;
using StoreItems;


public class Program
{

    public static void Main(string[] args)
    {
        //-------------------------------------------- Serialization  section ----------------------------------------------------------------
        // Convert List of collections to JSON format

        List<Items> readItems = Items.GetItems(); // Call GetITems method from Items calss

        var options = new JsonSerializerOptions();

        options.WriteIndented = true;
    
        string jsonString = JsonSerializer.Serialize(readItems, options);

        Console.WriteLine(jsonString); // print JSON in terminal
        File.WriteAllText("items.json", jsonString); // Save collections as JSON formate file

        //-------------------------------------------- Deserialization section ----------------------------------------------------------------

        var itemsJson = File.ReadAllText(@"itemsJSON.json");

        var items = JsonSerializer.Deserialize<List<Items>>(itemsJson);

        if (items != null) // iterate through items and print them out
        {
            foreach(var item in items)
            {
                Console.WriteLine($"Quantity:{item.Quantity}\nProduct Name: {item.Name}\nDate: {item.Date} \n");
            }
        }
        

    }
}