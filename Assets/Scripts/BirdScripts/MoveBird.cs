using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBird : MonoBehaviour
{
    [SerializeField] float forceJump;
    [SerializeField] Rigidbody2D rigidbody;

    public void Jump()
    {
        rigidbody.velocity = Vector2.up * forceJump;
    }
}