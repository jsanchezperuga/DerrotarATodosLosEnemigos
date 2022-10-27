using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionesFinOleadas : MonoBehaviour
{

    public GameObject pared;
    // Start is called before the first frame update
    
    public void ActivarPared(bool value)
    {
        pared.SetActive(value);
    }

}
