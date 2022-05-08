using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool IsPaused = false; //bool
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //ako je pritisnuta tipka escape ulazi u petlju
        {
            if (IsPaused) //ako je bool istina
            {
                Resume(); //nastavlja se igra pritiskom gumba
            }
            else //inače
            {
                PauseOn(); //pauza se ukljkučuje
            }
        }
    }
    public void Resume() //metoda za nastavak igre pritiskom gumba
    {
        GameManager.instance.PauseUI.SetActive(false); //pauza se isključuje
        Time.timeScale = 1f; //vrijeme prolazi u realnom vremenu
        IsPaused = false; //bool postaje false
    }
    void PauseOn() //metoda koja uključuje pauzu
    {
        GameManager.instance.PauseUI.SetActive(true); //pauza se prikazuje na canvasu
        Time.timeScale = 0f; //vrijeme se zaustavlja u igri
        IsPaused = true; //bool postaje true
    }
    public void Restart() //metoda za ponovno pokretanje scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //scene manager dohvaća index aktivne scene te se ta ista scena reload-a
    }
    public void GoBack() //metoda za vraćanje u main menu
    {
        SceneManager.LoadScene("MainMenu"); //prebacuje se scena na main menu
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
