using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float time;
    public float counter;

    void Start()
    {

    }


    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= time + 1)
        {
            time += 1;
            print("time" + ' ' + time);
        }
    }
}
