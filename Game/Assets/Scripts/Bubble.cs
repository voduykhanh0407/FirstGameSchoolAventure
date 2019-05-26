using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour {

    //public int damageToGive;
    public Transform firePoint;
    public GameObject bubblePrefab;

    // Use this for initialization
    void Start () {
   
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            //Destroy(other.gameObject);
            Shoot();
            
        }
    }
    void Shoot()
    {
        Instantiate(bubblePrefab, firePoint.position, firePoint.rotation);
    }

}
