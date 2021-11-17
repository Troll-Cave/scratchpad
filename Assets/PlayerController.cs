using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask LayerMask;
    public float baseSpeed = 40f;
    private Vector3 m_Velocity = Vector3.zero;

    public void Move(Vector2 targetVector, bool running)
    {
        var rigidBody = GetComponent<Rigidbody2D>();

        Vector3 targetVelocity = targetVector * baseSpeed * (running ? 2 : 1);
        // This is mostly for kicking up the speed quickly. Otherwise it will take a hot minute and be garbage.
        // It also handles stopping since it moves from a current state to a target state.
        rigidBody.velocity = Vector3.SmoothDamp(rigidBody.velocity, targetVelocity, ref m_Velocity, 0.05f);
    }
}
