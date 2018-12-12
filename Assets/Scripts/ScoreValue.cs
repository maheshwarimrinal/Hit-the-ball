using UnityEngine;
using UnityEngine.UI;

public class ScoreValue : MonoBehaviour {
    int count = 0;
    public Text myText = null;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        myText.text = "Score : "+staticx.score;
	}

    private void OnTriggerEnter2D(Collider2D other){
        
        count++;

        Debug.Log("Trigger time "+count);

        myText.text = "Score : " + count;
    }
}
