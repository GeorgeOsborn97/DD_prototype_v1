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

    IEnumerator ScaleDown()
    {
        
        yield return new WaitForSeconds(2.0f);
        _guildHall.transform.transform.localScale = _iconScale;
        _flag.SetActive(true);
        
    }


}
