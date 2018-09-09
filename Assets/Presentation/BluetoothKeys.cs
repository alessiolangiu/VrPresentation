using System;
using UnityEngine;

public class BluetoothKeys : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (var code in (KeyCode[])Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(code))
            {
                Debug.LogWarning(code);
            }
        }

        ///
        /// LeftArrow
        /// RightArrow
        /// UpArrow
        /// DownArrow
        /// Return
        /// B
        /// Escape
        /// Alpha1
        /// Alpha2
        /// Alpha3
        /// Alpha4
        /// Alpha5
        /// Alpha6
        /// Alpha7
        /// Alpha8
        /// Alpha9
        /// Alpha0
        /// Return

    }
}
