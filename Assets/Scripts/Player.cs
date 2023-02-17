using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform gunPosition;

    public int ammoType;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //Instantiate(bulletPrefab, gunPosition.position, gunPosition.rotation);
            GameObject bullet = PoolManager.Instance.GetPooledObjects(ammoType, gunPosition.position, gunPosition.rotation);
            bullet.SetActive(true);
        }
    }
}
