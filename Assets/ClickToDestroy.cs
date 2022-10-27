using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        gameObject.GetComponent<EnemigoEstado>().isDead = true;
    }
}
