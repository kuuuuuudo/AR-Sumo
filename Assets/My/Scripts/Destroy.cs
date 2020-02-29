using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public GameObject player,enemy,dyou,playerpa,enemypa,titleBtn,reBtn;
    private bool playerFlag = false;
    private bool enemyFlag = false;
    public Text text;

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
        if (other.gameObject.tag == "Player" && !playerFlag)
        {
            Instantiate(playerpa, other.gameObject.transform.position,Quaternion.identity);
            playerFlag = true;
            text.text = "敗北";
        }
        else if(other.gameObject.tag == "Enemy" && !enemyFlag) {
            Instantiate(enemypa, other.gameObject.transform.position, Quaternion.identity);
            enemyFlag = true;
            text.text = "勝利";
        }
        Destroy(other.gameObject);
        player.transform.GetComponent<Rigidbody>().isKinematic = true;
        enemy.transform.GetComponent<Rigidbody>().isKinematic = true;
        dyou.transform.GetComponent<Rigidbody>().isKinematic = true;
        titleBtn.SetActive(true);
        reBtn.SetActive(true);
    }
}
