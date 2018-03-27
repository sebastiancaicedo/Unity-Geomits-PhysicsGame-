﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "LevelsInfo/New LevelInfo", menuName = "Geomits/LevelInfo", order = 1)]
public class LevelInfo : ScriptableObject {

    [SerializeField]
    GameObject scenario;
    [SerializeField]
    [Range(-100.00f, -0.01f)]
    float gravity;
    [SerializeField]
    float[] projectilesMass;
    [SerializeField]
    Limits cameraHztalLimits;
    [SerializeField]
    Limits cameraVrtcalLimits;

    public GameObject Scenario { get { return scenario; } }
    public float Gravity { get { return gravity; } }
    public int ProjectilesCount { get { return projectilesMass.Length; } }
    public float[] ProjectilesMass { get { return projectilesMass; } }
    public Limits CamHztalLimits { get { return cameraHztalLimits; } }
    public Limits CamVrtcalLimits { get { return cameraVrtcalLimits; } }

	
}
