using System.Collections;
using UnityEngine;

public class HapusObject : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 4);
        // StartCoroutine(HapusObjectNya());   
    }

    // IEnumerator HapusObjectNya()
    // {
    //     yield return new WaitForSeconds(5);
    //     Destroy(gameObject);
    // }
}
