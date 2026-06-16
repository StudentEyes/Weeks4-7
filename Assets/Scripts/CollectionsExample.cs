using System.Collections.Generic;
using UnityEngine;

public class CollectionsExample : MonoBehaviour
{

    public List<string> animals;
    public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 1;
        float decimalNumber = 1.2f;
        string word = "cow";

        Vector3 position = new Vector3(1f, 0f, 0f);
        Color greyColour = new Color(0.5f, 0.5f, 0.5f, 1f);
        spriteRenderer.color = greyColour;


        animals = new List<string>();
        animals.Add("Raccoon");
        animals.Remove("Dog");

        for (int i = 0; i < animals.Count; i++)
        {
            Debug.Log(animals[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
