using UnityEngine;

public class DestroyObject : MonoBehaviour {

    public GameObject other;
    public GameObject hello;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Space))
            Destroy(other); 
	}
}
