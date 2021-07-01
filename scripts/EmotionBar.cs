using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmotionBar : MonoBehaviour
{
    public Slider emotionBar;
    [SerializeField] private Image Fill;
    [SerializeField] private Color MinNegative, Negative, MaxNegative, MinPositive, Positive, MaxPositive;
    private float maxPoint = 100f, minPoint = -100f, point = 0f;

    //ORDEM ===
    //MaxNegative, Negative, MinNegative
    //MinPositive, Positive, MaxPositive
    public void Increase(float amount)
    {
        point += amount;
        CalculateBar();
    }

    public void Decrease(float amount)
    {
        point -= amount;
        CalculateBar();
    }

    float CalculateBar()
    {
        return point / maxPoint;
        //POSITIVE BAR'S COLOR
        if (point > 0) { Fill.color = MinPositive; Fill.color = Color.Lerp(MinNegative, MinPositive, emotionBar.value / 20); }
        else if (point >= 20) Fill.color = Color.Lerp(MinPositive, Positive, emotionBar.value / 20);
        else if (point >= 50) Fill.color = Color.Lerp(Positive, MaxPositive, emotionBar.value / 20);
        //NEGATIVE BAR'S COLOR
        else if (point <= 0) { Fill.color = MinNegative; Fill.color = Color.Lerp(MinPositive, MinNegative, emotionBar.value / 20); }
        else if (point <= -20) Fill.color = Color.Lerp(MinNegative, Negative, emotionBar.value / 20);
        else if (point <= -50) Fill.color = Color.Lerp(Negative, MaxNegative, emotionBar.value / 20);
    }

    void Start()
    {
        emotionBar.minValue = -100;
        emotionBar.maxValue = 100;
    }

    void Update()
    {
        emotionBar.value = CalculateBar();
    }
}