using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class ParticleSystemone : MonoBehaviour
{
    GameObject particledGameObject;
    bool isActive;


    public void onSpray(InputAction.CallbackContext context)
    {
        Debug.Log("Spray!!");
        particledGameObject.SetActive(!isActive);
    }

    public void onSpraytwo(InputAction.CallbackContext context)
    {
        Debug.Log("Spray two!!");
    }

    public void onSpraythree(InputAction.CallbackContext context)
    {
        Debug.Log("Spray three!!");
    }
    public void onSprayfour(InputAction.CallbackContext context)
    {
        Debug.Log("Spray four!!");
    }
    public void onSprayfive(InputAction.CallbackContext context)
    {
        Debug.Log("Spray five!!");
    }
}
