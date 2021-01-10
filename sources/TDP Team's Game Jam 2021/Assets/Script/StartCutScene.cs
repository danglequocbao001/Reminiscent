// === System ===
using System.Collections;
using System.Collections.Generic;

// === Unity Engine ===
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCutScene : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("LivingRoom");
    }

}
