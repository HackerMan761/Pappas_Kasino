using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachine : MonoBehaviour
{
    [SerializeField]
    int y = 3;
    public int x;
    void Start()
    {

    }
    private void Update()
    {
        //N�r man trycker p� f kommer man f� ett tal mellan 1 och det man valt f�r vardet p� y /Zeke
        if (Input.GetKeyDown(KeyCode.F))
        {
            x = Random.Range(1, y);
            print(x);
        }
    }
}
