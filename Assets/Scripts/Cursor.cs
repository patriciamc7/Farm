using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cur : MonoBehaviour
{
    public Texture2D cursorArrow;
    // Start is called before the first frame update
    void Start()
    {
        
        Cursor.visible = false;
        //Cursor.setCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

}
