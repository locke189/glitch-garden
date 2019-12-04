using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    [SerializeField] float delay = 3f;
    [SerializeField] string sceneToLoad = "Main Menu";
    [SerializeField] bool onStart = true;

    void Start()
    {
        if (onStart) {
            StartCoroutine(LoadSceneDelayed(sceneToLoad));
        }
    }

    IEnumerator LoadSceneDelayed(string sceneLabel)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneLabel);
    }
}
