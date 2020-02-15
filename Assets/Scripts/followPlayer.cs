using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

	public Transform player;
	public Vector3 offset;

	void Start() {
        offset.y = 1;
        offset.z = -5;
    }

    // Update is called once per frame
    void Update() {
        transform.position = player.position + offset;
    }
}