using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    SpriteRenderer Spr;
    void Start()
    {
        Spr = GetComponent<SpriteRenderer>();
        Spr.sprite = körsbär;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
