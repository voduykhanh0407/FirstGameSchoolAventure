using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDetroy : MonoBehaviour {

    private static bool PlayerExits = false;

    // Use this for initialization
    void Start()
    {
        if (!PlayerExits)
        {
            PlayerExits = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
