using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveShip : MonoBehaviour
{
    new public Rigidbody2D rigidbody2D;
    public GameObject bullet;
    public float bulletForce = 10f;
    public float timeUntillBulletIsDestoryed = 20f;

    void Start()
    {
        Debug.Log(name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("asteroid"))
            return;
        ResetGame();
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

    void Update()
    {
        //Allows Player to shoot bullets
        bool shipShootBullets = Input.GetKeyDown(KeyCode.Space);
         if (shipShootBullets)
        {
            Vector3 position = transform.position + transform.up;
            GameObject newBullet = Instantiate(bullet, position, Quaternion.identity);

            Rigidbody2D rigidbody = newBullet.GetComponent<Rigidbody2D>();
            rigidbody.AddForce(transform.up * bulletForce, ForceMode2D.Impulse);

            Destroy(newBullet, timeUntillBulletIsDestoryed);
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
