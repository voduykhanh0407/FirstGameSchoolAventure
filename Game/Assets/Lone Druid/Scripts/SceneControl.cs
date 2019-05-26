using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour {

    public int indexScene;
    public string levelName;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Loading scene with build index
            //SceneManager.LoadScene(index);

            //Loading scene with name
            SceneManager.LoadScene(levelName);

            //Restart base scene
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
