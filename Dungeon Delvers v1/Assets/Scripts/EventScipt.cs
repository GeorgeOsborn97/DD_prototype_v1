using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;
using System.Runtime.CompilerServices;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class EventScipt : MonoBehaviour
{
    public bool _isCountingDown = false;
    public List<int> _nums = new List<int>();
    public bool _isInList;
    public GameObject _doomsday;
    public GameObject _mountain;
    public GameObject _lake;
    public GameObject _forest;
    public GameObject _quest;

    
    // Start is called before the first frame update
    void Start()
    {
        _nums.Add(1);
        _nums.Add(2);
        _nums.Add(3);
    }

    // Update is called once per frame
    void Update()
    {
    }


    #region Random Encounter
    public void RandomNum()
    {
        StartCoroutine(GenerateRandom());
        

    }

    IEnumerator GenerateRandom()
    {
        while (_isInList == false)
        {
            var rnd = new System.Random();
            var _num = rnd.Next(1, 10);
            Debug.Log("number is " + _num);
            if (_nums.Contains(_num))
            {
                _isInList = true;
                if (_num == 1)
                {
                    _mountain.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (_num == 2)
                {
                    _lake.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (_num == 3)
                {
                    _forest.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                }

                yield break;
            }
            yield return new WaitForSeconds(3.0f);
        }

    }
    #endregion

    public void OpenQuest()
    {
        _quest.SetActive(true);
    }
    public void closeBtn()
    {
        _quest.SetActive(false);
    }
}
