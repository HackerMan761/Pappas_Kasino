using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetButtonScript : MonoBehaviour
{
    public Animation ButtonAni;

    public float Grej;

    public bool Bool;

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
            ButtonAni.Stop();
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet != MoneyScript.Money)
        {
            MoneyScript.Bet = MoneyScript.Bet + 50;
            ButtonAni.Play();
            Bool = true;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && MoneyScript.Bet == MoneyScript.Money)
        {
            MoneyScript.Bet = 50;
        }

        Debug.Log("Idk");
    }
}
