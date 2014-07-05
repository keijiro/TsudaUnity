using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector3.up * 300);
        }
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(Vector3.right * Input.GetAxis("Horizontal") * 20);
        rigidbody.AddForce(Vector3.forward * Input.GetAxis("Vertical") * 20);
    }
}
