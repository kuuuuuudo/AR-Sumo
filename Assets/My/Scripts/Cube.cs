using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject target;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        this.target.AddComponent<Rigidbody>();
        this.rb = this.target.GetComponent<Rigidbody>();
        this.rb.AddForce(-13, 0, -5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
