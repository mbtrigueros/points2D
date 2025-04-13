using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    public int size = 20;
    public int maxY = 100;
    public int maxX = 100;

    Coords startPointY;
    Coords endPointY;

    Coords startPointX;
    Coords endPointX;
    // Start is called before the first frame update
    void Start()
    {

        startPointX = new Coords(maxX, 0);
        endPointX = new Coords(-maxX, 0);

        startPointY = new Coords(0, maxY);
        endPointY = new Coords(0, -maxY);
        Coords.DrawLine(startPointX, endPointX, 1, Color.red);
        Coords.DrawLine(startPointY, endPointY, 1, Color.green);

        int xoffset = (int)(maxX / (float)size);
        for (int x = -xoffset * size; x <= xoffset * size; x += size)
        {
            Coords.DrawLine(new Coords(x, -maxY), new Coords(x, maxY), 0.5f, Color.white);
        }
        int yoffset = (int)(maxY / (float)size);
        for (int y = -yoffset * size; y <= yoffset * size; y += size)
        {
            Coords.DrawLine(new Coords(-maxX, y), new Coords(maxX, y), 0.5f, Color.white);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
