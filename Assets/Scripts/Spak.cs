using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spak : MonoBehaviour
{
    public float TimeThing;

    void Update()
    {
        if(TimeThing == 1000)  //Tar bort pengar n�r den n�r 1000 -Oliver
        {
            MoneyScript.Money = MoneyScript.Money - 50;
        }
    }

    public void OnMouseOver()
    {
        if(Input.GetMouseButton(0))
        {
            TimeThing = TimeThing + 1;
        }
    }

    public void OnMouseUp()
    {
        TimeThing = 0; //Resetar timer grejen n�r man slutar h�lla ner musen -Olver
    }
}
