using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UIDocument>().rootVisualElement.Query<Button>("Clicker").First().clicked += () => UpdateHealth();
    }

    void UpdateHealth()
    {
        GetComponent<UIDocument>().rootVisualElement.Query<ProgressBar>().First().value += 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
