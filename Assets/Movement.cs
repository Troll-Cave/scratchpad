using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    Vector2 movement;

    public float rotationSpeed = 9f;

    private PlayerController playerController;
    private Quaternion rotation = Quaternion.identity;

    private bool running = false;

    private PlayerInput input;

    private void Awake()
    {
        input = GetComponent<PlayerInput>();
        input.actions["Run"].performed += ctx => running = ctx.ReadValueAsButton();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = input.actions["Movement"].ReadValue<Vector2>();
        var mousePosition = input.actions["Look"].ReadValue<Vector2>();

        var newPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        var swordPosition = transform.position;

        var diff = newPosition - swordPosition;

        var angle = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

        rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

        //running = Input.GetKey(KeyCode.LeftShift);
    }

    private void FixedUpdate()
    {
        playerController.Move(movement * Time.deltaTime * 5, running);
    }
}
