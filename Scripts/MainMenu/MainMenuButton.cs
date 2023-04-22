using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void Pacmen()
    {
        SceneManager.LoadScene("PacmenStart");
    }

    public void Ridle()
    {
        SceneManager.LoadScene("Ridle");
    }

    public void IceEdge()
    {
        SceneManager.LoadScene("IceEdge");
    }

}
