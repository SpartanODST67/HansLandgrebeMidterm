using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] MoveCharacter controlledCharacter;
    private float moveDirection = 0;

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxisRaw("Horizontal");
        controlledCharacter.moveCharacter(moveDirection);
    }
}
