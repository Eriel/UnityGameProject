using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerController))]
public class Movement : MonoBehaviour {

    public LayerMask movementMask;
    Camera cam;
    PlayerController movePlayer;
   

    void Start ()
    {
        cam = Camera.main;
        movePlayer = GetComponent<PlayerController>();
        
    }

    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                
                movePlayer.MoveToPoint(hit.point);
            }
        }
    }
}