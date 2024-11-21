using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Inventory inventory = new Inventory();
        inventory.AddItem("Healing Potion");
        inventory.AddItem("Strength Potion");

        Inventory elixirInventory = new Inventory();
        elixirInventory.AddItem("Elixir");
        elixirInventory.AddItem("Dark Elixir");

        Inventory combinedInventory = inventory + elixirInventory;

        Debug.Log("Combined Inventory Items:");
        combinedInventory.ShowItems();
        
    }

}
