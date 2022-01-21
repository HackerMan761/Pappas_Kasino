using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public static float Money = 1000;

    public Text MoneyText;

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
        MoneyText.text = "Money: " + Money + "₿"; //Ändrar texten som visar hur mycket pengar man har -Oliver

        if(Money < 0) //Ser till så att man inte kan få under 0 pengar -Oliver
        {
            Money = 0;

            //Lägg in bad ending
            MoneyText.gameObject.SetActive(false);
            badEnd.SetActive(true);
        }

        if(Money > 1000000)
        {
            //Lägg in good ending
            MoneyText.gameObject.SetActive(false);
            goodEnd.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Money = Money + 100000;
        }
    }
}
