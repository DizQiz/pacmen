using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonVictory : MonoBehaviour
{
    public void ReStartGame()
    {
        SceneManager.LoadScene("Pacmen");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
