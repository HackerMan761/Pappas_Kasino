using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Zeke
public class Slot3 : Castle
{
    public Spak spak;
    public override void Spakdrag()
    {
        base.Spakdrag();
        spak.spel = false;
    }
}
