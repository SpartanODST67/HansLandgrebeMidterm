using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartKey : MonoBehaviour
{
    [SerializeField] GameObject playerInput;
    [SerializeField] GameObject spawner;

    private void OnDestroy()
    {
        playerInput.SetActive(true);
        spawner.SetActive(true);
    }

}
