using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    [SerializeField]
    float moveSpeed = 7.5f;
    [SerializeField]
    bool isAlive = true;
    [SerializeField]
    string myName = "Benjamin";

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0f, zValue);
    }
}