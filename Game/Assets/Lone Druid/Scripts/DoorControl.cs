using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour {


    Rigidbody2D rigid;
    BoxCollider2D boxx;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        rigid.GetComponent<Rigidbody2D>();
        boxx.GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider other)
    {
      
    }

    /*void OnTriggerExit(Collider other)
    {
        aim.SetTrigger("LockDoor");
    }*/
}
