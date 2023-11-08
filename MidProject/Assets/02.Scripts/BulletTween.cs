using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTween : MonoBehaviour
{
    public Transform[] pos;   // 총알 Path Point 받아올 list
    public GameObject bullet;
    public Transform spawnpos;
    GameObject bulClone;

    [Range(0, 1)]
    public float value;

    public float speed = 1;

    void Start()
    {
        //GameObject bulClone = Instantiate(bullet, spawnpos.position, spawnpos.rotation);
        Debug.Log("총알생성");
        bullet.SetActive(false);
    }

    void Update()
    {

        //// 방향키 확인

        if (Input.GetKey(KeyCode.Space))
        {
            bullet.SetActive(true);
            if (GameObject.FindGameObjectsWithTag("Bullet").Length > 0)
            {
                Debug.Log("총알이미존재");
            }
            else
            {
                //bullet = Instantiate(bullet, spawnpos.position, spawnpos.rotation);

            }
            iTween.PutOnPath(bullet, pos, value);
            if (value < 1)
            {
                value += Time.deltaTime / 10;
            }
        }
        else
        {

        }


    }

    public void OnDrawGizmos()
    {
        iTween.DrawPath(pos);
    }

    void onFinished()
    {

    }

}
