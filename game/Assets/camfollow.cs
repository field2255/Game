using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    public Transform player;
    public Vector3 cam;
    void Update()
    {
        transform.position = player.position + cam;
    }
}
