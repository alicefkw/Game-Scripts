using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPopup : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite yellowTimer, redTimer;

    void Start()
    {
        this.gameObject.SetActive(true);
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    /*public void TurnOff()
    {
        this.gameObject.SetActive(false);
    }
    public void TurnOn()
    {
        this.gameObject.SetActive(true);
    }*/


    public void RedTimer()
    {
        spriteRenderer.sprite = redTimer;
    }
    public void NormalTimer()
    {
        spriteRenderer.sprite = yellowTimer;
    }
}
