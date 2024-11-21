using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> gameContainer=new GameContainer<string>();
        gameContainer.SetItem("Healing Potion");

        string Item= gameContainer.GetItem();
        Debug.Log(Item);

        string description = GameUtils.DescribeItem(Item);
        Debug.Log(description);
        
    }

}
