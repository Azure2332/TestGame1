using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : MonoBehaviour

{
    static public int TotalHealth;
    public int CurrentHealth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TotalHealth = TotalHealth - 1;

        if (TotalHealth <= 0)
        {

            Destroy(gameObject);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        TotalHealth = CurrentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
