using UnityEngine;

public class CurrentObjectCommands : MonoBehaviour
{
    private Slided _slided;
    // Use this for initialization
    void Start()
    {
        _slided = gameObject.GetComponent<Slided>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            GameObject currentSlide = _slided.waypoints[_slided.currentWaypoint];
            SlideStatus slideStatus = currentSlide.GetComponent<SlideStatus>();
            slideStatus.OneStepFoward();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            GameObject currentSlide = _slided.waypoints[_slided.currentWaypoint];
            SlideStatus slideStatus = currentSlide.GetComponent<SlideStatus>();
            slideStatus.OneStepBack();
        }

    }
}
