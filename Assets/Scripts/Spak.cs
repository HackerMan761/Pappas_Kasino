using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spak : MonoBehaviour
{
    public float TimeThing;

    public AudioSource MoneyDown;

    void Update()
    {
        if(TimeThing == 600)  //Tar bort pengar när den når 600 (200 är ungefär 1 sekund) -Oliver
        {
            MoneyScript.Money = MoneyScript.Money - 50;

            MoneyDown.Play();  //Spelar ett ljud när du spenderar pengar -Melvin
        }
    }

    public void OnMouseOver()
    {
        if(Input.GetMouseButton(0))
        {
            TimeThing = TimeThing + 1;  //Den ökar timern när man håller ner musen -Melvin
        }
    }

    public void OnMouseUp()
    {
        TimeThing = 0; //Resetar timer grejen när man slutar hålla ner musen -Oliver
    }
}
