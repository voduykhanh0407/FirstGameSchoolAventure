using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    private bool isEnter = false;
 
    public Transform m_Wall;
    
	// Use this for initialization
	void Start () {
        isEnter = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isEnter == false)
        {
            isEnter = true;
            m_Wall.transform.position = transform.position;
        }
    }
}
