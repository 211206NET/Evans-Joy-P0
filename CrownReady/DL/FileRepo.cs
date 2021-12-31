using System.Text.Json;
namespace DL;

public class FileRepo
{
    public FileRepo()
    {}
    private string filePath = "../DL/Storefronts.json";

    /// <summary>
    /// Returns all storefronts written in file
    /// </summary>
    /// <returns>List of all storefronts</returns>
    public List<StoreFront> GetAllStoreFronts()
    {
        // returns all storefronts in file.
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<StoreFront>>(jsonString);
    }
    /// <summary>
    /// Adds storefront to list and then writes it to file
    /// </summary>
    /// <param name="storeFrontToAdd">storefront object to be added</param>
    public void AddStoreFront(StoreFront storeFrontToAdd)
    {
        
    }
    /// <summary>
    /// Adds inventory to storefront object and then writes to file
    /// </summary>
    /// <param name="storeFrontIndex">Using index to select storefront object in the list</param>
    /// <param name="inventoryToAdd">Inventory object to be added</param>
    public void AddInventory(int storeFrontIndex, Inventory inventoryToAdd)
    {

    }
}