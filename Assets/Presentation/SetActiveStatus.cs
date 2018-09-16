public class SetActiveStatus : GameObjectStatus
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Enter()
    {
        gameObject.SetActive(true);
        status = true;
    }

    public override void Exit()
    {
        gameObject.SetActive(false);
        status = false;
    }
}
