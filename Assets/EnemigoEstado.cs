using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstado : MonoBehaviour
{
    public bool isDead = false;
    
    void OnEnable()
    {
        isDead = false;
    }
}
