using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public static float Money = 1000;
    public static float Bet = 50;

    public Text MoneyText;
    public Text CurrentBet;

    public GameObject badEnd;
    public GameObject goodEnd;

    public Button restart;

    // Start is called before the first frame update    
    void Start()
    {
        badEnd.SetActive(false);
        goodEnd.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = "Money: " + Money + "₿"; //Ändrar texten som visar hur mycket pengar man har -Oliver
        CurrentBet.text = "Current Bet: " + Bet; 

        if (Money < 0) //Ser till så att man inte kan få under 0 pengar -Oliver
        {
            Money = 0;

            //bad ending
            MoneyText.gameObject.SetActive(false);
            badEnd.SetActive(true);
        }

        if (Money > 1000000)
        {
            //good ending
            MoneyText.gameObject.SetActive(false);
            goodEnd.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Money = Money + 100000;
        }


        //Bet


        /*
        if (Input.GetKeyDown(KeyCode.Tab) && Bet != Money)  //Om man trycker på tab och bet inte = money så lägger den till 50 i ditt bet -Oliver
        {
            Bet = Bet + 50;
        }
        if(Input.GetKeyDown(KeyCode.Tab) && Bet == Money)  //Om Bet är lika mycket som money och man trycker på tab så gör den så att den blir 50 -Oliver
        {
            Bet = 50;
        }
        */
        if(Bet > 250)  //Max bet -Oliver
        {
            Bet = 50;
        }
        if(Bet > Money)  //Kan inte gå över pengar -Oliver
        {
            Bet = Money;
        }
    }
}
