using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour
{
    [SerializeField] Sprite bagOff, bagOn,
                            headOff, earOff, eyeOff, handOff, chestOff, hipsOff, footOff, allOff, neckOff;
    [SerializeField] GameObject head, neck, all, chest, eye, ear, foot, hand, hips;
    private Image img, imgHead, imgEar, imgEye, imgHand, imgChest, imgHips, imgFoot, imgAll, imgNeck;

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
        imgAll = all.GetComponent<Image>();
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
        imgNeck.sprite = neckOff;
        imgAll.sprite = allOff;

        if (img.sprite == bagOff) img.sprite = bagOn;
    }
    public void Default()
    {
        if (img.sprite == bagOn) img.sprite = bagOff;
    }
}
