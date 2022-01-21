using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachine : MonoBehaviour
{   
    public Castle[] slots;
    public int current = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
