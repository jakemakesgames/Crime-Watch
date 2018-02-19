using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locationSpawner : MonoBehaviour
{
    public Transform location;
    public Transform blips;

    public void InstantiateBlip()
    {
        Instantiate(blips, location.position, Quaternion.identity);
    }
}
