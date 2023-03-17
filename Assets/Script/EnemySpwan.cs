using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwan : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;

    public GameObject player;

    private Vector3 direction;

    private GameObject temp;

    public float enemySpeed = 20f;

    private void Start()
    {
        direction = player.transform.position;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
        }

    }
    public void  movement(GameObject enemy)
    {
        enemy.transform.position = Vector3.MoveTowards(transform.position, direction, enemySpeed * Time.deltaTime);
    }
}
