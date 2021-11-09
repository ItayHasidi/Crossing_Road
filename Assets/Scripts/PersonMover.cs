using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMover : MonoBehaviour
{
    float direction = 1; // move regularly
    [SerializeField]
    float stepSize = 1f;
    [Tooltip("Every object tagged with this tag will trigger the player to stop moving.")]
    [SerializeField] string triggeringTag;

    [SerializeField] GameObject background;
    void Update()
    {
        movePerson(this.direction);
    }

    /*
    *  1 - move regularly
    *  0 - dont move
    */
    public void movePerson(float direction){
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) // up
        {
            transform.position += new Vector3(0, stepSize, 0);
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) // down
        {
            transform.position += new Vector3(0, -stepSize, 0);
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // left
        {
            transform.position += new Vector3(-stepSize, 0, 0);
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // right
        {
            transform.position += new Vector3(stepSize, 0, 0);
        }
    }
}
