using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CronometroPuntaje: MonoBehaviour
{
    public Text UIText;
    public float time = 00;

    void Start()
    {

    }

    void Update()
    {
        time += Time.deltaTime;

        UIText.text = "Score:" + time.ToString("f0");
    }
}
