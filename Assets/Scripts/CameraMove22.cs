using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CameraMove22 : MonoBehaviour
{

    [SerializeField] private GameObject lvl2cam;
    [SerializeField] private GameObject tutorialCameraa;

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        lvl22Cam();
    }

    public void lvl22Cam()
    {
        lvl2cam.SetActive(false);
        tutorialCameraa.SetActive(true);
    }

}
