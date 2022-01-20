using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spak : MonoBehaviour
{
    public float TimeThing;

    public AudioSource MoneyDown;

    void Update()
    {
        if(TimeThing == 600)  //Tar bort pengar n�r den n�r 600 (200 �r ungef�r 1 sekund) -Oliver
        {
            MoneyScript.Money = MoneyScript.Money - 50;

            MoneyDown.Play();  //Spelar ett ljud n�r du spenderar pengar -Melvin
        }
    }

    public void OnMouseOver()
    {
        if(Input.GetMouseButton(0))
        {
            TimeThing = TimeThing + 1;  //Den �kar timern n�r man h�ller ner musen -Melvin
        }
    }

    public void OnMouseUp()
    {
        TimeThing = 0; //Resetar timer grejen n�r man slutar h�lla ner musen -Oliver
    }
}
