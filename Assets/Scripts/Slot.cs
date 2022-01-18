using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : Castle
{
    private Transform Transform;
    private SpriteRenderer Spr;
    public override void Start()
    {
        base.Start();
    }
    public override void Spakdrag()
        {
         print("Tjosan");
         base.Spakdrag();
        }
}