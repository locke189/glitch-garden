using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] bool loop = true;
    [SerializeField] GameObject enemy;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (loop) {
            yield return new WaitForSeconds(Random.Range(1f, 5f));
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }


}
