using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScipt : MonoBehaviour
{

    public bool _isCountingDown = false;
    public GameObject Doomsday;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (_isCountingDown)
        {
            Debug.Log("hello");
        }
    }


}
