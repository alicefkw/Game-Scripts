using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_ClosetALL : MonoBehaviour
{
    [SerializeField] GameObject[] icons;

    public void ChangeState()
    {
        if (icons[0].activeSelf)
        {
            for (int i = 0; i < icons.Length; i++)
            {
                icons[i].SetActive(false);
            }
        }

        else if (!icons[0].activeSelf)
        {
            for (int i = 0; i < icons.Length; i++)
            {
                icons[i].SetActive(true);
            }
        }
    }
}
