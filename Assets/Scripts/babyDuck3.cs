using UnityEngine;
using System.Collections;

public class babyDuck3 : MotherDuck
{

    public Transform babyDuckTwo;
    public float duckThreespeed;

    Transform babyDuckThree;

    void Start()
    {
        babyDuckThree = GetComponent<Transform>();
    }

    void Update()
    {

        transform.LookAt(babyDuckTwo);
        if (Vector3.Distance(babyDuckTwo.position, babyDuckThree.position) > 0.5f)
        {
            babyDuckThree.Translate(Vector3.forward * moveSpeed * duckThreespeed);
        }

    }
}
