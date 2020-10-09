using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rltaciondelcubito : MonoBehaviour
{
    void Update()             //キューブ回転
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}