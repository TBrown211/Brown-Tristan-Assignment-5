using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidBehavour : MonoBehaviour
{
    void Start()
    {
        float astroidX = Random.Range(-8.11f, 8.11f);
        float astroidY = Random.Range(-4.23f, 4.23f);
        transform.position = new Vector3(astroidX, astroidY, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            SplitAsteroid();
    }

    void SplitAsteroid()
    {

    }
}
