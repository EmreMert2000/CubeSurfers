using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float vectorSpeed;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * vectorSpeed * Time.deltaTime;
        transform.Translate(horizontal, 0, forwardSpeed * Time.deltaTime);

    }
}
