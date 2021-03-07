using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{
    [SerializeField]
    private float delay = 4f;

    void Start()
    {
        StartCoroutine(transitionScreen());
    }

    IEnumerator transitionScreen()
    {
        yield return new WaitForSeconds(delay);

        if(gameObject.tag == "GameOver")
            SceneManager.LoadScene("Map");

        if (gameObject.tag == "NextLevel")
        {
            if (MapManager.load == 5)
            {
                SceneManager.LoadScene("Ending");
            }else
            {
                SceneManager.LoadScene("Map");
            }
        }

        if(gameObject.tag == "LoadLevel")
        {
            SceneManager.LoadScene("Level" + MapManager.load);
        }
    }
}
