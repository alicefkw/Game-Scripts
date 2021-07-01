using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialBar : MonoBehaviour
{
    [SerializeField] private Slider manaBar;
    [SerializeField] private float maxPower = 3f, currentPower = 0f;
    [SerializeField] private Image fill;


    public void AddPoint(float amount)
    {
        currentPower += amount;
        CalculateBar();
    }

    float CalculateBar()
    {
        return currentPower / maxPower;
    }

    void Start()
    {
        manaBar = GetComponent<Slider>();
        manaBar.value = 0;
    }

    void Update()
    {
        manaBar.value = CalculateBar();
    }
}