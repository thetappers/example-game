using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole_Collection : MonoBehaviour
{
    public GameObject[] moles;
    public Vector2 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public int count;
    public bool stop;

    //int randEnemy;

    void Start()
    {
        /*List<Moles> moles = new List<Moles>();

        moles.Add(new Moles("Toal", 13, 20, GetComponent<SpriteRenderer>()));  */

        StartCoroutine(Spawner());

    }

    void Update ()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    IEnumerator Spawner ()
    {
        yield return new WaitForSeconds(startWait);
        


        while (stop)
        {
            //randEnemy = Random.Range(0, 2);

            Vector2 spawnPosition = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y));

            Instantiate(moles[0], spawnPosition, gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }

}
