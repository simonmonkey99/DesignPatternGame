using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputComponent : MonoBehaviour
{
    
    private bool movement;
    private bool inventory=false;
 
    public Vector3 CheckWDSA()
    {


        return new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        
        

    }
    
    
    public bool Inventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventory == false)
            {
                inventory = true;
            }
            else if (inventory == true)
            {
               inventory = false; 
            }
            
        }

        return inventory;
    }
}
