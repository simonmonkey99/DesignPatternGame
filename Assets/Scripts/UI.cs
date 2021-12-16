using System.Collections;
using System.Collections.Generic;
using Enums;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
   
    [SerializeField] private GameObject Inventory;
     [SerializeField] private GameObject[] ItemSlots= new GameObject[9];
      [SerializeField] private Text[] text= new Text[9];
      private int[] amount = new int[9];

  public void Open(bool active)
  {
     Inventory.SetActive(active);
        
  }
  
  
 
  public void DisplayItem(Item item)
  {
        
    
      for (int x = 0; x < 9; x++)
      {
          if (ItemSlots[x].GetComponent<Image>().sprite==null)
          {
              ItemSlots[x].GetComponent<Image>().sprite = item.gameObject.GetComponent<SpriteRenderer>().sprite;
              
              amount[x] = 1;
              text[x].text = amount[x].ToString();
              x = 9;
          }
          else if (item.gameObject.GetComponent<SpriteRenderer>().sprite == ItemSlots[x].GetComponent<Image>().sprite )
          {
              amount[x]++;
              text[x].text = amount[x].ToString();
          }
      }
  }
  
  
}
