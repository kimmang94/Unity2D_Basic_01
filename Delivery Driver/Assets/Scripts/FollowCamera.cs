using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    private Transform playerPos = null;

    private float distance = -0.5f;
    private void LateUpdate()
    {
        transform.position = playerPos.position + new Vector3(0,0, distance);
    }
}
