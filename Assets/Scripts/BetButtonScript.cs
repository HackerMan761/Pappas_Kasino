using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//All kod i det h�r scriptet �r skrivet av Oliver.
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
            Grej = Grej + 1;  //�kar v�rdet av grej
        }

        if(Grej == 100)  //Efter ett par sekunder s� h�nder saker
        {
            ButtonAni.SetBool("Knapptryck", false);  //Animation
            ButtonAni.SetBool("ButtonPress", false);  //Animation
            Grej = 0;  //Resetar timern
            Bool = false;  //G�r s� att den slutar r�kna
        }
        if(NoMoney == true)
        {
            MoneyScript.Bet = 50;  //Kommer inte ih�g vad det h�r g�r
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet != MoneyScript.Money && gameObject.tag == "Green")  //F�r saker att h�nda om man trycker p� den gr�na knappen
        {
            MoneyScript.Bet = MoneyScript.Bet + 50;  //�kar ditt bet med 50
            ButtonAni.SetBool("Knapptryck", true);  //Animation
            Bool = true;  
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet != MoneyScript.Money && gameObject.tag == "Red")  //F�r saker att h�nda om man trycker p� den r�da knappen
        {
            MoneyScript.Bet = MoneyScript.Bet - 50;  //Minskar ditt ber med 50
            ButtonAni.SetBool("ButtonPress", true);  //Animation
            Bool = true;  //Sant
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet == MoneyScript.Money && gameObject.tag == "Green")  
        {
            MoneyScript.Bet = 50;  //G�r s� att man inte kan betta mer �n man har
        }
    }
}
