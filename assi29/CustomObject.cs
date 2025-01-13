using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class CustomObject 
    { 
        public int ID
        {
            set;
            get;
        }
        public string Name
        {
            set;
            get;
        }
        public CustomObject(int id,string name)
        {
            this.ID=id;
            this.Name =name;
        }
        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}]";
        }

        ///////
        /*
        public override bool Equals(object obj)
        {
            if (obj is CustomObject co)
            {
                return this.ID == co.ID && this.Name == co.Name;
            }
            return false;
        }
        */
        /*
        public static bool operator == (CustomObject obj1, CustomObject obj2)
        {
            if (obj1 != null && obj2 != null)
            {
                if (obj1.Equals(obj2))
                    return true;
                return obj1.ID == obj2.ID && obj1.Name == obj2.Name;
            }
            else
                return false;

            
        }
        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            if(!obj1.Equals(obj2)) return true;
            else
                return false;
        }
        */
    }


}