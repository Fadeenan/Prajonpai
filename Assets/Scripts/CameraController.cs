using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float smooth;
    public Vector3 op;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position,player.position + op,smooth * Time.deltaTime);
    }
}
