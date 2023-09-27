using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CameraMove : MonoBehaviour
{

    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject tutorialCamera;


    
    void OnTriggerEnter2D(Collider2D collision)
    {
        lvl2Cam();
    }

    public void lvl2Cam()
    {
        Camera.SetActive(true);
        tutorialCamera.SetActive(false);
    }

}
