using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class All : MonoBehaviour
{
    [SerializeField] Sprite allOff, allOn,
                            headOff, earOff, eyeOff, handOff, chestOff, hipsOff, footOff, bagOff, neckOff;
    [SerializeField] GameObject head, neck, bag, chest, eye, ear, foot, hand, hips;
    private Image img, imgHead, imgEar, imgEye, imgHand, imgChest, imgHips, imgFoot, imgBag, imgNeck;

    void Start()
    {
        img = this.GetComponent<Image>();
        imgHead = head.GetComponent<Image>();
        imgEye = eye.GetComponent<Image>();
        imgEar = ear.GetComponent<Image>();
        imgHand = hand.GetComponent<Image>();
        imgChest = chest.GetComponent<Image>();
        imgHips = hips.GetComponent<Image>();
        imgFoot = foot.GetComponent<Image>();
        imgBag = bag.GetComponent<Image>();
        imgNeck = neck.GetComponent<Image>();
    }

    public void Active()
    {
        imgHead.sprite = headOff;
        imgEar.sprite = earOff;
        imgEye.sprite = eyeOff;
        imgHand.sprite = handOff;
        imgChest.sprite = chestOff;
        imgHips.sprite = hipsOff;
        imgFoot.sprite = footOff;
        imgBag.sprite = bagOff;
        imgNeck.sprite = neckOff;

        if (img.sprite == allOff) img.sprite = allOn;
    }
    public void Default()
    {
        if (img.sprite == allOn) img.sprite = allOff;
    }
}
