using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public Light light;
    public List<Color> colors = new List<Color>();
    public int kichard = 0;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        colors.Add(Color.red);
        colors.Add(Color.green);
        colors.Add(Color.blue);
        colors.Add(Color.white);
        colors.Add(Color.magenta);
        colors.Add(Color.yellow);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            light.color = colors[kichard];//insert color here
            kichard++;
            if(kichard == 6)
            {
                kichard = 0;
            }
        }
    }
}
