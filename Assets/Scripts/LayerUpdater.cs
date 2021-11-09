using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerUpdater : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger a Layer change.")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            GameObject person = GetComponent<GameObject>();
            Debug.Log(person.gameObject.layer);
            person.gameObject.layer += 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
