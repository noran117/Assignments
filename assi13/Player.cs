using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Player
    {
        public string playerName;
        public int health;
        public static int playerCount;


        public void initializePlayer(string name, int initialHealth)
        {
            this.playerName = name;
            this.health = initialHealth;
            playerCount++;
        }

        public void Heal(int amount)
        {
            health += amount;
            Debug.Log("Player health= " + health);
        }

        public void Heal(bool fullRestore)
        {
            if (fullRestore)
            {
                health = 100;
                Debug.Log("Player fully healed, health= +" + health);
            }
        }

        public static void showPlayerCount()
        {
            Debug.Log(playerCount);
        }


    }
