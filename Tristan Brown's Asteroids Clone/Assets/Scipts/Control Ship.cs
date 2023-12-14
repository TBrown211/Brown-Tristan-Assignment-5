using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public GameObject bullet;
    public float bulletForce = 10f;
    public float timeUntillBulletIsDestoryed = 20f;

    void Start()
    {
        Debug.Log(name);
    }

    void FixedUpdate()
    {
        // Get the players input for controling the ship
        bool thrustShipForward = Input.GetKey(KeyCode.W);
        bool turnShipLeft = Input.GetKey(KeyCode.A); //CCW
        bool turnShipRight = Input.GetKey(KeyCode.D); //CW
        float shipRotation = 0;


        if (thrustShipForward) 
            transform.position += transform.up *3f * Time.deltaTime;

        if (turnShipLeft) 
            shipRotation += 90 * Time.deltaTime;

        if(turnShipRight)
            shipRotation -= 90 * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0,0, transform.rotation.eulerAngles.z + shipRotation);
    }

    private void Update()
    {
        bool shipShootBullets = Input.GetKeyDown(KeyCode.Space);
         if (shipShootBullets)
        {
            Vector3 position = transform.position + transform.up;
            GameObject newBullet = Instantiate(bullet, position, Quaternion.identity);
        }
    }
}
