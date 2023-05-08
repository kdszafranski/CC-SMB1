using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour {

    [SerializeField]
    float moveSpeed = 5.5f;
    [SerializeField]
    bool movingRight = false;

    // Update is called once per frame
    void Update() {
        float xValue = Time.deltaTime * moveSpeed;

        if (movingRight) {
            transform.Translate(xValue, 0f, 0f);
        } else {
            // moving left (default)
            transform.Translate(-xValue, 0f, 0f);
        }

    }
}