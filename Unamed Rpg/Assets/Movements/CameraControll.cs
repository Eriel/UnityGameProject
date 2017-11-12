using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour {

public GameObject player;
     
    void LateUpdate() {
        transform.LookAt(player.transform);
    }
}