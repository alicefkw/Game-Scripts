using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Foot : MonoBehaviour
{
    [SerializeField] Sprite footOff, footOn,
                            headOff, earOff, eyeOff, handOff, chestOff, neckOff, hipsOff, bagOff, allOff;
    [SerializeField] GameObject head, all, bag, chest, eye, ear, hips, hand, neck;
    private Image img, imgHead, imgEar, imgEye, imgHand, imgChest, imgNeck, imgHips, imgBag, imgAll;

    void Start()
    {
        img = this.GetComponent<Image>();
        imgHead = head.GetComponent<Image>();
        imgEye = eye.GetComponent<Image>();
        imgEar = ear.GetComponent<Image>();
        imgHand = hand.GetComponent<Image>();
        imgChest = chest.GetComponent<Image>();
        imgNeck = neck.GetComponent<Image>();
        imgHips = hips.GetComponent<Image>();
        imgBag = bag.GetComponent<Image>();
        imgAll = all.GetComponent<Image>();
    }

    public void Active()
    {
        imgHead.sprite = headOff;
        imgEar.sprite = earOff;
        imgEye.sprite = eyeOff;
        imgHand.sprite = handOff;
        imgChest.sprite = chestOff;
        imgNeck.sprite = neckOff;
        imgHips.sprite = hipsOff;
        imgBag.sprite = bagOff;
        imgAll.sprite = allOff;

        if (img.sprite == footOff) img.sprite = footOn;
    }
    public void Default()
    {
        if (img.sprite == footOn) img.sprite = footOff;
    }
}
