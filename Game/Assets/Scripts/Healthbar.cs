using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
    public Image currentHealthbar;
    public Text ratioText;

    public float hitpoint = 150;
    public float maxHitpoint = 150;

    private void Start()
    {
        hitpoint = maxHitpoint;
    }

    private void Update()
    {
        float ratio = hitpoint / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString("0") + '%';

    }


    public void HurtPlayer(int damageToGive)
    {
        hitpoint -= damageToGive;

        if (hitpoint <= 0)
        {
            SceneManager.LoadScene("GameOver");

        }
    }





    /*public void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if(hitpoint < 0)
        {
            hitpoint = 0;
            Debug.Log("Dead!");
        }

        UpdateHealthbar();
    }

    public void HealDamage(float heal)
    {
        hitpoint += heal;
        if (hitpoint > maxHitpoint)
            hitpoint = maxHitpoint;

        UpdateHealthbar();
    }*/
}
