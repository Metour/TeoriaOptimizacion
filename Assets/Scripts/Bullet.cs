using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 5 * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other)
    {
        //Destroy(this.gameObject);
        this.gameObject.SetActive(false);
    }
}
