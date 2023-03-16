using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bulletPrefab;

    public GameObject player;

    private Quaternion bulletDirection;

    private Vector3 bulletmovement;

    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletDirection = player.transform.rotation;
            Instantiate(bulletPrefab, transform.position, bulletDirection );
        }
        bulletPrefab.transform.Translate ( bulletmovement * bulletSpeed * Time.deltaTime);
    }
}
