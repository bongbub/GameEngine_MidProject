//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MainCameraMove : MonoBehaviour
//{

//    private int repeatCount = 0;

//    // ī�޶� �ε����� ���� ����ī�޶���� ����
//    public Camera[] cameras;
//    public void CameraMove(int index)
//    {
//        // ����ī�޶� ������ => �ش� ����ī�޶� ����������
//        // this.transform.position = cameras[index].transform.position;
//        // this.transform.rotation = cameras[index].transform.rotation;


//        // �� �ڵ带 ���������� �����ϰ�
//        Vector3 newPos0 = cameras[index].transform.position;
//        Vector3 newRot0 = cameras[index].transform.eulerAngles; //vector3�� ���Ϸ��ޱ۷� �־���

//        // ���� ����ִ� ���
//        //this.transform.position = newPos;
//        //this.transform.eulerAngles = newRot;

//        // iTween���� ī�޶� ��ȯ
//        iTween.MoveTo(this.gameObject, iTween.Hash("position", newPos0,
//                                                   "easetype", "easeInQuad",
//                                                   "time", 2.0f));
//        //iTween.MoveAdd(this.gameObject, iTween.Hash("position", newPos1,
//        //                                           "easetype", "easeInQuad",
//        //                                           "time", 3.0f));
//        //iTween.MoveAdd(this.gameObject, iTween.Hash("position", newPos2,
//        //                                           "easetype", "easeInQuad",
//        //                                          "time", 3.0f));
//    }

//}
