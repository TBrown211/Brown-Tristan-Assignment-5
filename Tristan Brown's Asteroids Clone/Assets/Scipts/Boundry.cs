using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundry : MonoBehaviour
{
    [SerializeField] public Vector3 Warp;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (!collider2D.CompareTag("asteroid"))
            return;

        Vector3 astroidHasWarped = collider2D.transform.position + Warp;
        collider2D.attachedRigidbody.MovePosition(Warp);

    }
}
