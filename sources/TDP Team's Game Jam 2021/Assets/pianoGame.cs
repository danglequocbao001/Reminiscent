using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pianoGame : MonoBehaviour
{
    public GameObject D;
    public GameObject E;
    public GameObject A;
    public GameObject button;

    GameObject lastPress;
    int count;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Debug.Log(wp);
            Vector2 touchPos = new Vector2(wp.x, wp.y);
            if (D.GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log("D");
                lastPress = D;
                count++;
            }
            if (E.GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPos) && lastPress == D)
            {
                Debug.Log("E");
                lastPress = E;
                count++;
            }
            if (A.GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log("A");
                lastPress = A;
                count++;
            }
            if(D.GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPos) && lastPress ==A && count == 3)
            {
                button.SetActive(true);
            }
        }
    }
    public void activeToggle()
    {
        if(gameObject.active == true)
        {
            gameObject.SetActive(false);
        }
        else gameObject.SetActive(true);
    }
    void playCutScene()
    {

    }
}
