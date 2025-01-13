using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment29
{
    public static class Utilities 
    {
        public static int Add(params int [] numbers)
        {
            int sum=0;
            foreach(int num in numbers)
            {
                sum+=num;
            }
            return sum;
        }

        /*public static string RepeatString(string txt, int NOR)
        {
            string res="";
            for(int i=0;i<NOR;i++)
            {
                res+=txt;
            }
            return res;
        }*/
        public static string RepeatString(this string txt, int NOR)
        {
            string res = "";
            for (int i = 0; i < NOR; i++)
            {
                res += txt;
            }
            return res;
        }
    }

}