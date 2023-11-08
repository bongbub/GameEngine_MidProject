using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTweenPath : MonoBehaviour
{
    public Transform[] pos;
    void Start()
    {
        
    }


    public void OnDrawGizmos()
    {
        iTween.DrawPath(pos);
    }
}
