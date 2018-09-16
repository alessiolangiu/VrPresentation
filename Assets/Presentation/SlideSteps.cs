using UnityEngine;
using UnityEngine.Events;

public class SlideSteps : MonoBehaviour
{
    public int StepNumber;

    [System.Serializable]
    public class OnChangeStatus : UnityEvent<StatusDirection> { };
    public OnChangeStatus Statuses;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
