using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTweenCamPath : MonoBehaviour
{

    public Transform[] tr;
    public Camera mycamera; // camera가져오기
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

        // 카메라가 플레이어 바라보게
        //mycamera.transform.LookAt(player);
    }

    // Path 경로 선으로 보이게
    private void OnDrawGizmos() 
    {
        iTween.DrawPath(tr, Color.red);
    }

    void OnFinished()
    {
        iTween.Stop();
    }
}
