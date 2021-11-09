using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfObjectSpawner;
    protected virtual GameObject spawnObject()
    {
        Vector3 position = transform.position;
        Quaternion rotation = new Quaternion(0, 180, 0, 0);
        GameObject newObject = Instantiate(prefabToSpawn, position, rotation);
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if(newObjectMover){
            newObjectMover.SetVelocity(velocityOfObjectSpawner);
        }
        return newObject;
    }
}
