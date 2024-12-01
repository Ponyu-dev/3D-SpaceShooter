using UnityEngine;

namespace GameSoftCraft
{
    [ExecuteAlways]
    public class StarfieldMatManager : MonoBehaviour
    {
        public SkyMaterial skyMaterial;

        private void OnValidate ()
        {
            Refresh();
        }

        private void Refresh ()
        {
            if (skyMaterial == null) {
                Debug.LogWarning("Sky Materialis not assigned!");
                return;
            }

            skyMaterial.UpdateMaterialProperties();
            var skyboxMaterial = skyMaterial.GetMaterial();
            if (skyboxMaterial != null) {
                RenderSettings.skybox = skyboxMaterial;
                DynamicGI.UpdateEnvironment();
            }
            else {
                Debug.LogError("Failed to get material from Sky Material!");
            }
        }
    }
}
