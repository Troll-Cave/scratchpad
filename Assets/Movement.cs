using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float xMove = 0;
    float yMove = 0;

    public float rotationSpeed = 9f;

    private PlayerController playerController;
    private Quaternion rotation = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal") * 2.5f;
        yMove = Input.GetAxisRaw("Vertical") * 2.5f;

        var mousePosition = Input.mousePosition;

        var newPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        var swordPosition = transform.position;

        var diff = newPosition - swordPosition;

        var angle = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        
        rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        playerController.Move(xMove * Time.deltaTime, yMove * Time.deltaTime);
    }
}
