using System;
using System.Text.Json;
using StoreItems;


public class Program
{

    public static void Main(string[] args)
    {
        // Convert List of collections to JSON format

        List<Items> readItems = Items.GetItems(); // Call GetITems method from Items calss

        var options = new JsonSerializerOptions();

        options.WriteIndented = true;
    
        string jsonString = JsonSerializer.Serialize(readItems, options);

        Console.WriteLine(jsonString); // print JSON in terminal
        File.WriteAllText("items.json", jsonString); // Save collections as JSON formate file

        // var itemsJson = File.ReadAllText("itemsJSON.json");

        // Items items = JsonSerializer.Deserialize<Items>(itemsJson);

        // Console.WriteLine(items); // print JSON in terminal;
    }
}