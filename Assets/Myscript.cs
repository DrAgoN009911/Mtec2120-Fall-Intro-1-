using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myscript : MonoBehaviour
{

    public int myInt;
    public float myFloat;
    public string myString;
    public int myVar = 0;
    public GameObject myGameObject;

    // Start is called before the first frame update
    void Start()
    {
        myInt = 0;
        myInt = myInt + 10;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse button is pressed");
        }
    }
    }

