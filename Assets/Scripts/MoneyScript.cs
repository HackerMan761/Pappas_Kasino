using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public float Money;

    public Text MoneyText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = "Money: " + Money;

        if (Input.GetKeyDown(KeyCode.O))
        {
            Money = Money + 1;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Money = Money - 1;
        }

        if(Money < 0)
        {
            Money = 0;
        }
    }
}
