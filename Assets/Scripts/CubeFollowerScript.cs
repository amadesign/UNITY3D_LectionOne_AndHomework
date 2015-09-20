using UnityEngine;
using System.Collections;

public class CubeFollowerScript : MonoBehaviour {

    public float moveSpeed;
    public Transform cube;

	// Use this for initialization
	void Start () 
    {
        moveSpeed = 1f;
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.LookAt(cube);
        Quaternion rotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, 0f, 0f);
        transform.localRotation = rotation;

        Debug.Log(Input.touchCount);
	
	}
}
