using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    [SerializeField] Sprite handOff, handOn,
                            headOff, earOff, eyeOff, neckOff, chestOff, hipsOff, footOff, bagOff, allOff;
    [SerializeField] GameObject head, all, bag, chest, eye, ear, foot, hips, neck;
    private Image img, imgHead, imgEar, imgEye, imgNeck, imgChest, imgHips, imgFoot, imgBag, imgAll;

    void Start()
    {
        img = this.GetComponent<Image>();
        imgHead = head.GetComponent<Image>();
        imgEye = eye.GetComponent<Image>();
        imgEar = ear.GetComponent<Image>();
        imgNeck = neck.GetComponent<Image>();
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
        imgHead.sprite = headOff;
        imgChest.sprite = chestOff;
        imgHips.sprite = hipsOff;
        imgFoot.sprite = footOff;
        imgBag.sprite = bagOff;
        imgAll.sprite = allOff;

        if (img.sprite == handOff) img.sprite = handOn;
    }
    public void Default()
    {
        if (img.sprite == handOn) img.sprite = handOff;
    }
}
