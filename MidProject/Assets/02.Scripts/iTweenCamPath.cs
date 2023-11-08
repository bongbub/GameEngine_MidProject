using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTweenCamPath : MonoBehaviour
{

    public Transform[] tr;
    public Camera mycamera; // camera��������
    public Transform player;
    public Transform Playcamset;


    [Range(0, 1)]
    public float Val;



    void Start()
    {

    }

    void Update()
    {
        if(Val < 1)
        {
            Val += Time.deltaTime / 10;
            mycamera.transform.LookAt(player);
        }
        iTween.PutOnPath(mycamera.gameObject.transform, tr, Val) ;
       
        if (Val >= 1)
        {
            mycamera.transform.LookAt(Playcamset);
        }

        // ī�޶� �÷��̾� �ٶ󺸰�
        //mycamera.transform.LookAt(player);
    }

    // Path ��� ������ ���̰�
    private void OnDrawGizmos() 
    {
        iTween.DrawPath(tr, Color.red);
    }

    void OnFinished()
    {
        iTween.Stop();
    }
}
