using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ButtonManager : MonoBehaviour
{

    public GameObject Sphere;
    public VideoClip Clip1;
    public VideoClip Clip2;

    public void ToVideoScene()
    {
        SceneManager.LoadScene("PlayerScene");
    }

    public void GoIn()
    {
        Sphere.GetComponent<VideoPlayer>().clip = Clip2;
    }
    public void GoOut()
    {
        Sphere.GetComponent<VideoPlayer>().clip = Clip1;
    }

    public void GoHome()
    {
        SceneManager.LoadScene("PlayerScene");
    }

}
