using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidBehavour : MonoBehaviour
{
    public float force = 3f;
    public Rigidbody2D asteroidBody;
    private int asteroidSplitCount = 0;

    void Start() //Gives the asteroid a random  postion on screen and then "pushes" it into a random direction.
    {
        float astroidX = Random.Range(-8.11f, 8.11f);
        float astroidY = Random.Range(-4.23f, 4.23f);
        asteroidBody = GetComponent<Rigidbody2D>();
        Vector3 giveAsteroidForce = Random.onUnitSphere * force;
        asteroidBody.AddForce(giveAsteroidForce, ForceMode2D.Impulse);
        transform.position = new Vector3(astroidX, astroidY, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SplitAsteroid();
    }

    void SplitAsteroid()
    {
        int maxAsteroidSplitCount = 3;

        if (asteroidSplitCount < maxAsteroidSplitCount)
        {
            GameObject split1 = Instantiate(gameObject);
            GameObject split2 = Instantiate(gameObject);
            split1.transform.localScale = split1.transform.localScale / 2;
            split2.transform.localScale = split2.transform.localScale / 2;
            AstroidBehavour astroid1 = split1.GetComponent<AstroidBehavour>();
            astroid1.asteroidSplitCount++;
            AstroidBehavour astroid2 = split1.GetComponent<AstroidBehavour>();
            astroid2.asteroidSplitCount++;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        //Destroy(gameObject); 

        
        
        //split1.transform.position = transform.position;


    }
}
