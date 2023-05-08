using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour {

    private void OnCollisionEnter(Collision other) {
        // Debug.Log("Hit the Wall");
        if (other.gameObject.CompareTag("Player")) {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }

    }
}