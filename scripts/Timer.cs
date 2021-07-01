using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TimerPopup timerPopup; //text's popup
    [SerializeField] private TextMeshPro text; //the text that will appear in game
    [SerializeField] private float seconds = 15; //player's total time,you should modify here if in inspector doesn't work

    [SerializeField] DamianBattle damianBattle; //here enters the process if the player doesn't do nothing in time
    [SerializeField] MarilynBattle marilynBattle;
    [SerializeField] DandelionBattle dandelionBattle;
    [SerializeField] LukeBattle lukeBattle;
    [SerializeField] GameObject battleScene,damian,marilyn,dandelion,luke;
    [SerializeField] GameObject[] skill;

    private int integerSeconds;
    private float speed = 1f; //speed time in seconds to decrease, this means decreasing after every 1 second


    void Start() //game start 
    {
        text = gameObject.GetComponent<TextMeshPro>(); //makes text as an usable Text type
    }
    void Update() //once per frame
    {
        if (battleScene.gameObject.active) StartCountTime();
    }


    public void RandomAtk()
    {
        int which = Random.Range(0, 100);
        if (which < 50)
        {
            if (damian.activeSelf == true)          damianBattle.RandomAtk();
            else if (marilyn.activeSelf == true)    marilynBattle.RandomAtk();
        }
        else if (which > 50)
        {
            if (dandelion.activeSelf == true)       dandelionBattle.RandomAtk();
            else if (luke.activeSelf == true)       lukeBattle.RandomAtk();
            h
        }
    }
    void StartCountTime()
    {
        seconds -= Time.deltaTime * speed; // seconds = seconds - time*1sec
        integerSeconds = Mathf.RoundToInt(seconds);
        text.text = integerSeconds.ToString() + (" s");
        if (seconds <= 5) timerPopup.RedTimer();
        if(seconds <= 0)
        {
            Debug.Log("0 seconds");
            Destroy(this.gameObject);
            Destroy(text.gameObject);
            //this.gameObject.SetActive(false); text.gameObject.SetActive(false);// timerPopup.TurnOff();
            for (int i = 0; i < skill.Length; i++)
            {
                skill[i].gameObject.SetActive(false); //all the skills buttons disappears
            }
            RandomAtk();
        }
       // else timerPopup.NormalTimer();
    }
}
