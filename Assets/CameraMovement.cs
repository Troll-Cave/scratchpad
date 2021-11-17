using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    public float cameraMoveSpeed = 3f;

    private PlayerInput input;
    private void Awake()
    {
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (input.actions["MoveCamera"].IsPressed())
        {
            gameObject.GetComponent<Camera>().transform.Translate(input.actions["MouseMove"].ReadValue<Vector2>() * Time.deltaTime * cameraMoveSpeed, Space.World);
        }*/
    }
}
