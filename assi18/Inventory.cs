using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<string> list;
    public Inventory()
    {
        list = new List<string>();
    }
    public void AddItem(string item){
        list.Add(item);
    }
    public void ShowItems(){
        foreach (string item in list)
        {
            Debug.Log(item);
        }
    }

    public static Inventory operator +(Inventory inv1, Inventory inv2)
    {
        Inventory inventory = new Inventory();
        inventory.list.AddRange(inv1.list);
        inventory.list.AddRange(inv2.list);
        return inventory;
    }
}
