using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidBehavour : MonoBehaviour
{
    public Vector2 velocity;
    public Rigidbody2D asteroidBody;

    void Start()
    {
        float astroidX = Random.Range(-8.11f, 8.11f);
        float astroidY = Random.Range(-4.23f, 4.23f);
        velocity.x = Random.Range(-3f, 3f);
        velocity.y = Random.Range(-3f, 3f);
        velocity = new Vector2 (velocity.x, velocity.y);
        asteroidBody = GetComponent<Rigidbody2D> ();
        transform.position = new Vector3(astroidX, astroidY, 0);

    }

    void FixedUpdate()
    {
      asteroidBody.MovePosition(asteroidBody.position + velocity * Time.fixedDeltaTime);
    }

    void SplitAsteroid()
    {

    }
}
