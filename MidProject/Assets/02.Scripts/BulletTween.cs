using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTween : MonoBehaviour
{
    public Transform[] pos;   // �Ѿ� Path Point �޾ƿ� list
    public GameObject bullet;
    public Transform spawnpos;
    GameObject bulClone;

    [Range(0, 1)]
    public float value;

    public float speed = 1;

    void Start()
    {
        //GameObject bulClone = Instantiate(bullet, spawnpos.position, spawnpos.rotation);
        Debug.Log("�Ѿ˻���");
        bullet.SetActive(false);
    }

    void Update()
    {

        //// ����Ű Ȯ��

        if (Input.GetKey(KeyCode.Space))
        {
            bullet.SetActive(true);
            if (GameObject.FindGameObjectsWithTag("Bullet").Length > 0)
            {
                Debug.Log("�Ѿ��̹�����");
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
