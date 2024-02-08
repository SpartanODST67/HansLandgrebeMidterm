using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] float spinSpeed;
    private Rigidbody2D gameObjectRB;

    private void Start()
    {
        gameObjectRB = GetComponent<Rigidbody2D>();
        gameObjectRB.AddTorque(spinSpeed, ForceMode2D.Impulse);
    }
}
