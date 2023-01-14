using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour {
    [SerializeField]
    float timeToWait = 3.0f;
    MeshRenderer renderer;
    Rigidbody rb;

    void Start() {
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update() {
        Debug.Log(Time.time);
        if (Time.time > timeToWait) {
            Drop();
        }
    }

    void Drop() {
        renderer.enabled = true;
        rb.useGravity = true;
    }
}