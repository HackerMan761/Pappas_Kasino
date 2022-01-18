using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachine : MonoBehaviour
{   
    public int x;
    public Castle[] slots;
    public int current;

    [SerializeField]
    int y = 3;

    private void Start()
    {
        slots = GetComponents<Castle>();
        print(slots.Length);
    }
    private void Update()
    {
        //N�r man trycker p� f kommer man f� ett tal mellan 1 och det man valt f�r vardet p� y /Zeke
        if (Input.GetKeyDown(KeyCode.F))
        {
            x = Random.Range(1, y);
            print(x);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            slots[current].Spakdrag();
            current++;
            if (current > slots.Length - 1)
            {
                current = 0;
            }
        }
    }
}
