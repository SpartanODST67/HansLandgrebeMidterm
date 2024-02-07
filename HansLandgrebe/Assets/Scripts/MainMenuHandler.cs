using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] Image slideImage;
    [SerializeField] float slideSmooth;
    [SerializeField] Vector3 imageTarget;

    public void play()
    {
        StartCoroutine(slideToPlay());
    }

    IEnumerator slideToPlay()
    {
        while (Mathf.RoundToInt(slideImage.rectTransform.anchoredPosition.y) > imageTarget.y)
        {
            if (slideImage.rectTransform.anchoredPosition.y < imageTarget.y)
            {
                slideImage.rectTransform.anchoredPosition = imageTarget;
            }
            else
            {
                slideImage.rectTransform.anchoredPosition = Vector3.Lerp(slideImage.rectTransform.anchoredPosition, imageTarget, slideSmooth);
                yield return null;
            }
        }
        Debug.Log("Starting");
        SceneManager.LoadScene("GameScene");
    }

    public void quit()
    {
        Application.Quit();
    }
}
