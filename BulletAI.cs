using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAI : MonoBehaviour
{
     public int speed ;  //移動速度
    public static int speedToual = 0;  //移動速度
    public float Speedinterval;               //速度增加產生的間隔時間
    public int SpeedRange;               //速度增加量
    private static float dtimespeed = 0;   //時間累計變數 速度
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((-speed+Random.Range(-SpeedRange , speed-1)) * Time.deltaTime, 0 , 0);  //位置移動處理
    }
}
