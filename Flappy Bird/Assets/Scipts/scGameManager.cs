using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scGameManager : MonoBehaviour
{
    public GameObject canvas;
   
   private void Start()
   {
       Time.timeScale = 1;
   }

    public void GameOver()
    {
        canvas.SetActive(true);
        Time.timeScale = 0;

    }

    public void Restart()
    {
       SceneManager.LoadScene(0);
    }
}
