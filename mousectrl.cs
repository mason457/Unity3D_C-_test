using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousectrl : MonoBehaviour
{
     public float moveSpeed = 1;//物體旋轉速度    
    public GameObject target;

    private Vector2 oldPosition;
    private Vector2 oldPosition1;
    private Vector2 oldPosition2;


    private float distance = 0;
    private bool flag = false;
    //攝像頭的位置  
    private float x = 0f;
    private float y = 0f;
    //左右滑動移動速度  
    public float xSpeed = 250f;
    public float ySpeed = 120f;
    //縮放限制係數  
    public float yMinLimit = -360;
    public float yMaxLimit = 360;
    //是否旋轉  
    private bool isRotate = true;
    //計數器  
    private float count = 0;

    public static mousectrl _instance;
    //初始化遊戲信息設置  
    // Start is called before the first frame update
    void Start()
    {
         _instance = this;
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
        if (GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotate)
        {

            target.transform.Rotate(Vector3.down, Time.deltaTime * moveSpeed, Space.World);

        }
        if (!isRotate)
        {
            count += Time.deltaTime;
            if (count > 5)
            {
                count = 0;
                isRotate = true;
            }
        }

        //觸摸類型爲移動觸摸  
        if (Input.GetMouseButton(0))
        {
            //根據觸摸點計算X與Y位置  
            x += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
            y -= Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;
            isRotate = false;
        }
        //判斷鼠標滑輪是否輸入  
        float temp = Input.GetAxis("Mouse ScrollWheel");
        if (temp != 0)
        {
            if (temp > 0)
            {
                // 這裏的數據是根據我項目中的模型而調節的，大家可以自己任意修改  
                if (distance > -15)
                {
                    distance -= 0.5f;
                }
            }
            if (temp < 0)
            {
                // 這裏的數據是根據我項目中的模型而調節的，大家可以自己任意修改  
                if (distance < 20)
                {
                    distance += 0.5f;
                }
            }
        }
    }

    //計算距離，判斷放大還是縮小。放大返回true，縮小返回false    
    bool IsEnlarge(Vector2 oP1, Vector2 oP2, Vector2 nP1, Vector2 nP2)
    {
        //old distance    
        float oldDistance = Mathf.Sqrt((oP1.x - oP2.x) * (oP1.x - oP2.x) + (oP1.y - oP2.y) * (oP1.y - oP2.y));
        //new distance    
        float newDistance = Mathf.Sqrt((nP1.x - nP2.x) * (nP1.x - nP2.x) + (nP1.y - nP2.y) * (nP1.y - nP2.y));

        if (oldDistance < newDistance)
        {
            //zoom+    
            return true;
        }
        else
        {
            //zoom-    
            return false;
        }
    }

    //每幀執行，在Update後    
    void LateUpdate()
    {
        if (target)
        {
            //重置攝像機的位置  
            y = ClampAngle(y, yMinLimit, yMaxLimit);
            var rotation = Quaternion.Euler(y, x, 0);
            var position = rotation * (new Vector3(0.0f, 0.0f, -distance)) + target.transform.position;

            transform.rotation = rotation;
            transform.position = position;
        }
    }
    float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);

    }
}
