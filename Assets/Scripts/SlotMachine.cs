using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachine : MonoBehaviour
{   
    [SerializeField]
    public Castle[] slots;
    public int current = 0;
    public Spak spak;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spak.spel)
            {
            if(current < slots.Length)
            {
                slots[current].Spakdrag();
                current++;
            }
            else
            {
                
                current = 0;
                slots[0].Vanish();
                slots[1].Vanish();
                slots[2].Vanish();
           
            }
           }
        }
    }
}
