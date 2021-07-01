using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    [SerializeField] Sprite chestOff, chestOn,
                            headOff, earOff, eyeOff, neckOff, handOff, hipsOff, footOff, bagOff, allOff;
    [SerializeField] GameObject head, all, bag, hand, eye, ear, foot, hips, neck;
    private Image img, imgHead, imgEar, imgEye, imgNeck, imgHand, imgHips, imgFoot, imgBag, imgAll;

    void Start()
    {
        img = this.GetComponent<Image>();
        imgHead = head.GetComponent<Image>();
        imgEye = eye.GetComponent<Image>();
        imgEar = ear.GetComponent<Image>();
        imgNeck = neck.GetComponent<Image>();
        imgHand = hand.GetComponent<Image>();
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
        imgHand.sprite = handOff;
        imgHips.sprite = hipsOff;
        imgFoot.sprite = footOff;
        imgBag.sprite = bagOff;
        imgAll.sprite = allOff;

        if (img.sprite == chestOff) img.sprite = chestOn;
    }
    
    public void Default()
    {
        if (img.sprite == chestOn) img.sprite = chestOff;
    }
}
