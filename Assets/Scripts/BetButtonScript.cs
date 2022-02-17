using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//All kod i det här scriptet är skrivet av Oliver.
public class BetButtonScript : MonoBehaviour  
{
    public Animator ButtonAni;

    public float Grej;

    public bool Bool;
    bool NoMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Bool == true)  
        {
            Grej = Grej + 1;  //Ökar värdet av grej
        }

        if(Grej == 100)  //Efter ett par sekunder så händer saker
        {
            ButtonAni.SetBool("Knapptryck", false);  //Animation
            ButtonAni.SetBool("ButtonPress", false);  //Animation
            Grej = 0;  //Resetar timern
            Bool = false;  //Gör så att den slutar räkna
        }
        if(NoMoney == true)
        {
            MoneyScript.Bet = 50;  //Kommer inte ihåg vad det här gör
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet != MoneyScript.Money && gameObject.tag == "Green")  //Får saker att hända om man trycker på den gröna knappen
        {
            MoneyScript.Bet = MoneyScript.Bet + 50;  //Ökar ditt bet med 50
            ButtonAni.SetBool("Knapptryck", true);  //Animation
            Bool = true;  
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet != MoneyScript.Money && gameObject.tag == "Red")  //Får saker att hända om man trycker på den röda knappen
        {
            MoneyScript.Bet = MoneyScript.Bet - 50;  //Minskar ditt ber med 50
            ButtonAni.SetBool("ButtonPress", true);  //Animation
            Bool = true;  //Sant
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet == MoneyScript.Money && gameObject.tag == "Green")  
        {
            MoneyScript.Bet = 50;  //Gör så att man inte kan betta mer än man har
        }
    }
}
