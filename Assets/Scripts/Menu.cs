using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //G�r s� att man kommer till n�sta scen i builden -Melvin
    }
    public void QuitGame()
    {

        Application.Quit(); //St�nger ned spelet -Melvin
    }
}
