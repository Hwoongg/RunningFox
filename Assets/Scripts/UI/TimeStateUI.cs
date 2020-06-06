using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TimeStateUI : MonoBehaviour, ITimeInterator
{
    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        FindObjectOfType<TimeWarp>().AddInteractor(this);
    }

    

    public void SetTime(bool isFuture)
    {
        if(isFuture)
        {
            text.text = "Is Future";
        }
        else
        {
            text.text = "Is Now";
        }
    }
}
