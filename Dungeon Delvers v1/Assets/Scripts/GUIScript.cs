using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GUIScript : MonoBehaviour
{

    public GameObject _guildHall;
    public GameObject _flag;
    public Vector3 _iconScale = new Vector3(1, 3, 1);
    public GameObject _eventManager;
    EventScipt _eventScript;



    public void guildHallClick()
    {
        Debug.Log("Hello");
        _guildHall.transform.localScale = new Vector3(1.2f, 3.6f, 1.0f);
        StartCoroutine(ScaleDown());
    }


    public void flagBtnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void closeBtn()
    {
        _flag.SetActive(false);
    }

    public void StartTime()
    {
        Debug.Log("hello again");
        _eventScript = _eventManager.GetComponent<EventScipt>();
        _eventScript._isCountingDown = true;
    }

    IEnumerator ScaleDown()
    {
        _flag.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        _guildHall.transform.transform.localScale = _iconScale;
        
    }


}
