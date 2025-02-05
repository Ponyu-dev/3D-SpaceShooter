using UnityEngine;
using UnityEditor;
using System;

namespace GameSoftCraft
{
    [CustomEditor(typeof(SkyMaterial))]
    public class SkyMaterialEditor : Editor
    {
        SkyMaterial _target;

        private void OnEnable ()
        {
            _target = (SkyMaterial)target;
            Undo.undoRedoPerformed += _target.UpdateMaterialProperties;
        }

        private void OnDisable ()
        {
            Undo.undoRedoPerformed -= _target.UpdateMaterialProperties;
        }

        public static void DrawInspector (SerializedObject serializedObject, SkyMaterial target)
        {
            void DisplayField<T> (string name, Func<SerializedProperty, T> getter, Action<SerializedProperty, T> setter, Func<T, GUILayoutOption[], T> field)
            {
                var prop = serializedObject.FindProperty(name);
                var label = new GUIContent(prop.displayName, prop.tooltip);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField(label);
                setter.Invoke(prop, field.Invoke(getter.Invoke(prop), null));
                EditorGUILayout.EndHorizontal();
            }

            void DisplayLabelledField<T> (string name, Func<SerializedProperty, T> getter, Action<SerializedProperty, T> setter, Func<GUIContent, T, GUILayoutOption[], T> field)
            {
                var prop = serializedObject.FindProperty(name);
                var label = new GUIContent(prop.displayName, prop.tooltip);
                setter.Invoke(prop, field.Invoke(label, getter.Invoke(prop), null));
            }

            void DisplayFieldsGroup (params Action[] displays)
            {
                EditorGUILayout.BeginVertical("box");
                for (var i = 0; i < displays.Length; i++) {
                    displays[i].Invoke();
                };
                EditorGUILayout.EndVertical();
            }

            void DisplayTitledFieldsGroup (string label, params Action[] displays)
            {
                EditorGUILayout.LabelField(label, EditorStyles.whiteMiniLabel);
                DisplayFieldsGroup(displays);
            }

            void DisplaySection (string label, params Action[] groups)
            {
                EditorGUILayout.BeginVertical("box");
                EditorGUILayout.LabelField(label, EditorStyles.whiteLargeLabel);
                for (var i = 0; i < groups.Length; i++) {
                    groups[i].Invoke();
                };
                EditorGUILayout.EndVertical();
            }

            void DisplayToggleGroup (string flagName, string displayName, string label, params Action[] content)
            {
                var boolProp = serializedObject.FindProperty(flagName);
                if (boolProp.boolValue = EditorGUILayout.BeginToggleGroup(displayName, boolProp.boolValue)) {
                    EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
                    EditorGUILayout.LabelField(label, EditorStyles.whiteLargeLabel);
                    EditorGUILayout.BeginVertical("box");
                    for (var i = 0; i < content.Length; i++) {
                        content[i].Invoke();
                    }
                    EditorGUILayout.EndVertical();
                }
                EditorGUILayout.EndToggleGroup();
            }

            void DisplayGeneralSettings ()
            {
                DisplaySection(
                    "General Settings: ",
                    () => DisplayFieldsGroup(
                        () => DisplayIntField("_seed"),
                        () => DisplaySliderField("_gamma", 0.5f, 1.2f),
                        () => DisplayVectorField("_orientation")
                        )
                );
            }

            void DisplayStarsSettings ()
            {
                DisplaySection(
                   "Stars Settings: ",
                   () => DisplayTitledFieldsGroup(
                       "Far Stars: ",
                       () => DisplayRange01Field("_farStarDensity"),
                       () => DisplayRange01Field("_farStarTwinkle")
                       ),
                   () => DisplayTitledFieldsGroup(
                       "Mid Stars: ",
                       () => DisplayRange01Field("_midStarDensity"),
                       () => DisplayRange01Field("_midStarTwinkle")
                       ),
                   () => DisplayTitledFieldsGroup(
                       "Near Stars: ",
                       () => DisplayRange01Field("_nearStarDensity")
                       ),
                   () => DisplayTitledFieldsGroup(
                       "Nebulae: ",
                       () => DisplayColorField("_nebulaColorOffset")
                       )
               );
            }

            void DisplaySunSettings ()
            {
                DisplayToggleGroup(
                   "_isSunOn", "Enable Sun", "Sun Settings: ",
                   () => DisplayRange01Field("_sunSize"),
                   () => DisplayRange01Field("_sunCoronaSpeed"),
                   () => DisplayVectorField("_sunDirection"),
                   () => DisplayColorField("_sunTint")
                   );
            }

            void DisplayVectorField (string name) => DisplayLabelledField(name, p => p.vector3Value, (p, v) => p.vector3Value = v, EditorGUILayout.Vector3Field);
            void DisplayColorField (string name) => DisplayField(name, p => p.colorValue, (p, v) => p.colorValue = v, EditorGUILayout.ColorField);
            void DisplayIntField (string name) => DisplayField(name, p => p.intValue, (p, v) => p.intValue = v, EditorGUILayout.IntField);
            void DisplayFloatField (string name) => DisplayField(name, p => p.floatValue, (p, v) => p.floatValue = v, EditorGUILayout.FloatField);
            void DisplayRange01Field (string name) => DisplaySliderField(name, 0.0f, 1.0f);
            void DisplaySliderField (string name, float min, float max) =>
               DisplayField(name, p => p.floatValue, (p, v) => p.floatValue = v, (v, o) => EditorGUILayout.Slider(v, min, max));

            serializedObject.Update();

            EditorGUI.BeginChangeCheck();

            DisplayGeneralSettings();

            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

            DisplayStarsSettings();
            DisplaySunSettings();

            DisplayToggleGroup(
                "_isPlanetOn", "Enable Planet", "Planet Settings: ",
                () => DisplayRange01Field("_planetSize"),
                () => DisplayVectorField("_planetDirection"),
                () => DisplaySliderField("_planetAngle", -3.14f, 3.14f),
                () => DisplayRange01Field("_planetSpeed"),
                () => DisplayColorField("_planetTint"),
                () => DisplayColorField("_planetAtmosphereTint"),
                () => DisplayRange01Field("_planetAtmosphereThickness"),
                () => DisplayRange01Field("_planetBrightness"),
                () => DisplaySliderField("_shadowAngle", -3.14f, 3.14f),
                () => DisplaySliderField("_shadowDepth", 0, 3f)
                );

            DisplayToggleGroup(
                "_isDebrisOn", "Enable Debris", "Debris Settings: ",
                () => DisplayColorField("_meteorsTint"),
                () => DisplayRange01Field("_meteorsBrightness"),
                () => DisplayRange01Field("_meteorsSpeed")
                );

            if (EditorGUI.EndChangeCheck()) {
                serializedObject.ApplyModifiedProperties();
                target.UpdateMaterialProperties();
            }
        }

        public override void OnInspectorGUI ()
        {
            DrawInspector(serializedObject, target as SkyMaterial);
        }
    }
}
