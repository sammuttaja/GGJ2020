﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public List<RepairableObject> availableObjects;
    public RoomManager manager;
    private RepairableObject selectedObject;
    

    private void Start()
    {
        // Get random from availables
        selectedObject = Instantiate(availableObjects[Random.Range(0, availableObjects.Count)]);
        selectedObject.transform.position = transform.position;
        selectedObject.transform.parent = this.transform;
        manager.RepairObjectCount++;
        selectedObject.manager = manager;
    }
}
