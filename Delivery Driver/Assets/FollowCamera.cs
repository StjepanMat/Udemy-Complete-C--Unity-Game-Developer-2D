using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject ThingToFollow;
    //this things position (camera) should be the same a s the car's position

    void LateUpdate()
    {
        transform.position = ThingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
