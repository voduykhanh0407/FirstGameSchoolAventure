using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden_Wall : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Enemy" || other.gameObject.name == "Buttlet")
        {
            other.transform.position = transform.position;
            
        }
    }


}
