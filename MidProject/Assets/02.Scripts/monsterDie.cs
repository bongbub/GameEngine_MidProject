using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterDie : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;
    GameObject win1;
    GameObject win2;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        win1 = GameObject.FindWithTag("UI1");
        win2 = GameObject.FindWithTag("UI2");


    }
    void Start()
    {
        win1.SetActive(false);
        win2.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            OnDamage();
        }
    }

    void OnDamage()
    {
        GameObject.FindWithTag("Bullet");
        anim.SetBool("isHit", true);
        Invoke("PlayerWin", 0.5f);
    }

    void PlayerWin()
    {
        win1.SetActive(true);
        win2.SetActive(true);

    }
}
