using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LayerMask LayerMask;
    public void Move(float x, float y)
    {
        var position = this.gameObject.transform.position;
        foreach (var thing in Physics2D.OverlapCircleAll(new Vector2(position.x + x, position.y + y), 1f, LayerMask))
        {
            if (thing.gameObject != gameObject)
            {
                Debug.Log(thing);
                return;
            }
        }

        position.x = position.x + x;
        position.y = position.y + y;

        this.gameObject.transform.position = position;
    }
}
