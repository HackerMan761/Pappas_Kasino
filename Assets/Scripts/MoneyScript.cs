using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Oliver
public class MoneyScript : MonoBehaviour
{
    public static float Money = 1000; 
    public static float Bet = 50;

    public Text MoneyText;
    public Text CurrentBet;

    public GameObject badEnd;
    public GameObject goodEnd;


    // Start is called before the first frame update    
    void Start()
    {
        badEnd.SetActive(false);
        goodEnd.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = "Money: " + Money + "₿"; //Ändrar texten som visar hur mycket pengar man har 
        CurrentBet.text = "Current Bet: " + Bet; 

        if (Money < 0) //Ser till så att man inte kan få under 0 pengar 
        {
            Money = 0;

            //bad ending
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

        if (Money > 1000000)
        {
            //good ending
            MoneyText.gameObject.SetActive(false);
            CurrentBet.gameObject.SetActive(false);
            goodEnd.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.G))  //Temporärt sätt att få pengar.
        {
            Money = Money + 100000;
        }


        //Bet
        if(Bet > 250)  //Max bet 
        {
            Bet = 50;
        }
        if(Bet > Money)  //Kan inte gå över pengar 
        {
            Bet = Money;
        }
        if(Bet < 50)  //Gör så att man inte kan betta under 50; 
        {
            Bet = 250;
        }
    }
}
