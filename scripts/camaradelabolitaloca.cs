using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaradelabolitaloca : MonoBehaviour
{

    public GameObject bolitaloca;
    private Vector3 offset;
    void Start()    //カメラ設定
    {
        offset = transform.position - bolitaloca.transform.position;

    }

    void LateUpdate()
    {
        transform.position = bolitaloca.transform.position + offset;
    }
}
