using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float xMove = 0;
    float yMove = 0;

    private PlayerController playerController;

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
    }

    private void FixedUpdate()
    {
        playerController.Move(xMove * Time.deltaTime, yMove * Time.deltaTime);
    }
}
