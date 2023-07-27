using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour
{
    public void PlayGame() //Button Funktion, Play Button
    {
        SceneManager.LoadScene(2);// lädt die Szene Streckenauswahl
    }

    public void TrackSelect()//Button Funktion , Track1 Button
    {
        SceneManager.LoadScene(1);// lädt die Game Szene 
    }
    public void MainMenu() // Button Funktion , Back Taste 
    {
        SceneManager.LoadScene(0); //lädt das Main Menu
    }
    public void QuitGame()
   {
        Application.Quit();
    }
    public void NightRider() // Button Funktion , Back Taste 
    {
        SceneManager.LoadScene(3); //lädt das Main Menu
    }
}
