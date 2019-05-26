using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

    private Animator anim;
    private bool room;
    private int box = 0;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        anim.SetBool("Room", room);
        if (box == 1)
        {
            room = true;
        }
        else room = false;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            box = 1; 
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            box = 0;
        }
    }

}
