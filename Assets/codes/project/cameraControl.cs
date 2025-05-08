using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    Transform playerTranform;
    void Start()
    {
        playerTranform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(playerTranform.position.x, playerTranform.position.y, transform.position.z);
    }
}
