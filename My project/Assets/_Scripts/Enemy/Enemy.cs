using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    public GameObject blood;

    // Update is called once per frame
    void Update()
    {
        EnemyDead();
    }

    public void Damage(int damage,Quaternion rot)
    {
        health -= damage;
        GameObject bloodInstance = Instantiate(blood, transform.position, rot);
        Destroy(bloodInstance, 2);
    }

    public void EnemyDead()
    {
        if (health <= 0)
        {
            EnemyManager.instance.RemoveEnemy(this);
            Destroy(gameObject);
        }
    }
}
