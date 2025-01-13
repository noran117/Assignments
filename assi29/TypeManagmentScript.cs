using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assignment29
{
   
    public class TypeManagmentScript : MonoBehaviour
    {
        Animal animal;
        Cat cat;
        Warrior warrior;
        void Start()
        {
            animal=new Animal();
            cat=new Cat();
            warrior=new Warrior();

            //Upcasting
            animal = cat;
            animal.MakeSound();
            animal.Move();

            //Downcasting
            cat = animal as Cat;
            cat.MakeSound();
            cat.Move();


            List<ICanFight> canFights=new List<ICanFight> {cat,warrior};
            

            foreach(ICanFight fighter in canFights)
            {
                fighter.Attack();
                if (fighter is Cat)
                {
                    Debug.Log("The Object is a Cat");
                }
                else if(fighter is Warrior)
                {
                    Debug.Log("The Object is a Warrior");
                }
            }

        }
    
    }
    public class Animal
    {

        public virtual void MakeSound()
        {
            Debug.Log("Animal Sound");
        }
        public void Move()
        {
            Debug.Log("Animal moves");
        }

    }
    public class Cat : Animal, ICanFight
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!!");
        }
        public new void Move()
        {
            Debug.Log("Cat runs quickly.");
        }
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }

    }

    public interface ICanFight
    {
        public void Attack();
    }
    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }
}