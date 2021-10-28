using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMovement : MonoBehaviour
{
    // Rails Movement
    public GameObject[] wayPoints;
    public int index = 0;
    public float speed = 7;
    // Update is called once per frame
    void Update()
    {
        if(index < wayPoints.Length -1)
        {
            // Rails Movement
            var distanceToWaypoint = Vector3.Distance(transform.position, wayPoints[index].transform.position);

            if (distanceToWaypoint < 0.5f)
            {
                index++;
            }

            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, wayPoints[index].transform.position, step);
        }
        

    }
}
