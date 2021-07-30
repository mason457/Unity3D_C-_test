using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float timelimit;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timelimit); // 幾秒後⾃我銷毀
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
