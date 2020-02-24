using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapController : MonoBehaviour
{

    public GameObject target;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        this.target.AddComponent<Rigidbody>();
        this.rb = this.target.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("タップされました");
            // rigidbodyを取得 
            this.rb.AddForce(Random.Range(3.0f, 10.0f), 0, Random.Range(3.0f, 10.0f));
            //this.rb.AddForce(Random.Range(0.0f, 3.0f), 0, Random.Range(0.0f, 3.0f));  // 力を加える
            //rb.AddForce(Vector3.left * 0.3f, ForceMode.Impulse);
            //rb.velocity += (Vector3.left * 0.3f) / rb.mass;
            Debug.Log(rb);
        }

        if (OnTouchDown())
        {
            Debug.Log("タップされました");

        }
    }

    //スマホ向け そのオブジェクトがタッチされていたらtrue（マルチタップ対応）
    bool OnTouchDown()
    {
        // タッチされているとき
        if (0 < Input.touchCount)
        {
            // タッチされている指の数だけ処理
            for (int i = 0; i < Input.touchCount; i++)
            {
                // タッチ情報をコピー
                Touch t = Input.GetTouch(i);
                // タッチしたときかどうか
                if (t.phase == TouchPhase.Began)
                {
                    //タッチした位置からRayを飛ばす
                    Ray ray = Camera.main.ScreenPointToRay(t.position);
                    RaycastHit hit = new RaycastHit();
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Rayを飛ばしてあたったオブジェクトが自分自身だったら
                        if (hit.collider.gameObject == this.gameObject)
                        {
                            return true;
                        }
                    }
                }
            }
        }
        return false; //タッチされてなかったらfalse
    }
}
