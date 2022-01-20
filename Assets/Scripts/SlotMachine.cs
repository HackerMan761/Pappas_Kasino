using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachine : MonoBehaviour
{   
    public int x;
    public Castle[] slots;
    public int current = 0;
    int y = 3;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            x = Random.Range(1, y);
            print(x);
        }
        if (Input.GetKeyDown(KeyCode.B))
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
