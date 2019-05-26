using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BossTom : MonoBehaviour {

    public Image currentHealthbar;

    public float hitpoint = 1000;
    public float maxHitpoint = 1000;
    public int damageToGive;
    float ratio;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ratio = hitpoint / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);

    }
    public void HurtBoss(int damageToGive)
    {
        hitpoint -= damageToGive;

        if (hitpoint <= 0)
        {
            Destroy(gameObject);
            currentHealthbar.rectTransform.localScale = new Vector3(ratio, 0, 0);
            SceneManager.LoadScene("YouWin");
        }


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            HurtBoss(damageToGive);
        }
    }
}