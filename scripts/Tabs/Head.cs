using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Head : MonoBehaviour
{
    [SerializeField] Sprite headOff, headOn, 
                            eyeOff, earOff, neckOff, handOff, chestOff, hipsOff, footOff, bagOff, allOff;
    [SerializeField] GameObject eye, all, bag, chest, ear, foot, hand, hips, neck;
    private Image img, imgEye, imgEar, imgNeck, imgHand, imgChest, imgHips, imgFoot, imgBag, imgAll;

    void Start()
    {
        img = this.GetComponent<Image>();
        imgEye = eye.GetComponent<Image>();
        imgEar = ear.GetComponent<Image>();
        imgNeck = neck.GetComponent<Image>();
        imgHand = hand.GetComponent<Image>();
        imgChest = chest.GetComponent<Image>();
        imgHips = hips.GetComponent<Image>();
        imgFoot = foot.GetComponent<Image>();
        imgBag = bag.GetComponent<Image>();
        imgAll = all.GetComponent<Image>();
    }
    public void Active()
    {
        imgEye.sprite = eyeOff;
        imgEar.sprite = earOff;
        imgNeck.sprite = neckOff;
        imgHand.sprite = handOff;
        imgChest.sprite = chestOff;
        imgHips.sprite = hipsOff;
        imgFoot.sprite = footOff;
        imgBag.sprite = bagOff;
        imgAll.sprite = allOff;

        if (img.sprite == headOff) img.sprite = headOn;
    }
    public void Default()
    {
        if (img.sprite == headOn) img.sprite = headOff;
    }
}
