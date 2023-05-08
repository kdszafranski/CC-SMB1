using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject playerObj;

    [SerializeField]
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        Run();
    }

    void Run() {
        // start the game

        // create player prefab
        // playerObj = Instantiate()

        // set camera
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
