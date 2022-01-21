using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot3 : Castle
{
    public Spak spak;
    public override void Start()
    {
        base.Start();
        spak = GetComponent<Spak>();
    }
    public override void Spakdrag()
    {
        base.Spakdrag();
        spak.spel = false;
    }
}
