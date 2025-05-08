using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D sp = GetComponent<Rigidbody2D>();
        Transform tt = transform;
        this.gameObject.AddComponent<BoxCollider2D>();
        Component[] t = this.gameObject.GetComponents<Component>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}