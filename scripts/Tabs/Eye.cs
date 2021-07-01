using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eye : MonoBehaviour
{
    [SerializeField] Sprite eyeOff, eyeOn,
                            handOff, earOff, neckOff, headOff, chestOff, hipsOff, footOff, bagOff, allOff;
    [SerializeField] GameObject head, all, bag, chest, ear, foot, hand, hips, neck;
    private Image img, imgHead, imgEar, imgNeck, imgHand, imgChest, imgHips, imgFoot, imgBag, imgAll;

    void Start()
    {
        img = this.GetComponent<Image>();
        imgHead = head.GetComponent<Image>();
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
        imgHead.sprite = headOff;
        imgEar.sprite = earOff;
        imgNeck.sprite = neckOff;
        imgHand.sprite = handOff;
        imgChest.sprite = chestOff;
        imgHips.sprite = hipsOff;
        imgFoot.sprite = footOff;
        imgBag.sprite = bagOff;
        imgAll.sprite = allOff;

        if (img.sprite == eyeOff) img.sprite = eyeOn;
    }
    public void Default()
    {
        if (img.sprite == eyeOn) img.sprite = eyeOff;
    }
}
