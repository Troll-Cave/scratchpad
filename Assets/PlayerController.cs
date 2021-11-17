using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask LayerMask;
    float baseSpeed = 2f;
    public void Move(float x, float y)
    {
        baseSpeed = 2f;
        var position = this.gameObject.transform.position;
        foreach (var thing in Physics2D.OverlapCircleAll(new Vector2(position.x + x, position.y), 0.2f, LayerMask))
        {
            if (thing.gameObject != gameObject)
            {
                x = 0;
                baseSpeed = 1f;
                break;
            }
        }

        foreach (var thing in Physics2D.OverlapCircleAll(new Vector2(position.x, position.y + y), 0.2f, LayerMask))
        {
            if (thing.gameObject != gameObject)
            {
                y = 0;
                baseSpeed = 1f;
                break;
            }
        }

        position.x = position.x + x * baseSpeed;
        position.y = position.y + y * baseSpeed;

        this.gameObject.transform.position = position;
    }
}
