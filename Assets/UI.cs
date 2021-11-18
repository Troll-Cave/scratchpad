using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    private ProgressBar healthBar;
    private ProgressBar manaBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<UIDocument>().rootVisualElement.Query<ProgressBar>("Health").First();
        manaBar = GetComponent<UIDocument>().rootVisualElement.Query<ProgressBar>("Mana").First();

        healthBar.value = 100;
        manaBar.value = 100;

        healthBar.title = $"{healthBar.value}/100";
        manaBar.title = $"{manaBar.value}/100";

        GetComponent<UIDocument>().rootVisualElement.Query<Button>("Clicker").First().clicked += () => UpdateHealth();
    }

    // The really nice thing is that this doesn't run inside the update loop
    void UpdateHealth()
    {
        healthBar.value -= Random.Range(5, 10);

        healthBar.title = $"{healthBar.value}/100";
        manaBar.title = $"{manaBar.value}/100";

        manaBar.value -= Random.Range(5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
