using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day_time : MonoBehaviour
{
    public GameObject light_sun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        light();
    }
    void light() //Change the color of light as the sun goes down
    {
        Light lightComp = light_sun.GetComponent<Light>();
        float H, S, V;
        Color.RGBToHSV(lightComp.color, out H, out S, out V);
        H -= Time.deltaTime * 0.01f; //change the factor, the factor is the time the day lasts
        lightComp.color = Color.HSVToRGB(H, S, V);
        //if (H < 235 && go to sleep)
        //    H = 63;
        //if (H < 235 && hora igual)
        //    H = 235;
    }
}
