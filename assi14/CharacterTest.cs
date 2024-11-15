using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment15
{
    public class CharacterTest : MonoBehaviour
    {
        

        void Start()
        {

            Character soldier = new Slodier("Spongepop", 75, new Position(1, 2, 3));
            Character officer = new Officer("Shafeeq", 90, new Position(10, 5, 2));
            Character[] characters = new Character[2] { soldier, officer };
            //characters[0] = soldier;
            //characters[1] = officer;
           
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }
            //foreach (Character character in characters)
            //{
            //    character.DisplayInfo();
            //}

            characters[0].Attack(characters[1], 20);
            Debug.Log("Officer's Health after attack= " + characters[1].Health);
        }

      
    }
}