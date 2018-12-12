using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitAndRetry : MonoBehaviour {

    public Text txt = null;

    private void Start()
    {
        txt.text = "Final score is : "+staticx.score.ToString();
    }

    public void gameQuit(){
        Application.Quit();
    }

    public void retry(){
        SceneManager.LoadScene("StartScene");
    }
}
