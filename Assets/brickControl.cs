using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickControl : MonoBehaviour
{

    [SerializeField] GameObject[] brickPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTrans;
    [SerializeField] float maxTrans;

    void Start()
    {
        StartCoroutine(brickSpawn());
    }
    IEnumerator brickSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(brickPrefab[Random.Range(0, brickPrefab.Length)], 
                position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 2f);
        }
    }


}
