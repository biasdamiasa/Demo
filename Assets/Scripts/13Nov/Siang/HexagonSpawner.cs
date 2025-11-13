using System.Collections;
using UnityEngine;

public class HexagonSpawner : MonoBehaviour
{
    public GameObject hexagonSpawnerObject;
    public bool sedangSpawn = true;

    void Start()
    {
        StartCoroutine(MunculkanObject());
    }

    IEnumerator MunculkanObject()
    {
        while (sedangSpawn)
        {
            Instantiate(hexagonSpawnerObject, new Vector3(Random.Range(-8,8), Random.Range(-8, 8), 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
