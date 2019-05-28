using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit collider "+other.name);
        var rigidBody = other.gameObject.GetComponentInParent<Rigidbody>();
        if(rigidBody != null)
        {
            var velocity = rigidBody.velocity;
            velocity.y = jumpForce;
            rigidBody.velocity = velocity;
        }
    }
}
