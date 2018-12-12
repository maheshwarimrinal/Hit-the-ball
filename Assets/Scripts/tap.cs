using UnityEngine;
using UnityEngine.SceneManagement;

public class tap : MonoBehaviour {

    GameObject go;
    GameObject plank;
    public Animator ani;
    string ba="/Balls/ball 1", bb="/Balls/ball 2", bc="/Balls/ball 3";
    string cor;
    string plankName;
	// Use this for initialization

	void Start () {

        //Debug.Log(staticx.ans);

        if (staticx.ans == "a")
        {
            cor = ba;
            plankName = "plank one";
        }
        else if (staticx.ans == "b")
        {
            cor = bb;
            plankName = "plank two";
        }
        else if(staticx.ans == "c")
        {
            cor = bc;
            plankName = "plank three";
        }else{
            Debug.Log("pring");
        }

        go = GameObject.Find(cor);
        plank = GameObject.FindWithTag(plankName);

        //Debug.Log(go);
        //Debug.Log(plankName);
	}

    private void OnMouseDown(){
        if(this.gameObject!=go){
            ani.SetBool("isDestroyed", true);
            //SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            Destroy(this.gameObject, 0.7f);
            Invoke("next", .5f);
            Debug.Log(this.gameObject);
        }
        else
        {
            Destroy(plank, 0.7f);
            //Debug.Log(plank);
            staticx.score = staticx.score + 1;
            staticx.value++;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //GameObject go1 = GameObject.Find(b);
            //GameObject go2 = GameObject.Find(c);
            //Destroy(go1, 0.7f);
            //Destroy(go2, 0.7f);
        }

    }

    private void next(){
        SceneManager.LoadScene("lost");
        Debug.Log("NOW");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "IceSprite"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
