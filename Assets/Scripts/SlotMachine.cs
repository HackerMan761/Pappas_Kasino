using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Zeke 
public class SlotMachine : MonoBehaviour
{   
    [SerializeField]
    public Castle[] slots;
    public int current = 0;
    public Spak spak;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //n�r man trycker p� space och har lagt in pengar visar den n�sta ikon, om alla �r framme f�rsvinner dem
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
