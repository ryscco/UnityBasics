using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyDamageThreshold;
    // Start is called before the first frame update
    void Start()
    {
        enemyDamageThreshold = Random.Range(0.1f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}