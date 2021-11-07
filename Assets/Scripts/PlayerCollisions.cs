using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag != "floor")
       {
            Vector3 push_away = Vector3.Normalize(this.transform.position) * 0.5f;
            //Debug.Log(push_away.ToString() + "push");
            //no acabado

            if (push_away.x > 0 || push_away.z>0)
                push_away *= 1;
            else
                push_away *= -1;

            this.transform.position = this.transform.position + push_away; //move to previous pos but a little bit further
            //movement.enabled = false;
        }
    }
}
