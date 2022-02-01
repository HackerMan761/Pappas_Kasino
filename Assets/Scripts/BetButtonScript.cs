using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Grej = Grej + 1;
        }

        if(Grej == 100)
        {
            ButtonAni.SetBool("Knapptryck", false);
            ButtonAni.SetBool("ButtonPress", false);
            Grej = 0;
            Bool = false;
        }
        if(NoMoney == true)
        {
            MoneyScript.Bet = 50;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet != MoneyScript.Money && gameObject.tag == "Green")
        {
            MoneyScript.Bet = MoneyScript.Bet + 50;
            ButtonAni.SetBool("Knapptryck", true);
            Bool = true;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet != MoneyScript.Money && gameObject.tag == "Red")
        {
            MoneyScript.Bet = MoneyScript.Bet - 50;
            ButtonAni.SetBool("ButtonPress", true);
            Bool = true;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet == MoneyScript.Money && gameObject.tag == "Green")
        {
            MoneyScript.Bet = 50;
        }
        



        Debug.Log("Idk");
    }
}
