using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileStartPoint : MonoBehaviour
{
    [SerializeField]
    private GameObject ProjectilePrefab;

    [SerializeField]
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, transform.position, transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);
        }
    }
}

