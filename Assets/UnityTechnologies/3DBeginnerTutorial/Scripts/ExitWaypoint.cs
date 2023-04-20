using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitWaypoint : MonoBehaviour
{
    public Image img;
    public Transform target;

    [SerializeField]
    private float minSize;
    [SerializeField]
    private float maxSize;

    private float initialDistance;
    private float distanceToExit;
    private float scaleFactor;
    private float t;

    private void Start()
    {
        initialDistance = Vector3.Magnitude(target.position - gameObject.transform.position);
    }

    private void Update()
    {
        // resizing exit waypoint based on distance to exit
        distanceToExit = Vector3.Magnitude(target.position - gameObject.transform.position);
        t = distanceToExit / initialDistance;
        scaleFactor = Mathf.LerpUnclamped(minSize, maxSize, t);

        img.rectTransform.localScale = new Vector3(scaleFactor, scaleFactor, 1);

        float minX = (img.GetPixelAdjustedRect().width / 2) * scaleFactor;
        float maxX = Screen.width - minX;

        float minY = (img.GetPixelAdjustedRect().height / 2) * scaleFactor;
        float maxY = Screen.height - minY;

        Vector2 pos = Camera.main.WorldToScreenPoint(target.position);

        // only render exit waypoint if youre facing away from exit
        if (Vector3.Dot((target.position - transform.position), transform.forward) < 0)
        {
            img.enabled = true;
        }
        else
        {
            img.enabled = false;
        }

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        img.transform.position = pos;
    }
}
