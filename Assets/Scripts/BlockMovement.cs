using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the player to stop moving.")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
