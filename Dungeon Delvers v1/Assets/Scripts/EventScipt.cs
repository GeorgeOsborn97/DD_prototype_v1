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
 
        Doomsday.gameObject.transform.GetChild(1).GetComponent<TextEditor>().text = rnd.ToString();
        yield return new WaitForSeconds(3.0f);
    }
}
