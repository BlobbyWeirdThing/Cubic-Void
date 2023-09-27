using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{

    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject tutorialCamera;
    [SerializeField] private GameObject Player;
    [SerializeField] private AudioClip deathSound;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Sound.instance.PlaySound(deathSound);
            Player.transform.position = new Vector3((float)-16.41, (float)7.49, 0);
            Camera.SetActive(false);
            tutorialCamera.SetActive(true);
            

            //Destroy(Player);
        }
    }
}
