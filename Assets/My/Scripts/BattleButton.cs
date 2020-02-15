using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleButton : MonoBehaviour
{

    public GameObject player,enemy;
    Rigidbody playerRb,enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = player.transform.GetComponent<Rigidbody>();
        enemyRb = enemy.transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        playerRb.isKinematic = false;
        enemyRb.isKinematic = false;
    }

}
