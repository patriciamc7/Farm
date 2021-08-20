using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    public Player movement;
    
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag != "floor")
       {
            Vector3 push_away = transform.position;
            Debug.Log(push_away.ToString() + "push");
            transform.position = push_away;
            //movement.enabled = false;
       }
    }
}
