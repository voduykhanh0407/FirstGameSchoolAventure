using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string scene_name;

	public void PlayGame ()
    {
        SceneManager.LoadScene(scene_name);
    }

    public void Exit ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
