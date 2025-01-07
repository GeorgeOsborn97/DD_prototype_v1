using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;
using System.Runtime.CompilerServices;

public class EventScipt : MonoBehaviour
{
    public bool _isCountingDown = false;
    public GameObject _doomsday;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       CountDown();
    }

    public void CountDown()
    {
        if (_isCountingDown is true)
        {
            StartCoroutine(TakeOneAway());
        }
    }

    IEnumerator TakeOneAway()
    {
        var rnd = new System.Random();
        var _num = rnd.Next(1, 10);

        Debug.Log("number is " + _num);
        _doomsday.transform.GetComponent<TextMesh>().text = _num.ToString();
        yield return new WaitForSeconds(3.0f);
    }
}
