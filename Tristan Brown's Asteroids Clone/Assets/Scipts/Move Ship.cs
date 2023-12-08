using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{

    void Start()
    {
        Debug.Log(name);
    }


    void Update()
    {
        // Get the players input for controling the ship
        bool thrustShipForward = Input.GetKey(KeyCode.W);
        bool turnShipLeft = Input.GetKey(KeyCode.A); //CCW
        bool turnShipRight = Input.GetKey(KeyCode.D); //CW
        bool shipShootBullets = Input.GetKeyDown(KeyCode.Space);

        float shipRotation = 0;


        if (thrustShipForward) 
            transform.position += transform.up *3f * Time.deltaTime;

        if (turnShipLeft) 
            shipRotation += 90 * Time.deltaTime;

        if(turnShipRight)
            shipRotation -= 90 * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0,0, transform.rotation.eulerAngles.z + shipRotation);
    }
}
