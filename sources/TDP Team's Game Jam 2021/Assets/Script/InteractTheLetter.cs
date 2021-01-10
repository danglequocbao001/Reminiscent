using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTheLetter : MonoBehaviour
{

    public GameObject player;
    public GameObject open_leter_button;
    public GameObject close_leter_button;
    public GameObject letter;
    float original_speed;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hellpo");
        open_leter_button.SetActive(true);
        original_speed = player.GetComponent<BoyController>().speed;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        open_leter_button.SetActive(false);
    }

    public void openTheLetter()
    {
        letter.SetActive(true);
        open_leter_button.SetActive(false);
        player.GetComponent<BoyController>().speed = 0;
        close_leter_button.SetActive(true);
        StartCoroutine(FinishCut());
    }

    public void closeTheLetterAndEndGame()
    {
        letter.SetActive(false);
        close_leter_button.SetActive(false);
        Debug.Log("close and end game");
        player.GetComponent<BoyController>().speed = original_speed;
    }

    IEnumerator FinishCut()
    {yield return new WaitForSeconds(1);}
}
