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

            // �� �����Ӵ� �ɸ� �ð� : time.deltaTime
            // ���ݱ��� ������ �ð� : timeElapsed
            timeElapsed = Time.deltaTime + timeElapsed;

            // 3�ʰ� ������ �� fillAmount ���� 1�� �ǵ���
            reticle.fillAmount = timeElapsed / 3;
            if(timeElapsed >= 3)
            {

                timeElapsed = 3;
                // Ŭ������ ��(���̰� �ε����� ��)
                // ��Ŭ���� ������ִ� �Լ��� �κ�ũ(Ȱ��ȭ)�ض�
                hit.transform.GetComponent<Button>().onClick.Invoke();
            }

        }

        // ��ư���� ������ �� �ٽ� ���ư��� �ڵ�
        else
        {
            timeElapsed = timeElapsed - Time.deltaTime;
            reticle.fillAmount = timeElapsed / 3;
            if (timeElapsed <= 0) timeElapsed = 0;
        }
        Debug.DrawRay(transform.position, forward, Color.red);
    }
}
