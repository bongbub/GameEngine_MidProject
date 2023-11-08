//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MainCameraMove : MonoBehaviour
//{

//    private int repeatCount = 0;

//    // 카메라 인덱스를 만들어서 서브카메라들을 담음
//    public Camera[] cameras;
//    public void CameraMove(int index)
//    {
//        // 메인카메라 포지션 => 해당 서브카메라 포지션으로
//        // this.transform.position = cameras[index].transform.position;
//        // this.transform.rotation = cameras[index].transform.rotation;


//        // 위 코드를 변수값으로 간결하게
//        Vector3 newPos0 = cameras[index].transform.position;
//        Vector3 newRot0 = cameras[index].transform.eulerAngles; //vector3라서 오일러앵글로 넣어줌

//        // 기존 집어넣는 방법
//        //this.transform.position = newPos;
//        //this.transform.eulerAngles = newRot;

//        // iTween으로 카메라 전환
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
