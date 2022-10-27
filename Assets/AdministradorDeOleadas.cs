using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorDeOleadas : MonoBehaviour
{
    public GameObject[] enemigos;
    public int waveCount = 1;
    public int maxWaveCount = 3;
    public bool bossDefeated = false;
    void Start()
    {
        Debug.Log(enemigos.Length);
        GetComponent<AccionesFinOleadas>().ActivarPared(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (GetDefeatedEnemiesCount() == enemigos.Length)
        {
            if (waveCount < maxWaveCount && bossDefeated)
            {
            waveCount++;
            ActivateAllEnemies();
            GetComponent<AccionesFinOleadas>().ActivarPared(true);
            bossDefeated = false;
            }
            else
            {
                //terminaron las oleadas y pasa algo
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            bossDefeated = true;
        }
    }

    public void ActivateAllEnemies()
    {
        for (int i = 0; i < enemigos.Length; i++)
        {
            enemigos[i].SetActive(true);            
        }
    }

    int GetDefeatedEnemiesCount()
    {
        int count = 0;
        for (int i = 0; i < enemigos.Length; i++)
        {
            if (enemigos[i].GetComponent<EnemigoEstado>().isDead)
            {
                count++;
            }
        }
        return count;
    }
}
