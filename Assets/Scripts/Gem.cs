using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public Texture2D cursorArrow;
    public Texture2D cursorPickaxe;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseEnter() //first frame
    {
        Cursor.SetCursor(cursorPickaxe, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void Update()
    { 
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) //miramos si el rato esta encima de algun objeto
        {
            if (Input.GetMouseButtonDown(0)) //si clicamos iz
            {
                if(hit.collider.name == "WateringCan")
                {
                    print(hit.collider.name);

                } //mas condiciones con GUI
            }
        }
    }

}
