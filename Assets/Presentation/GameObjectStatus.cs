using System;
using UnityEngine;

public abstract class GameObjectStatus : MonoBehaviour
{
    public bool status = false;

    public virtual void SetStatusOn(StatusDirection statusDirection)
    {
        switch (statusDirection)
        {
            case StatusDirection.Backward:
                Exit();
                break;
            case StatusDirection.Forward:
                Enter();
                break;
            default:
                throw new ArgumentOutOfRangeException("statusDirection", statusDirection, null);
        }
    }

    public virtual void SetStatusOff(StatusDirection statusDirection)
    {
        switch (statusDirection)
        {
            case StatusDirection.Backward:
                Enter();
                break;
            case StatusDirection.Forward:
                Exit();
                break;
            default:
                throw new ArgumentOutOfRangeException("statusDirection", statusDirection, null);
        }

    }

    public abstract void Enter();

    public abstract void Exit();
}

public enum StatusDirection
{
    Backward = 0,
    Forward = 1
}
