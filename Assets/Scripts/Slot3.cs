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
        spak.spel = false; //n�r man visat alla ikoner m�ste man betala mer f�r att g�ra det igen
    }
}
