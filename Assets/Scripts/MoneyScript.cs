using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public static float Money = 1000;

    public Text MoneyText;

    public Button MPengar;  //Ta bort senare

    // Start is called before the first frame update    
    void Start()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = "Money: " + Money + "₿"; //Ändrar texten som visar hur mycket pengar man har -Oliver

        if(Money < 0) //Ser till så att man inte kan få under 0 pengar -Oliver
        {
            Money = 0;

            //Lägg in bad ending
        }

        if(Money == 1000000)
        {
            //Lägg in good ending
        }
    }

    public void MoreMoney()  //Ta bort senare
    {
        Money = Money + 100;
    }
}
