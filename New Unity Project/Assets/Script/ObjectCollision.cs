using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    public static ObjectCollision instance;

    public Rigidbody rb;

    private void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Finish")
        {
            Debug.Log("Camera collision");
            rb.isKinematic = true;
            SceneChange.instance.Vaction();
        }

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Camera collision");
            rb.isKinematic = true;
            SceneChange.instance.AmuzementPark();
        }
    }
}
