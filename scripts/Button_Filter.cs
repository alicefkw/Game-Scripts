using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Filter : MonoBehaviour
{
    private Image img;
    [SerializeField] Sprite on, off;


    void Start()
    {
        img = this.GetComponent<Image>();
    }
    public void ChangeSprite()
    {
        if (img.sprite == off)  img.sprite = on;
        else                    img.sprite = off;
    }
}
