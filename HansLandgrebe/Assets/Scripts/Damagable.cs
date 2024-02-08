using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damagable : MonoBehaviour
{
    [SerializeField] GameObject explosionSound;

    private void OnDisable()
    {
        Instantiate(explosionSound);
        SceneManager.LoadScene("TitleScene");
    }
}
