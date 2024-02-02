using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    public void moveCharacter(float direction)
    {
        Vector3 moveDistance = new Vector3(movementSpeed * direction * Time.deltaTime, 0, 0);
        transform.position += moveDistance;
    }
}
