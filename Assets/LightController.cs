using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject light;
    public GameObject gameObject;
    private float previous = 0f;

    void Update()
    {
        float x = light.transform.position.x - gameObject.transform.position.x, y = Mathf.Abs(gameObject.transform.position.y - light.transform.position.y);
        if (Mathf.Abs(x) <= 11f && Mathf.Abs(y) <= 20f)
        {
            light.transform.LookAt(gameObject.transform.position);
        }
    }
}
