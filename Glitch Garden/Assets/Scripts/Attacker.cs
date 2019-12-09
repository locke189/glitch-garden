using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [Range(0f, 10f)]
    [SerializeField] float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        Debug.Log("OK");
    }
}
