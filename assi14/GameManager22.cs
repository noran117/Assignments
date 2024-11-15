using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14
{
    public class GameManager22 : MonoBehaviour
    {
        void Start()
        {
            Playerr player = new Playerr("Zarifeh", 70);
            Enemy enemy = new Enemy("Subhi", 70);

            Debug.Log($"Player's name is {player.name}, and its health = {player.health}");
            Debug.Log($"Enemy's name is {enemy.name}, and its health = {enemy.health}");

            player.heal(20);
            Debug.Log("Player's health= " + player.health);

            enemy.Attack(player, 30);
            Debug.Log("Player's health= " + player.health);


        }
    }
}