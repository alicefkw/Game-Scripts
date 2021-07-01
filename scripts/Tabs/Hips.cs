using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hips : MonoBehaviour
{
    [SerializeField] Sprite hipsOff, hipsOn,
                            headOff, earOff, eyeOff, handOff, chestOff, neckOff, footOff, bagOff, allOff;
    [SerializeField] GameObject head, all, bag, chest, eye, ear, foot, hand, neck;
    private Image img, imgHead, imgEar, imgEye, imgHand, imgChest, imgNeck, imgFoot, imgBag, imgAll;

    void Start()
    {
        img = this.GetComponent<Image>();
        imgHead = head.GetComponent<Image>();
        imgEye = eye.GetComponent<Image>();
        imgEar = ear.GetComponent<Image>();
        imgHand = hand.GetComponent<Image>();
        imgChest = chest.GetComponent<Image>();
        imgNeck = neck.GetComponent<Image>();
        imgFoot = foot.GetComponent<Image>();
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
        imgFoot.sprite = footOff;
        imgBag.sprite = bagOff;
        imgAll.sprite = allOff;

        if (img.sprite == hipsOff) img.sprite = hipsOn;
    }

    public void Default()
    {
        if (img.sprite == hipsOn) img.sprite = hipsOff;
    }
}
