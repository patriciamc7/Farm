using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //Actualizamos siempre la camara a la posicion del jugador
    }

    // Update is called once per frame
    void Update() 
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float horizontalvertical = Input.GetAxisRaw("Vertical");
        //FALTA PONER LIMITES y no tener en cuenta las colisiones
        float pos = player.transform.position.x * 0.8f;
        this.transform.position = new Vector3(pos,this.transform.position.y,this.transform.position.z);
}
}
