using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    private HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);
        healthSystem.Damage(10);
        healthBar.SetSize(50);
    }
}
