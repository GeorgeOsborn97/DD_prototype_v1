using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using Unity.VisualScripting;

public class GUIScript : MonoBehaviour
{

    public GameObject _guildHall;
    public Vector3 _iconScale = new Vector3(1, 3, 1);

    public void OnMouseOver()
    {
        _guildHall.SetActive(false);
    }

    public void OnMouseOut() { 
        _guildHall.SetActive(true); 
    }

    public void test()
    {
        Debug.Log("Hello");
        _guildHall.transform.localScale = new Vector3(1.2f, 3.6f, 1.0f);
        StartCoroutine(ScaleDown());
    }

    IEnumerator ScaleDown()
    {
        
        yield return new WaitForSeconds(2.0f);
        _guildHall.transform.transform.localScale = _iconScale;
    }

}
