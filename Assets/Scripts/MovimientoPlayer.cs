using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MovimientoPlayer : MonoBehaviour
{
    [Range(5, 13)] public float value;
    public float Speed;
    Rigidbody rigid;
    
    public SpawnManager spawnManager;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
       
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(value, transform.position.y, transform.position.z);
        rigid.velocity = (Vector3.forward * Time.deltaTime * Speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();

    }

    void LateUpdate()
    {
        if (Input.GetButtonDown("Right"))
        {
            if (value == 4)
                return;
            value += 4;
        }
        if (Input.GetButtonDown("Left"))
        {
            if (value == -4)
                return;
            value -= 4;
        }
    }

}
