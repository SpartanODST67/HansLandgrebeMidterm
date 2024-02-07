using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallLimit : MonoBehaviour
{
    [SerializeField] float fallLimit = -5f;

    private void Update()
    {
        if (transform.position.y < fallLimit)
        {
            Destroy(gameObject);
        }
    }
}
