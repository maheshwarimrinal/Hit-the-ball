using UnityEngine;

public class Flying: MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    //transform
    Transform myTrans;
    //object position
    Vector3 myPos;
    //object rotation
    Vector3 myRot;
    //object rotation 
    float angle;

    // Use this for initialization
    void Start()
    {
        myTrans = transform;
        myPos = myTrans.position;
        myRot = myTrans.rotation.eulerAngles;

        myPos.x += Mathf.Cos(angle) * Time.deltaTime;
        myPos.y += Mathf.Sin(angle) * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        myPos.x += Mathf.Cos(angle) * Time.deltaTime * 3;
        myPos.y += Mathf.Sin(angle) * Time.deltaTime;

        //Apply
        myTrans.position = myPos;
        myTrans.rotation = Quaternion.Euler(myRot);
    }
}