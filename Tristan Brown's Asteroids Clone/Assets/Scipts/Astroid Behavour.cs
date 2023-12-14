using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidBehavour : MonoBehaviour
{
    public float force = 3f;
    public Rigidbody2D asteroidBody;

    void Start() //Gives the asteroid a random  postion on screen and then "pushes" it into a random direction.
    {
        float astroidX = Random.Range(-8.11f, 8.11f);
        float astroidY = Random.Range(-4.23f, 4.23f);
        asteroidBody = GetComponent<Rigidbody2D>();
        Vector3 giveAsteroidForce = Random.onUnitSphere * force;
        asteroidBody.AddForce(giveAsteroidForce, ForceMode2D.Impulse);
        transform.position = new Vector3(astroidX, astroidY, 0);
    }

    void FixedUpdate()
    {

    }

    void SplitAsteroid()
    {

    }
}
