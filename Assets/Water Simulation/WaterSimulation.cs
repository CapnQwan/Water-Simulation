using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSimulation : MonoBehaviour
{
  [SerializeField]
  private Vector2 simulationBoands;
  [SerializeField]
  private int numberOfParticals;
  [SerializeField]
  private float gravity;
  [SerializeField]
  private GameObject prefab;

  private GameObject[] _particals;


}
