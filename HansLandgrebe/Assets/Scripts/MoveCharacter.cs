using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float movementRange;

    private void LateUpdate()
    {
        if(transform.position.x > movementRange)
        {
            transform.position = new Vector3(movementRange, transform.position.y, 0);
        }
        if(transform.position.x < -movementRange)
        {
            transform.position = new Vector3(-movementRange, transform.position.y, 0);
        }
    }

    public void moveCharacter(float direction)
    {
        Vector3 moveDistance = new Vector3(movementSpeed * direction * Time.deltaTime, 0, 0);
        transform.position += moveDistance;
    }
}
