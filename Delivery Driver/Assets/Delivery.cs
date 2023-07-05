using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 1;
    bool hasPackage; //default:false
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Bump!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
      
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
        }
        
    }

}
