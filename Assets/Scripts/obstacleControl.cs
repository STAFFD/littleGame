using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleControl : MonoBehaviour {
    // Start is called before the first frame update

    Vector3 moveVect;
    public Transform transform;
    public MeshRenderer meshRenderer;

    void Start() {
        moveVect = transform.position;
        moveVect.z += 10f;
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetKey("q")) {
            
            transform.position = moveVect;
        }
    }

}