using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //for the hp bar and buttons
using Random = UnityEngine.Random;
using Cinemachine;

public class LukeBattle : MonoBehaviour
{
    [SerializeField] private POPUP_NormalAtk popup_normal;
    [SerializeField] private POPUP_Critical popup_critical;
    [SerializeField] private SpecialBar holyBar;

    [SerializeField] private Animator animator;
    [SerializeField] private GameObject lukeArrow,atkposGO,baseposGO,luke,star;
    [SerializeField] private ParticleSystem rainbowEffect;

    [SerializeField] private int damageReceived, criticalDMGReceived;       //HP BAR
    [SerializeField] private float manaReceived = 1, manaCritReceived = 2;  //HOLY BAR

    private float speed = 5f, i = 0;    //transform position's speed and 'i' for each attack i give

    private bool lukeCanAtk = false;
    private Rigidbody2D rb;

    //Vector is variable for places in map. coordinates (X, Y);
    //Vector2 basePosition = new Vector2(-1f, 0f);   //"f" stands for "float". this means our number can be decimal.
    //Vector2 losePosition = new Vector2(3f, -9f);


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //this.transform.position = basePosition;
        star.SetActive(false);
    }


    //go to atk position, go to base position
    private void Move(GameObject goA, GameObject goB, float speedTranslation)
    {
        goA.transform.position = Vector3.MoveTowards(goA.transform.position, goB.transform.position, speedTranslation * Time.deltaTime);
    }

    public void RandomAtk()
    {
        int whichAttack = Random.Range(1, 101);
        if (whichAttack < 71) { lukeArrow.gameObject.tag = "Good1ATK"; }    // 0 ~ 7 (70% normal atk dmg chance)
        else if (whichAttack > 70) { lukeArrow.gameObject.tag = "Good1ATK_CRIT"; } //8 ~ 10 (30% crit dmg chance)
        Attack();
    }

    void Attack() //atk method
    {
        EndDebuffs();
        
        //changeCamera.CameraToAttack();
        Move(luke, atkposGO, speed); //using "move" class with these respectives variables in place of move's variables
        animator.SetBool("atk", true);
        // this.transform.Rotate(0, 0, -10); //rotate to target's side
        if (lukeArrow.gameObject.tag == "Good1ATK_CRIT")
        {
            rainbowEffect.enableEmission = true; //if i'm giving critical damage, a rainbow comes out of my lovely arrow
        }
        else
        {
            star.SetActive(true);
        }

        StartCoroutine("TimerATK1"); //now the next method begins
    }
    public IEnumerator TimerATK1()
    {
        yield return new WaitForSeconds(5.25f); //atk animation time
        animator.SetBool("atk", false);    //stops atk animation
        animator.SetBool("atk_end", true); //and idle animation starts

        if (lukeArrow.gameObject.tag == "Good1ATK_CRIT")
        {
            rainbowEffect.enableEmission = false; //if i'm giving critical damage, a rainbow comes out of my lovely arrow
        }

        Move(luke, baseposGO, speed);
        //changeCamera.CameraToBattle();
        lukeArrow.gameObject.tag = "other";
    }
    IEnumerator TimerTakeDMGend() { yield return new WaitForSeconds(1.1f); EndDebuffs(); } /// if (this.healthBar == null) { this.transform.position = losePosition; animator.SetBool("lose", true); } }

    void EndDebuffs()
    {
        animator.SetBool("hit", false);
        animator.SetBool("crit", false);
        animator.SetBool("hit_end", true);
        animator.SetBool("crit_end", true);
    }

    void OnParticleCollision2D(GameObject other)
    {
        Debug.Log("on particle collision");
        if (other.gameObject.tag == "Evil2ATK")
        {
            Debug.Log("evil2atk col!");
        }

        else if (other.gameObject.tag == "Evil2ATK_CRIT")
        {
            Debug.Log("col crit");
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Evil1ATK") //GETS DAMAGED
        {
            animator.SetBool("hit", true); popup_normal.Appear();
        }
        else if (collider.gameObject.tag == "Evil1ATK_CRIT") //GETS CRITTED
        {
            animator.SetBool("crit", true); popup_critical.Appear();
        }
    }
    //      ENTERING COLLISION /\                     EXITING COLLISION \/
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Evil1ATK") //GETS DAMAGED OFF
        {
            TimerTakeDMGend();
        }
        else if (collider.gameObject.tag == "Evil1ATK_CRIT") //GETS CRITTED OFF
        {
            TimerTakeDMGend();
        }

        else if (collider.gameObject.tag == "Evil1BODY")
        {
            RandomAtk();

            i++; //arrow shot, it takes 2 to finish my attack
            if (i > 1) { holyBar.AddPoint(manaReceived); if (lukeArrow.gameObject.tag == "Good1ATK_CRIT") { Debug.Log("holycrit"); this.holyBar.AddPoint(manaCritReceived); } }
          /*  if (marilynBattleHandler.healthBar == null)
            {
                this.transform.position = losePosition; //when finish my fabulous attack, if marilyn doesn't have hp i win
                animator.SetBool("win", true);
            }*/

        }
    }

    void OnParticleTrigger()
    {
        Debug.Log("Particle hit!!");
    }

}
