using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOnTrigger : MonoBehaviour
{
    // [SerializeField] Renderer rend;// = gameObject.GetComponent<Renderer>();
    //[Tooltip("Every object tagged with this tag will trigger a game over and restart the game.")]
    [SerializeField] string triggeringTag;
    [SerializeField] string sceneName;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            // ToggleVisibility();
            // Application.Quit();
            SceneManager.LoadScene(sceneName);
            // UnityEditor.EditorApplication.isPlaying = false;
        }
    }
    void Update()
    {
        
    }
    // public void ToggleVisibility()
    // {
        
    //     if(rend.enabled)
    //     {
    //         rend.enabled = false;
    //     }
    //     else
    //     {
    //         rend.enabled = true;
    //     }
    // }
}
