using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamez;

public class Testing : MonoBehaviour
{
    private Grid grid;
    private void Start()
    {
        grid = new Grid(4, 2, 10f, new Vector3(20,0));
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.LogError(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
