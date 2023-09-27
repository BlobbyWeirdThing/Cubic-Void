using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{

    private bool isFacingRight = true;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D) && isFacingRight == false)
        {
            flip();
        }

        if (Input.GetKeyDown(KeyCode.A) && isFacingRight)
        {
            flip();
        }

    }

    private void flip()
    {

        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;

    }

}
