using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPhysicsController : MonoBehaviour
{
    Collider trackBounds;
    [SerializeField] private float thrust = 10f;

    // Start is called before the first frame update
    void Start()
    {
        trackBounds = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    
    private void OnTriggerStay(Collider collider)
    {
        GameObject curr = collider.gameObject;
        Rigidbody ObjectRigidbody = curr.GetComponent<Rigidbody>();
        Vector3 direction = ObjectRigidbody.velocity.normalized;
        Vector3 newforce = direction * thrust;
        ObjectRigidbody.AddForce(newforce, ForceMode.VelocityChange);

    }

    private void OnTriggerExit(Collider other)
    {
        GameObject curr = other.gameObject;
        Rigidbody ObjectRigidbody = curr.GetComponent<Rigidbody>();
        Vector3 direction = ObjectRigidbody.velocity.normalized;
        ObjectRigidbody.velocity = direction / 2;

    }


}
