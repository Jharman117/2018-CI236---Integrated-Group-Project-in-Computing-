using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Transform bar;

    // Start is called before the first frame update
    private void Start()
    {
        Transform bar = transform.Find("bar");
    }

    public void SetSize(int health)
    {
        float sizeNormalised = health / 100;
        bar.localScale = new Vector3(sizeNormalised, 1f);
    }
}
