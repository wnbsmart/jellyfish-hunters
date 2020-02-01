using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //go to the next scene in the queue (check under File -> BuildSettings menu)
    }

    public void ExitGame()
    {
        Debug.Log("Quit!");
        Application.Quit(); // quitting game works, but it can't be seen in Unity
    }
}
