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
    public bool isPressed = false;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        myInt = 0;
        myInt = myInt + 10;
        GameObject go = Instantiate(prefab, Vector3.zero, Quaternion.identity);
        //go.GetComponent<Renderer>().material.color = Color.red;
        //go.GetComponent<Renderer>().material.color = new Color (0, 1, 0, 1);
        //go.GetComponent<Renderer>().material.color = hexToColor("#0000FF");
        go.GetComponent<Renderer>().material.color = GetRandomColor();

    }

    Color GetRandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse button is pressed");
            isPressed = true;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
                Debug.Log("Hit gameobject : " + hit.transform.gameObject.name);

        }



    }
}
    /*public Color hexToColor(string hex)
    {
        hex = hex.Replace("0x", "");//in case the string is formatted 0xFFFFFF
        hex = hex.Replace("#", "");//in case the string is formatted #FFFFFF
        byte a = 255;//assume fully visible unless specified in hex
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        //Only use alpha if the string has enough characters
        if (hex.Length == 8)
        {
            a = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
        }
        return new Color32(r, g, b, a);
    }*/

