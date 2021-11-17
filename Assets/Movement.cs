using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float xMove = 0;
    float yMove = 0;

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

        var angle = Mathf.Atan2(diff.x, diff.y) * Mathf.Rad2Deg;

        //transform.forward = diff;
        
        rotation = Quaternion.AngleAxis(-angle, Vector3.forward);
    }

    private void FixedUpdate()
    {
        playerController.Move(xMove * Time.deltaTime, yMove * Time.deltaTime);
        //transform.Rotate(new Vector3(0, 0, 50));
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, .2f);
    }
}
