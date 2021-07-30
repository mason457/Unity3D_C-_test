using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClickMove : MonoBehaviour
{
    public GameObject O1Prefab;
    public Text Ms_text;
    private Vector3 screenPoint;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = (int)Input.mousePosition.x;
        float mouseY = (int)Input.mousePosition.y;
        float mouseZ = (int) screenPoint.z;
        Ms_text.text = "("+ mouseX + "," + mouseY + "," + mouseZ + ")";
    }
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x , Input.mousePosition.y , screenPoint.z));
        //screenPoint = Camera.main.ViewportToScreenPoint(gameObject.transform.position);
        //offset = gameObject.transform.position - Camera.main.ViewportToScreenPoint(new Vector3(Input.mousePosition.x , Input.mousePosition.y , Input.mousePosition.z));
        //Instantiate(O1Prefab,transform.position,transform.rotation);
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x , Input.mousePosition.y , screenPoint.z);
        Vector3 curPoision = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
       // Vector3 curPoision = Camera.main.ViewportToScreenPoint(curScreenPoint) + offset;
        transform.position = curPoision;
    }
}
