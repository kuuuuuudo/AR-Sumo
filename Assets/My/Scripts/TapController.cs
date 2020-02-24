using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetMouseButtonDown(1))
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();
            float xr = Random.Range(1.0f, 9.0f);
            float zr = Random.Range(1.0f, 9.0f);

            Debug.Log(xr);

            float x = xr / 100.0f;
            float z = zr / 100.0f;

            Debug.Log(x);

            int xm = Random.Range(0, 2);
            int zm = Random.Range(0, 2);

            if (xm == 0) { x *= -1.0f; }
            if (zm == 0) { z *= -1.0f; }

            Debug.Log(x);

            rb.AddForce(x, 0.2f, z, ForceMode.Impulse);  // 力を加える
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                // タッチ開始
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                // タッチ移動
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                Rigidbody rb = this.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * 0.3f);  // 力を加える
                Debug.Log(rb);
            }
        }
    }
}
