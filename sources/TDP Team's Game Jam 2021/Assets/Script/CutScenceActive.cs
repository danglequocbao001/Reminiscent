﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScenceActive : MonoBehaviour
{
    public GameObject player;
    public GameObject animator;
    public GameObject button;
    public GameObject effect;
    float original_speed;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        button.SetActive(true);
        original_speed = player.GetComponent<BoyController>().speed;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        button.SetActive(false);
    }
    public void beginCutScene()
    {
        effect.SetActive(true);
        animator.SetActive(true);
        player.GetComponent<BoyController>().speed = 0;
        StartCoroutine(FinishCut());
    }
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(1);
        player.GetComponent<BoyController>().speed = original_speed;
        animator.SetActive(false);
        effect.SetActive(false);
    }
}