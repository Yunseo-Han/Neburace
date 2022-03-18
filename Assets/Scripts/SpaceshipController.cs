using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float speed;
    public Transform controllerTransform;
    Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();

        //Set the angular velocity of the Rigidbody (rotating around the Y axis, 100 deg/sec)
        
    }

    void FixedUpdate()
    {
        m_EulerAngleVelocity = controllerTransform.localRotation.eulerAngles * speed;
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
    }
}
