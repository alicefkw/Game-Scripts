using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Slider is an UI element so we need this engine

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private float maxHealth = 1000f, currentHealth = 0f;

    [SerializeField] private Color Low, Medium, Normal;
    [SerializeField] private Image fill;

    Rigidbody2D rb;

    //so the plan here is, the healthbar starts in 100 hp and each atk received is less 15 hp
    //so we have to give 7 attacks to kill the oponent, but there is a small chance of critical atk
    //that it's damage is 25 so who crits first win with 6 atks


    public void TakeDamage(float amount)
    {
        currentHealth -= amount;//health = health - amount;  100 = 100 - 15
        CalculateHealth();
    }
    public void TakeCritical(float criticalAmount)
    {
        currentHealth -= criticalAmount;
        CalculateHealth();
    }
    public void GainHealth(float gain)
    {
        currentHealth += gain;
        CalculateHealth();
    }

    float CalculateHealth()
    {
        return currentHealth / maxHealth;  // HP FULL: 100/100 -> VALUE = 1
                                           // 1 HIT:   85/100 -> VALUE = 0,85 [...]
        if (currentHealth == 0) fill.gameObject.SetActive(false);
    }

    private void Awake()
    {
        healthBar = GetComponent<Slider>();
        rb = GetComponent<Rigidbody2D>();

        /*  pfLuke = GameObject.FindWithTag("Luke");
          pfMarilyn = GameObject.FindWithTag("Marilyn");
          pfDandelion = GameObject.FindWithTag("Dandelion");
          pfDamian = GameObject.FindWithTag("Damian");

          lukeHPbar = GameObject.FindWithTag("Good1HPBar");
          damianHPbar = GameObject.FindWithTag("Evil1HPBar");
          dandelionHPbar = GameObject.FindWithTag("Good2PBar");
          marilynHPbar = GameObject.FindWithTag("Evil2HPBar");*/
    }
    private void Start() //ready to battle!
    {
        currentHealth = maxHealth; //health = 100
    }
    private void Update() //once per frame
    {
        healthBar.value = CalculateHealth();

        if (currentHealth <= maxHealth) { gameObject.SetActive(true); }

        if (currentHealth > maxHealth) { currentHealth = maxHealth; } //don't bug please!

        if (currentHealth <= 0) { currentHealth = 0; }//        Destroy(gameObject); }
    }
}