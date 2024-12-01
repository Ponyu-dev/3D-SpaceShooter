using UnityEditor;
using UnityEngine;

namespace GameSoftCraft
{
    [CustomEditor(typeof(StarfieldMatManager))]
    public class StarfieldMatManagerEditor : Editor
    {
        StarfieldMatManager _manager;

        SerializedObject _skyMatSerializedObject;

        private void OnEnable ()
        {
            _manager = (StarfieldMatManager)target;
            _skyMatSerializedObject = new SerializedObject(_manager.skyMaterial);
            Undo.undoRedoPerformed += _manager.skyMaterial.UpdateMaterialProperties;
        }

        private void OnDisable ()
        {
            Undo.undoRedoPerformed -= _manager.skyMaterial.UpdateMaterialProperties;
        }

        public override void OnInspectorGUI ()
        {
            DrawDefaultInspector();
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            SkyMaterialEditor.DrawInspector(_skyMatSerializedObject, _manager.skyMaterial);
        }
    }
}
