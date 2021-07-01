using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ear : MonoBehaviour
{
    [SerializeField] Sprite earOff, earOn,
                            handOff, eyeOff, neckOff, headOff, chestOff, hipsOff, footOff, bagOff, allOff;
    [SerializeField] GameObject head, all, bag, chest, eye, foot, hand, hips, neck;
    private Image img, imgHead, imgEye, imgNeck, imgHand, imgChest, imgHips, imgFoot, imgBag, imgAll;

    void Start()
    {
        img = this.GetComponent<Image>();
        imgHead = head.GetComponent<Image>();
        imgEye = eye.GetComponent<Image>();
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
        imgHead.sprite = headOff;
        imgEye.sprite = eyeOff;
        imgNeck.sprite = neckOff;
        imgHand.sprite = handOff;
        imgChest.sprite = chestOff;
        imgHips.sprite = hipsOff;
        imgFoot.sprite = footOff;
        imgBag.sprite = bagOff;
        imgAll.sprite = allOff;

        if (img.sprite == earOff) img.sprite = earOn;
    }
    public void Default()
    {
        if (img.sprite == earOn) img.sprite = earOff;
    }
}
