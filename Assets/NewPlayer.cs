using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
public class NewPlayer : MonoBehaviour
{
    public GameObject bullet;
    float projectileForce = 100f;

    public void onFire(InputAction.CallbackContext context)

    {
        Debug.Log("Fire!!!");
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        GameObject go = Instantiate(bullet);
        go.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward);
    }
}
