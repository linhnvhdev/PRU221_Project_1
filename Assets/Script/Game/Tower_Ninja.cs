using System;
using System.Collections;
using UnityEngine;

public class Tower_Ninja : Tower
{
    //FIELDS
    //damage
    public int damage;
    //prefab (shooting item)
    public GameObject prefab_shootItem;
    //shoot interval
    public float interval;
    Enemy enemy;
    public LayerMask enemyLayerMask;
    public bool hasEnemy = false;

    //METHODS
    //init (start the shooting interval)
    protected override void Start()
    {
        Debug.Log("NINJA");
        //start the shooting interval IEnum
        StartCoroutine(ShootDelay());
    }
    private void Update()
    {
        CheckEnemyInRange();
    }
    private void CheckEnemyInRange()
    {
        if(Physics2D.Raycast(transform.position, transform.right, 100, enemyLayerMask))
        {
            hasEnemy = true;
        }
        else
        {
            hasEnemy = false;
        }
    }
    //Interval for shooting
    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(interval);
        if(hasEnemy)
        {
            ShootItem();
        }      
        StartCoroutine(ShootDelay());
    }
    //Shoot an item
    void ShootItem()
    {
        //Instantiate shoot item
        GameObject shotItem = Instantiate(prefab_shootItem,transform);
        //Set its values  
        shotItem.GetComponent<ShootItem>().Init(damage);
    }
}
