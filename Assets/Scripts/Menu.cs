using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Gör så att man kommer till nästa scen i builden -Melvin
    }
    public void QuitGame()
    {

        Application.Quit(); //Stänger ned spelet -Melvin
    }
}
