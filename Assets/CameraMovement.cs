using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    public float cameraMoveSpeed = 3f;
    public GameObject player;

    private PlayerInput input;
    private void Awake()
    {
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        var newPos = player.transform.position;
        //newPos.x = Mathf.Clamp(newPos.x, -1, 1);
        //newPos.y = Mathf.Clamp(newPos.y, -1, 1);

        newPos.z = -1.5f;

        transform.position = newPos;
    }
}
