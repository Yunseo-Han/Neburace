using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class TestMovementController : MonoBehaviour
{
    Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            playerRB.AddForce(Vector3.right);
            //transform.position += Vector3.right;
        } else if (Keyboard.current.leftArrowKey.isPressed)
        {
            playerRB.AddForce(Vector3.left);
            //transform.position += Vector3.left;
        }
    }



}
