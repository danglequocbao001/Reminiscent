using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoKitchen : MonoBehaviour
{
    public string toScene;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(toScene, LoadSceneMode.Single);
    }
}
