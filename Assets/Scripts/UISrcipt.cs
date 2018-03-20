using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISrcipt : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    void Load()
    {
        Invoke("Play", 0.5f);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("OMEGALUL");
    }

}
