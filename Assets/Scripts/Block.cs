using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    [SerializeField]
    bool canBeBroken = false;
    [SerializeField]
    bool isMysteryBlock = false;
    [SerializeField]
    bool hasBeenHit = false;
    [SerializeField]
    List<Material> materials;

    public bool CanBeBroken { get => canBeBroken; set => canBeBroken = value; }
    public bool IsMysteryBlock { get => isMysteryBlock; set => isMysteryBlock = value; }

    public void HitBlock() {
        if (hasBeenHit == false) {
            hasBeenHit = true;

            // color changes once hit to show deactivated
            if (isMysteryBlock) {
                GetComponentInChildren<MeshRenderer>().material = materials[1];
            }

            // bonk it
            iTween.PunchPosition(gameObject, new Vector3(0, .5f, 0), .5f);
        }

    }
}