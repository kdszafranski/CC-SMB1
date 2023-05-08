using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    [SerializeField]
    float moveSpeed = 7.5f;
    [SerializeField]
    float runSpeed = 7.5f;
    [SerializeField]
    bool isAlive = true;
    [SerializeField]
    float jumpPower = 5f;
    [SerializeField]
    string myName = "Mario";
    [SerializeField]
    bool isJumping = false;

    // Update is called once per frame
    void Update() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            // running
            xValue = Input.GetAxis("Horizontal") * Time.deltaTime * runSpeed;
        }

        transform.Translate(xValue, 0f, 0f);

        if (Input.GetButtonDown("Jump") && isJumping == false) {
            // jump
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null) {
                rb.AddForceAtPosition(new Vector3(0, jumpPower, 0), transform.position, ForceMode.Impulse);
                isJumping = true;
            }
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Platform")) {
            // ground, bricks, etc.
            Vector3 point = other.GetContact(0).point;

            // if below me, reset jumping
            if (point.y < transform.position.y) {
                // reset jumping
                isJumping = false;
            }

        }
    }
}