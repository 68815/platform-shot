using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Transform playerTransform;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        GameObject.Destroy(this.gameObject, 3f);
        //this.GetComponent<Transform>().position = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(8f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
