using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMovementAttachments : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform obj in transform)
        {
            obj.gameObject.AddComponent<Movement>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
