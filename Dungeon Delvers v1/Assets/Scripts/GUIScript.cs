using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GUIScript : MonoBehaviour
{

    public GameObject _guildHall;
    public GameObject _map;
    public GameObject _flag;
    public Vector3 _iconScale = new Vector3(1, 3, 1);
    public Vector3 _mapScale = new Vector3(1, 1, 1);
    public GameObject _eventManager;
    EventScipt _eventScript;
    



    public void guildHallClick()
    {
        Debug.Log("Hello");
        _guildHall.transform.localScale = new Vector3(1.2f, 3.6f, 1.0f);
        StartCoroutine(ScaleDown(_guildHall));
    }

    public void Mapclick()
    {
        _map.transform.localScale = new Vector3(1.05f, 1.0f, 1.0f);
        StartCoroutine(ScaleDown(_map));
    }


    public void ToGuildClick()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMapClick()
    {
        SceneManager.LoadScene(2);
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

    IEnumerator ScaleDown(GameObject _btn)
    {
        Scene _currentScene = SceneManager.GetActiveScene();
        _flag.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        if (_currentScene.name == "Worldmap")
        {
            _btn.transform.transform.localScale = _iconScale;
        }
        else if (_currentScene.name == "GuildhallScene")
        {
            _btn.transform.transform.localScale = _mapScale;
        }
        
    }


}
