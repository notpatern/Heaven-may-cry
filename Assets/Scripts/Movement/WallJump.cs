using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    [Header("ref")]
    public Transform Player;

    bool wallFront;
    bool wallLeft;
    bool wallRight;
    bool wallBehind;
    float wallDistance;

    private void Checks()
    {
        wallFront = Physics.Raycast(Player.orientation, Vector3.forward, wallDistance, isWall);
        wallBehind = Physics.Raycast(Player.orientation, -Vector3.forward, wallDistance, isWall);
    }

    void Update()
    {
        
    }
}
