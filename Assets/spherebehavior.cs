// 'using' is a keyword for importing library from namespace
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherebehavior : MonoBehaviour
{

    public float valueA = 10.5f;
    public float valueB = 11.0f;
    public string name = "John";
    public int i = 0;
    public float speed = 10.0f;
    public char testChar = 'a';
    public bool testBool = false;
    public bool isCSharpFun = true;

    public GameObject myfirstobject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + name);
        Debug.Log("The smaller value is : " + Mathf.Min(valueA, valueB));
        Debug.Log("The larger value is : " + Mathf.Max(valueA, valueB));
        Debug.Log(Mathf.Max(5, 10));
        Debug.Log(Mathf.Min(5, 10));
        Debug.Log(Mathf.Sqrt(64));

        if(isCSharpFun)
        {
            Debug.Log("C# is fun!!!");
        }
        if (name == "John")
        {
            Debug.Log("Yes, my name is John");
        }

        for (int i =0; i < 10; i++)
        {
            Debug.Log("Value is: " + i);
        }

        Debug.Log("The game object is " + myfirstobject.name);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("You pressed the left mouse button.");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("You pressed the A key");
        }
    }
}
