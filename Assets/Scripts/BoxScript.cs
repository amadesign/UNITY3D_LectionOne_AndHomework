using UnityEngine;
using System.Collections;

public class BoxScript : MonoBehaviour {

    public float moveSpeed;
    bool isMoving;
    public Transform cubeFollower;
  
	// Use this for initialization
	void Start () 
    {
        moveSpeed = 17f; 
	
	}
    void Awake()
    {
        Debug.Log("Awake");
    }
	
	// Update is called once per frame
	void Update () 
    {


        transform.Translate(moveSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0f,moveSpeed* Input.GetAxis("Vertical") * Time.deltaTime);

    
	
	}
}
