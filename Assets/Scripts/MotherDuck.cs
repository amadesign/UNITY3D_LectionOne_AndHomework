using UnityEngine;
using System.Collections;

public class MotherDuck : MonoBehaviour
{

    public static float moveSpeed = 0.01f;
    public float turnSpeed;
    Rigidbody DuckM;

    void Start()
    {
        DuckM = GetComponent<Rigidbody>();
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(-new Vector3(0f, turnSpeed * Time.deltaTime, 0f));

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(new Vector3(0f,  turnSpeed * Time.deltaTime,0f));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform current = transform;

            DuckM.AddForce(Vector3.up * 3f,ForceMode.Impulse); 
            //transform.Translate(transform.position.x,Mathf.Lerp(transform.position.y, current.position.y,Time.time),transform.position.z);
              
        }




        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);

    
        
    }
}


        
        
    
