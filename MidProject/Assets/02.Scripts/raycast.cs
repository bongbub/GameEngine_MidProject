using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class raycast : MonoBehaviour
{

    public Image reticle;
    float timeElapsed;


    void Update()
    {
        raycasting();
    }

    void raycasting()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward * 1000);
        if(Physics.Raycast(transform.position, forward, out hit))
        {

            // 한 프레임당 걸린 시간 : time.deltaTime
            // 지금까지 지나온 시간 : timeElapsed
            timeElapsed = Time.deltaTime + timeElapsed;

            // 3초가 지났을 때 fillAmount 값이 1이 되도록
            reticle.fillAmount = timeElapsed / 3;
            if(timeElapsed >= 3)
            {

                timeElapsed = 3;
                // 클릭됐을 때(레이가 부딪혔을 때)
                // 온클릭에 담겨져있는 함수를 인보크(활성화)해라
                hit.transform.GetComponent<Button>().onClick.Invoke();
            }

        }

        // 버튼에서 나왔을 때 다시 돌아가는 코드
        else
        {
            timeElapsed = timeElapsed - Time.deltaTime;
            reticle.fillAmount = timeElapsed / 3;
            if (timeElapsed <= 0) timeElapsed = 0;
        }
        Debug.DrawRay(transform.position, forward, Color.red);
    }
}
