using UnityEngine;

public class BlastBehavior : MonoBehaviour
{
    float blastRadiusSize = 5;
    float blastDamange;
    Vector3 blastIncrease = new Vector3(0.005f, 0.005f, 0f);

    void Start()
    {
        blastDamange = Random.Range(0.1f,0.5f);
    }
    void Update()
    {
        if (this.transform.localScale.x < blastRadiusSize)
        {
            this.transform.localScale += blastIncrease*2;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyHealth>().enemyDamageThreshold < blastDamange)
        {
            Destroy(collision.gameObject);
        }
    }
}