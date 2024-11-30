using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //if (h != 0 || v != 0)
        //{
        //    Debug.Log("h: " + h + ",v: " + v);
        //}
        //Debug.Log(h);

        Vector3 dir = new Vector3(h, v, 0); //Vector3.right * h + Vector3.up * v;
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
