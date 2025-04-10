using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    Coords point = new Coords(10, 20);
    Coords origin = new Coords(0, 0);

    Coords startPointY = new Coords(0, 100);
    Coords endPointY = new Coords(0, -100);

    Coords startPointX = new Coords(160, 0);
    Coords endPointX = new Coords(-160, 0);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(point.ToString());
        Coords.DrawPoint(point, 2, Color.yellow);
        Coords.DrawPoint(origin, 3, Color.white);
        Coords.DrawLine(startPointY, endPointY, 1, Color.green);
        Coords.DrawLine(startPointX, endPointX, 1, Color.red);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
