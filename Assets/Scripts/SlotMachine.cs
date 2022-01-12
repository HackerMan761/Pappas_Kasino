using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachine : MonoBehaviour
{
    [SerializeField]
    int y = 2;
    int x;
    void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            x = Random.Range(1, y);
            print(x);
        }
    }
}
