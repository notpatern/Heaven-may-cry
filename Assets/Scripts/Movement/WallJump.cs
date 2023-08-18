using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    [Header("ref")]
    public Transform Player;
    public LayerMask isWall;

    bool wallFront;
    bool wallLeft;
    bool wallRight;
    bool wallBehind;
    float wallDistance;

    private void Checks()
    {
        wallFront = Physics.Raycast(Player.orientation, Vector3.forward, wallDistance, isWall);
        wallBehind = Physics.Raycast(Player.orientation, -Vector3.forward, wallDistance, isWall);
        wallLeft = Physics.Raycast(Player.orientation, -Vector3.right, wallDistance, isWall);
        wallRight = Physics.Raycast(Player.orientation, Vector3.right, wallDistance, isWall);

        if (wallFront) Debug.Log("Front");
        if (wallBehind) Debug.Log("Back");
        if (wallLeft) Debug.Log("Left");
        if (wallRight) Debug.Log("Right");
    }

    void FixedUpdate()
    {
        Checks();
    }
}
