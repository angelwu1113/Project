using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBoat : MonoBehaviour
{
    public List<Vector3> WayPoints;
    public int CurrentIndex;
    public float SwitchDistance = 0.1f;
    public float speed = 1;
    void Start()
    {
        CurrentIndex = 0;
    }

    void Update()
    {
        if (WayPoints.Count>0)
        {
            if (Vector3.Distance(transform.position, WayPoints[CurrentIndex])<SwitchDistance)
            {
                CurrentIndex = (CurrentIndex +1)% WayPoints.Count;
            }
            else 
            {
                transform.position = Vector3.MoveTowards(transform.position, WayPoints[CurrentIndex], speed*Time.deltaTime);
            }
        }
    }
}