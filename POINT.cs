using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class POINT : MonoBehaviour
{
    int m_timer;
    public Text M_value;
    public Text Time_value;
    public int SA; 
    float STime;
    int point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        STime += Time.deltaTime;
        point = (int)STime * SA;
        M_value.text = string.Format("分數:{0}",point.ToString(""));
        Time_value.text = string.Format("時間:{0}",STime.ToString(""));
        //M_value.text = SA;
    }
}
