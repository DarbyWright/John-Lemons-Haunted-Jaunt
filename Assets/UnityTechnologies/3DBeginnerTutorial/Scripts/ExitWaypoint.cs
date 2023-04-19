using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitWaypoint : MonoBehaviour
{
    public Image img;
    public Transform target;

    private void Update()
    {
        float minX = (img.GetPixelAdjustedRect().width / 2);
        float maxX = Screen.width - minX + 10f;

        float minY = img.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.height - minY;

        Vector2 pos = Camera.main.WorldToScreenPoint(target.position);
        // img.transform.position = Camera.main.WorldToScreenPoint(target.position);

        // if (Vector3.Dot((target.position - transform.position), transform.forward) < 0)
        // {
        //     //Target is behind player
        //     if (pos.x < Screen.width / 2)
        //     {
        //         pos.x = maxX;
        //     }
        //     else
        //     {
        //         pos.x = minX;
        //     }
        // }

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        img.transform.position = pos;
    }
}
