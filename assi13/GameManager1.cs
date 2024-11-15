using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{

    void Start()
    {
        Player player1= new Player();
        Player player2= new Player();

        player1.initializePlayer("spongePop",70);
        player2.initializePlayer("Shafeeq",80);

        player1.Heal(20);
        player2.Heal(10);

        player1.Heal(true);
        player2.Heal(false);

        
        Player.showPlayerCount();
    
    }
}
