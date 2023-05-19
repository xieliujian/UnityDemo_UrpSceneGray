using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(UrpSceneGray))]
public class UrpSceneGrayEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var script = target as UrpSceneGray;
        if (script == null)
            return;

        if (GUILayout.Button("�л�Ч��"))
        {
            script.SwitchEff();

            Repaint();
        }    
    }
}
