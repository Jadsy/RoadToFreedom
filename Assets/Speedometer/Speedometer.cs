using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public PlayerMovement player;

    [Header("UI")]
    public RectTransform arrow; // The arrow in the speedometer

    private void Update()
    {
        if (arrow != null)
            arrow.localEulerAngles = new Vector3(0, 0, -(player.gas * 2));
    }
}
