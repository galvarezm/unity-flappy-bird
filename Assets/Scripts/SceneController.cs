using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject objCanvasGameOver;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YouLost(){
        objCanvasGameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartScene(){
        SceneManager.LoadScene(0);
    }

}
