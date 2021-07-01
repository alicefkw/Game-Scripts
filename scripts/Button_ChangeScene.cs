using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  ==x==x=x=x Vips changing scene buttons x=x=x==x==  //

/*
    Everytime when a button to change the scene is pressed, we need to
    restore to default some things the player might have changed.

    In our case, the default way is no selected frame in Liasons' scene,
    so if the player selected a frame, changed scene and then came back
    to Liasons, he wouldn't see no frame selected as the default design.
    The same goes to clothes' inventory's tab.

    After we setted those matters, GoTo methods are made to change scenes.
*/

public class Button_ChangeScene : MonoBehaviour
{
    [SerializeField] GameObject[] frames, tabs;
    [SerializeField] GameObject liasons,   clothes,   evo,    view,
                                liasonsBG, clothesBG, evoBG;

    public void DeactiveFrames() //Deactive frame in Liasons when changing scenes
    {
        for (int i = 0; i < frames.Length; i++)
        {
            if (frames[i].activeSelf) frames[i].SetActive(false);
        }
    }

    public void DeactiveTabs()
    {
        for (int i = 0; i < tabs.Length; i++)
        {
            if (tabs[i].activeSelf) tabs[i].SetActive(false);
        }
    }

    public void GoToClothes()
    {
        clothes.SetActive(true);
        liasons.SetActive(false);
        evo.SetActive(false);
        view.SetActive(false);

        //backgrounds
        clothesBG.SetActive(true);
        liasonsBG.SetActive(false);
        evoBG.SetActive(false);
    }

    public void GoToLiasons()
    {
        liasons.SetActive(true);
        evo.SetActive(false);
        clothes.SetActive(false);
        view.SetActive(false);

        liasonsBG.SetActive(true);
        clothesBG.SetActive(false);
        evoBG.SetActive(false);
    }

    public void GoToEvo()
    {
        evo.SetActive(true);
        clothes.SetActive(false);
        liasons.SetActive(false);
        view.SetActive(false);

        evoBG.SetActive(true);
        liasonsBG.SetActive(false);
        clothesBG.SetActive(false);
    }

    public void GoToView()
    {
        view.SetActive(true);
        evo.SetActive(false);
        liasons.SetActive(false);
        clothes.SetActive(false);

        liasonsBG.SetActive(true);
        clothesBG.SetActive(false);
        evoBG.SetActive(false);
    }
}