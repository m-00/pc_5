﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public PanelID Panel;
    public SpeakerRef Speaker;

    [TextArea(3, 5)]
    public string[] Sentences;

    public enum PanelID
    {
        Null = 0, // For use in SpeakerData, if the character has no associated panel
        Player = 1, // Use either brother or sister panel depending on situation
        Brother = 2,
        Sister = 3
    }
}