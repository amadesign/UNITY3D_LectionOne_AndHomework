using UnityEngine;
using System.Collections;

public class DuckCamera : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        //this.offset = new Vector3(0, 80, -30);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        //transform.position = target.position - this.offset;
    }
}

