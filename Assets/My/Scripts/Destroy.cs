using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject playerpa;
    public GameObject enemypa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject);
        if (gameObject.name == "player")
        {
            Instantiate(playerpa, gameObject.transform);
        }
        else {
            Instantiate(enemypa, gameObject.transform);
        }
        Destroy(gameObject);
    }
}
