using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
  
    }


    //リジットボディ必要
    void OnTriggerEnter(Collider other)
    {
            //タグ名変更必要あり
        if (other.gameObject.tag == "Finish")
        {

            //ヒット時の処理


            Debug.Log("Hit" + other.gameObject.name);
        }
    }
}
