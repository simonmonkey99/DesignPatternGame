using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using UnityEditor;

public class Inventory : MonoBehaviour
{
    private Slot[] _slotsArray = new Slot[9];

    public static Inventory Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject); 
        else
            Instance = this;
    }

    public void addItem(Item obj)
{
    for (int i = 0; i < 9; i++)
    {
        
            if (_slotsArray[i] == null)
            {
                _slotsArray[i] = new Slot(obj);
                i = 9;
            }
            else if (_slotsArray[i].Item.itemType == obj.itemType  )
            {
                _slotsArray[i].Amount++;
            }
    }
    
}

}

public class Slot 
{
private int amount=1;
    private Item item;
  public Slot(Item item)
    {
        
        this.item = item;
    }
    
   
    
    public int Amount
    {
        
        get => amount;
        set => amount=value;
    }

    public Item Item
    {
        get => item;
        set => item=value;
    }

}


