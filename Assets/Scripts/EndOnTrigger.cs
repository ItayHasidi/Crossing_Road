using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOnTrigger : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    [SerializeField] string sceneName;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            SceneManager.LoadScene(sceneName);
        }
    }
}
