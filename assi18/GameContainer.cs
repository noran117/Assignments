using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContainer<T>
{
    private T t; 
    public void SetItem(T item){
        this.t= item;

    }
    public T GetItem(){
        return T;
    }
    
}
