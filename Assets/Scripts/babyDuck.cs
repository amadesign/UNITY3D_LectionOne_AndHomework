using UnityEngine;
using System.Collections;

public class babyDuck : MotherDuck
{

    public Transform MotherDuck;
    public float duckOnespeed;

    Transform babyDuck1;

    void Start()
    {
        babyDuck1 = GetComponent<Transform>();
    }

    void Update()
    {
        
        transform.LookAt(MotherDuck);
        if (Vector3.Distance(MotherDuck.position,babyDuck1.position)>0.3f)
        {
            babyDuck1.Translate(Vector3.forward * moveSpeed * duckOnespeed);
        }
        
    }
}
