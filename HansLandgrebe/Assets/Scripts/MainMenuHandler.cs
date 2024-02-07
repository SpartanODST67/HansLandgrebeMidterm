using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] Image fadeImage;
    [SerializeField] float fadeSmooth;
    [SerializeField] Vector3 imageTargetVector;

    public void play()
    {
        StartCoroutine(fadeToPlay());
    }

    IEnumerator fadeToPlay()
    {
        /*while (Mathf.RoundToInt(fadeImage.rectTransform.anchoredPosition.y) > imageTargetVector.y)
        {
            if (fadeImage.rectTransform.anchoredPosition.y < imageTargetVector.y)
            {
                fadeImage.rectTransform.anchoredPosition = imageTargetVector;
            }
            else
            {
                fadeImage.rectTransform.anchoredPosition = Vector3.Lerp(fadeImage.rectTransform.anchoredPosition, imageTargetVector, fadeSmooth);
                yield return null;
            }
        }*/
        yield return null;

        Debug.Log("Play");
        SceneManager.LoadScene("GameScene");
    }

    public void quit()
    {
        Application.Quit();
    }
}
