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
        MoneyText.text = "Money: " + Money; //�ndrar texten som visar hur mycket pengar man har -Oliver

        if (Input.GetKeyDown(KeyCode.O)) //Ger mer p�ngar -Oliver
        {
            Money = Money + 1;
        }
        if (Input.GetKeyDown(KeyCode.P)) //Tar bort pengar -Oliver
        {
            Money = Money - 1;
        }

        if(Money < 0) //Ser till s� att man inte kan f� under 0 pengar -Oliver
        {
            Money = 0;
        }
    }
}
