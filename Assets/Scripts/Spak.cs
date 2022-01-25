using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spak : MonoBehaviour
{
    public float TimeThing = 0;
    public bool spel = false;
    public AudioSource MoneyDown;
    public bool anim = false;
    void Update()
    {
        if(TimeThing == 100)  //Tar bort pengar n�r den n�r 100 (200 �r ungef�r 1 sekund) -Oliver
        {
            MoneyScript.Money = MoneyScript.Money - MoneyScript.Bet;

            MoneyDown.Play();  //Spelar ett ljud n�r du spenderar pengar -Melvin

            spel = true;
            anim = false;
        }
    }

    public void OnMouseOver()
    {
        if(Input.GetMouseButton(0))
        {
            anim = true;
            TimeThing = TimeThing + 1;  //Den �kar timern n�r man h�ller ner musen -Melvin
        }
    }

    public void OnMouseUp()
    {
        anim = false;
        TimeThing = 0; //Resetar timer grejen n�r man slutar h�lla ner musen -Oliver
    }
}