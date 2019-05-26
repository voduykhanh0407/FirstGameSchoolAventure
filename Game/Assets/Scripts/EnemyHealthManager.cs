using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int MaxHealth;
    public int CurrentHealth;
    public int damageToGive=5;




    // Use this for initialization
    void Start () {

        CurrentHealth = MaxHealth;

		
	}
	
	// Update is called once per frame
	void Update () {
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);

        }
	}

    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //Destroy(other.gameObject);
            HurtEnemy(damageToGive);
        }*/
       
}
