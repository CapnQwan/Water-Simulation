using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPartical : MonoBehaviour
{
  private Vector3 _position;

  private void Update()
  {
    DrawCircle(Vector2.zero, 1, Colour.lightBlue);
  }
}
