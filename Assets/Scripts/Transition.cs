using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour {

    public void game1(string str)
    {
        SceneManager.LoadScene(str);
    }
}
