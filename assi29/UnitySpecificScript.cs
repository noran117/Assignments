using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {

        private void OnEnable()
        {
            print("Game object enabled");

        }
        private void OnDisable()
        {
            print("Game object disabled");
        }
        GameObject target;
        private void Start()
        {
            print("Game  Started");
            target = GameObject.Find("TargetObject");
            string txt = target ? $"Found object by name: {target.name}" : "Notfound";
            print(txt);

            GameObject joker = GameObject.FindWithTag("joker");
            string txtt = joker ? $"Found object by tag: {joker.name}" : "Notfound";
            print(txtt);

            Light light = GameObject.FindObjectOfType<Light>();
            string txttt = light ? $"Found object by type Light: {light.name}" : "Notfound";
            print(txttt);

        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                target.SetActive(false);
                print("Game object deactivated");
            }
        }
    }
}