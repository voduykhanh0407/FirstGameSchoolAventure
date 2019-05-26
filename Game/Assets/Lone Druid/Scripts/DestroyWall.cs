using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour {

    public string E_name;
    public string W_name;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        GameObject[] Enemy = GameObject.FindGameObjectsWithTag(E_name);

        GameObject[] wall = GameObject.FindGameObjectsWithTag(W_name);

        if (Enemy.Length == 0)
        {
            for (var i = 0; i < wall.Length; i++)
            {
                Destroy(wall[i]);
            }
        }
    }
}

