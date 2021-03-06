﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/* Class for defining which keyboard keys do what action in the game. */
public static class KeyMapGlobal
{
    public static KeyCode Unlock { get; set; } = KeyCode.E;
    public static KeyCode Examine { get; set; } = KeyCode.F;
    public static KeyCode NextSentence { get; set; } = KeyCode.F;
    public static KeyCode Attack { get; set; } = KeyCode.Space;
    public static KeyCode AttackSwitch { get; set; } = KeyCode.LeftShift;

    public static KeyCode MoveUp { get; set; } = KeyCode.W;
    public static KeyCode MoveLeft { get; set; } = KeyCode.A;
    public static KeyCode MoveDown { get; set; } = KeyCode.S;
    public static KeyCode MoveRight { get; set; } = KeyCode.D;
}

public class MissingComponentEx : Exception
{
    public MissingComponentEx(MonoBehaviour component) : base(String.Format("Missing {0} component.", component)) { }
}