using UnityEngine;

public class SlideStatus : MonoBehaviour
{
    public int CurrentSlideStep = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OneStepFoward()
    {
        Debug.LogWarning("OnStepBack Called");

        SlideSteps[] slideStepses = gameObject.GetComponents<SlideSteps>();
        foreach (SlideSteps step in slideStepses)
        {
            if (step.StepNumber == CurrentSlideStep + 1)
            {
                Debug.LogWarning("OnStepForward invoked on step " + step.StepNumber);

                step.Statuses.Invoke(StatusDirection.Forward);
                CurrentSlideStep++;
                return;
            }
        }
    }

    public void OneStepBack()
    {
        Debug.LogWarning("OnStepBack Called");
        SlideSteps[] slideStepses = gameObject.GetComponents<SlideSteps>();
        foreach (SlideSteps step in slideStepses)
        {
            //Undoing current step
            if (step.StepNumber == CurrentSlideStep)
            {
                step.Statuses.Invoke(StatusDirection.Backward);
                break;
            }
        }
        foreach (SlideSteps step in slideStepses)
        {
            //Undoing current step
            if (step.StepNumber == CurrentSlideStep - 1)
            {
                step.Statuses.Invoke(StatusDirection.Backward);
                CurrentSlideStep--;
                break;
            }
        }
    }
}
