using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject ThePlayer = GameObject.FindGameObjectWithTag("Player");

        ThePlayer.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
