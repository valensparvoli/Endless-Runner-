using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoRoad : MonoBehaviour
{

    public float Jumpv = 5f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {

        transform.position = transform.position + new Vector3(0, 0, -Jumpv * Time.deltaTime);

    }



}
