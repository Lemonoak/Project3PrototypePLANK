using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class GetPushed : MonoBehaviour
{

    public Rigidbody rb;
    public float force = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void AddForce(Vector3 direction)
    {
        rb.AddForce(new Vector3(direction.x * force, 10, direction.y * force), ForceMode.Impulse);
    }

}
