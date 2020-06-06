using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIObject : MonoBehaviour, ITimeInterator
{
    [SerializeField] GameObject nowPrf;
    [SerializeField] GameObject futurePrf;

    //bool isFuture;

    public virtual void Start()
    {
        FindObjectOfType<TimeWarp>().AddInteractor(this);
    }

    public virtual void SetTime(bool isFuture)
    {
        if (isFuture)
        {
            nowPrf.SetActive(false);
            futurePrf.SetActive(true);
        }
        else
        {
            nowPrf.SetActive(true);
            futurePrf.SetActive(false);
        }
    }
}
