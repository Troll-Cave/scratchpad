using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        var position = this.gameObject.transform.position;
        
        var xright = Input.GetKey(KeyCode.RightArrow) ? 1 : 0;
        var xleft = Input.GetKey(KeyCode.LeftArrow) ? 1 : 0;

        var xup = Input.GetKey(KeyCode.UpArrow) ? 1 : 0;
        var xdown = Input.GetKey(KeyCode.DownArrow) ? 1 : 0;

        position.x = position.x + ((2f * Time.deltaTime) * (xright - xleft));
        position.y = position.y + ((2f * Time.deltaTime) * (xup - xdown));

        this.gameObject.transform.position = position;
    }
}
