using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickCreate : MonoBehaviour
{
    public GameObject O1Prefab;
    public GameObject O1locate;
    Vector3 screenPoint;
    Vector3 spawnPoint;
    private Vector3 offset;
    public int TotalObject;
    // Start is called before the first frame update
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {
        //this.InvokeRepeating("setInterval", 2.0f,1.0f);
    }
     void OnMouseDown()
    {
        //screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        //offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x , Input.mousePosition.y , screenPoint.z));
        
        //spawnPoint = O1locate.transform.position;
         spawnPoint = new Vector3(62,3,10);
        //Instantiate(O1Prefab , spawnPoint , Quaternion.identity);
        //screenPoint = Camera.main.ViewportToScreenPoint(gameObject.transform.position);
        //offset = gameObject.transform.position - Camera.main.ViewportToScreenPoint(new Vector3(Input.mousePosition.x , Input.mousePosition.y , Input.mousePosition.z));
        //Instantiate(O1Prefab,transform.position,transform.rotation);
    }
    /*void OnMouseUp()
    {
        var findObjects = FindObjectsOfType<Rigidbody>();
        if(findObjects.Length <= TotalObject)
        {
            Instantiate(O1Prefab , spawnPoint , Quaternion.identity);
        }
        
    }*/
    public void Click()
    {
         var findObjects = FindObjectsOfType<Rigidbody>();
         spawnPoint = new Vector3(Random.Range(50,70),3,Random.Range(0,10));
        if(findObjects.Length <= TotalObject)
        {
            Instantiate(O1Prefab , spawnPoint , Quaternion.identity);
        }
    }
    public void ClickClear()
    {
        var FindAllcount = FindObjectsOfType<Rigidbody>();
        var FindAll = FindObjectOfType<Rigidbody>();
        if(FindAllcount.Length > 0)
        {
            Destroy(FindAll.gameObject);
        }
    }
}
