using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject playerPrefab;
    public GameObject playerObj;
    public CinemachineVirtualCamera vCamera;

    [SerializeField]
    Vector3 startPosition;

    Vector3 camStartPosition;

    // Start is called before the first frame update
    void Start() {
        camStartPosition = vCamera.transform.position;
        Run();
    }

    void Run() {
        // start the game

        // create player prefab
        playerObj = GameObject.Instantiate(playerPrefab, startPosition, Quaternion.identity);

        // set camera
        if (vCamera != null) {
            vCamera.m_LookAt = playerObj.transform;
            vCamera.m_Follow = playerObj.transform;
        }
    }

    public void OnDeath() {
        vCamera.m_LookAt = null;
        vCamera.m_Follow = null;

        Destroy(playerObj);

        vCamera.transform.position = camStartPosition;

        Run();
    }

}