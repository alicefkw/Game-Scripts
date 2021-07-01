using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Neck : MonoBehaviour
{
    [SerializeField] Sprite neckOff, neckOn,
                            headOff, earOff, eyeOff, handOff, chestOff, hipsOff, footOff, bagOff, allOff;
    [SerializeField] GameObject head, all, bag, chest, eye, ear, foot, hand, hips;
    private Image img, imgHead, imgEar, imgEye, imgHand, imgChest, imgHips, imgFoot, imgBag, imgAll;

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
        imgAll = all.GetComponent<Image>();
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
        imgAll.sprite = allOff;

        if (img.sprite == neckOff)  img.sprite = neckOn;
    }

    public void Default()
    {
        if (img.sprite == neckOn) img.sprite = neckOff;
    }
}
