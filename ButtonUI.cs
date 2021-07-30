using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //引用場景管理功能


public class ButtonUI : MonoBehaviour
{
  public GameObject Obj;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickExit()
    {
        Application.Quit();
    }

     public void ClickEnd1()
    {
        SceneManager.LoadScene("JB");
        Time.timeScale = 1;
    }

    public void ClickRestart1()
    {
        SceneManager.LoadScene("JB");
        Time.timeScale = 1;
    }
    public void ClickStart()
    {
        Obj.SetActive(false);
        Time.timeScale = 1;
    }
     
}
