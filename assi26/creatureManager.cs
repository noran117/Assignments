using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment26
{
    public class creatureManager : MonoBehaviour
    {
        Kangaroo kangaroo;
        Duck duck;
        Creature creatures;

        void Start()
        {
            kangaroo= new Kangaroo();
            duck= new Duck();
            creatures=new Creature();

            List<Creature> CreatureList = new List<Creature> { kangaroo, duck};
            //List<Creature> CreatureList = new List<Creature> { new Kangaroo(), new Duck() };
            List<IRunnable> runnables = new List<IRunnable>();
            List<IJumpable> jumpables = new List<IJumpable>();
            List<ISwimmable> swimmables = new List<ISwimmable>();

            runnables.Add(kangaroo);
            jumpables.Add(kangaroo);

            runnables.Add(duck);       
            swimmables.Add(duck);


            foreach(Creature creature in CreatureList)
                creature.Speak();


            foreach(IRunnable runnable in runnables)
                runnable.Run();

            foreach(ISwimmable swimmable in swimmables)
                swimmable.Swim();

            foreach(IJumpable jumpable in jumpables)
                jumpable.Jump();

        }
       


    }
}