using UnityEngine;
using System.Collections;

public class babyDuck2 : MotherDuck
{

    public Transform babyDuck1;
    public float duckTwospeed;

    Transform babyDuckTwo;

    void Start()
    {
        babyDuckTwo = GetComponent<Transform>();
    }

    void Update()
    {

        transform.LookAt(babyDuck1);
        if (Vector3.Distance(babyDuck1.position, babyDuckTwo.position) > 0.5f)
        {
            babyDuckTwo.Translate(Vector3.forward * moveSpeed * duckTwospeed);
        }

    }
}
