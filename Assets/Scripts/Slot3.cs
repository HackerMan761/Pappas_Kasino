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
        spak.spel = false; //när man visat alla ikoner måste man betala mer för att göra det igen
    }
}
