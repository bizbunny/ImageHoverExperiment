using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ImageChange : MonoBehaviour
{
    public GameObject img;
    public GameObject Irin;
    public bool clickStart = false;
    // Start is called before the first frame update
    void Start()
    {
        if(clickStart == false){
            Irin.SetActive(false);
            img.SetActive(true);
        }
        else{
            //clickStart = false;
            Irin.SetActive(true);
            img.SetActive(false);
        }
    }
    public void goToNextScreen(){
        clickStart = true;
        SceneManager.LoadScene("TestScene");
    }
    // Update is called once per frame
    public void MouseOver()
    {
        Irin.SetActive(true);
        img.SetActive(false);
        Debug.Log("Mouse is over");
    }
    public void MouseExit()
    {
        Irin.SetActive(false);
        img.SetActive(true);
        Debug.Log("Mouse Exit");
    }
}
