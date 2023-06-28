using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bump!");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered!");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Left!");
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("hehe");
    }
}
