using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   public InputComponent inputScript;
   public PhysicsComponent physicsScript;
   
   public GraphicMananger _GraphicManangerScript;
  public UI _UIScript;
   private Vector3 direction;
   private bool inventoryPressed;
   private void Start()
   {
      _UIScript = GameObject.Find("Canvas").GetComponent<UI>();
      
      physicsScript.OnItemTouch += Inventory.Instance.addItem;
      physicsScript.OnItemTouch += _UIScript.DisplayItem;
   }

   private void Update()
   {
     
      inventoryPressed=inputScript.Inventory();
     
        _UIScript.Open(inventoryPressed);
     
       
       
   }

   private void FixedUpdate()
   {
      direction= inputScript.CheckWDSA();

      physicsScript.Move(direction);
   }

  
}
