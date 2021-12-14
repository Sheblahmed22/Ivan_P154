using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayWork : MonoBehaviour
{
    public int[] numbers;
    public string[] names;
    public GameObject[] objects;
    public Color[] colors;

    // create arrays type of: int, string, gameobject, color with the array size of 3
    // Start is called before the first frame update
    void Start()
    {
        // print variables: int with index 2, string with index 0 in Start()
        print(numbers[2]);
        print(names[0]);

        // assign gameobject with index 1 by the color with index 2 in Start()
        objects[1].GetComponent<Renderer>().material.color = colors[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
