using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeWarp : MonoBehaviour
{
    List<ITimeInterator> timeInterators;

    bool isFuture;

    private void Awake()
    {
        timeInterators = new List<ITimeInterator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        SetTime();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            isFuture = !isFuture;
            SetTime();
        }
    }

    public void SetTime()
    {
        
        for(int i=0; i<timeInterators.Count; i++)
        {
            timeInterators[i].SetTime(isFuture);
        }
    }
    
    public void AddInteractor(ITimeInterator interator)
    {
        timeInterators.Add(interator);
    }
}
