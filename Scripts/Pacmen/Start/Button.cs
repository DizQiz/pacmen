using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene("Pacmen");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
