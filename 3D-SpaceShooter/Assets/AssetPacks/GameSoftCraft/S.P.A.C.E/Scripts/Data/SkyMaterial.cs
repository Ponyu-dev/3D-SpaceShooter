using UnityEngine;

namespace GameSoftCraft
{
    [CreateAssetMenu(fileName = "Sky Material", menuName = "S.P.A.C.E/Sky Material")]
    public class SkyMaterial : ScriptableObject
    {
        [Header("General Settings")]
        [SerializeField, Tooltip("Seed for procedural generation. Controls randomness in stars, nebula, and other features.")]
        int _seed = 0;

        [SerializeField, Tooltip("Controls the overall brightness adjustment of the sky. Lower values darken the sky, higher values brighten it.")]
        float _gamma = 1;

        [SerializeField, Tooltip("Enable or disable the sun in the sky material.")]
        bool _isSunOn;

        [SerializeField, Tooltip("Enable or disable the planet in the sky material.")]
        bool _isPlanetOn;

        [SerializeField, Tooltip("Enable or disable space debris effects in the sky material.")]
        bool _isDebrisOn;

        [SerializeField, Tooltip("Orientation of the sky material. This vector determines rotation applied to stars, planets, and other elements.")]
        Vector3 _orientation = Vector3.zero;

        [Header("Stars Settings")]

        [SerializeField, Tooltip("Density of far stars. Higher values create more distant stars.")]
        float _farStarDensity = .7f;

        [SerializeField, Tooltip("Twinkling effect for far stars. Higher values increase twinkle intensity.")]
        float _farStarTwinkle = .7f;

        [SerializeField, Tooltip("Density of mid-range stars. Higher values increase the number of stars closer than far stars but farther than near stars.")]
        float _midStarDensity = .7f;

        [SerializeField, Tooltip("Twinkling effect for mid-range stars. Adjusts twinkle intensity for mid-distance stars.")]
        float _midStarTwinkle = .7f;

        [SerializeField, Tooltip("Density of near stars. Controls how many stars appear close to the camera.")]
        float _nearStarDensity = 1.0f;

        [SerializeField, Tooltip("Color offset applied to nebula regions in the sky material.")]
        Color _nebulaColorOffset = Color.white;

        [Header("Sun Settings")]

        [SerializeField, Tooltip("Size of the sun object in the sky.")]
        float _sunSize = .7f;

        [SerializeField, Tooltip("Speed of the sun's corona effect, adding a dynamic glow around the sun.")]
        float _sunCoronaSpeed = .7f;

        [SerializeField, Tooltip("Direction vector for the sun's position in the sky.")]
        Vector3 _sunDirection = Vector3.forward;

        [SerializeField, Tooltip("Color tint for the sun. Use to adjust the sun's hue.")]
        Color _sunTint = Color.yellow;

        [Header("Planet Settings")]
        [SerializeField, Tooltip("Size of the planet in the sky.")]
        float _planetSize = .7f;

        [SerializeField, Tooltip("Direction vector for the planet's position in the sky.")]
        Vector3 _planetDirection = Vector3.back;

        [SerializeField, Tooltip("Color tint for the planet. Controls the main color of the planet.")]
        Color _planetTint = new Color(1f, .3f, .25f);

        [SerializeField, Tooltip("Color tint for the atmosphere surrounding the planet.")]
        Color _planetAtmosphereTint = new Color(0, .8f, .35f);

        [SerializeField, Tooltip("Thickness of the planet's atmosphere layer. Higher values make the atmosphere more prominent.")]
        float _planetAtmosphereThickness = .7f;

        [SerializeField, Tooltip("Brightness level of the planet. Higher values make the planet appear brighter.")]
        float _planetBrightness = .7f;

        [SerializeField, Tooltip("Angle of the planet's axis. Adjust to tilt the planet.")]
        float _planetAngle = .5f;

        [SerializeField, Tooltip("Rotation speed of the planet. Higher values make the planet rotate faster.")]
        float _planetSpeed = .5f;

        [SerializeField, Tooltip("Angle of the shadow cast on the planet.")]
        float _shadowAngle = .7f;

        [SerializeField, Tooltip("Depth of the shadow on the planet, adjusting darkness.")]
        float _shadowDepth = .2f;

        [Header("Space Debris Settings")]
        [SerializeField, Tooltip("Color of the space debris")]
        Color _meteorsTint = new Color(0.7f, 0.5f, 0.6f);

        [SerializeField, Tooltip("Brightness of space debris elements. Higher values make debris more visible.")]
        float _meteorsBrightness = .7f;

        [SerializeField, Tooltip("Speed of the space debris movement.")]
        float _meteorsSpeed = .7f;

        [SerializeField, HideInInspector]
        Material _material;

        private void EnableKeyword (string keyword, bool isEnabled)
        {
            if (isEnabled) {
                _material.EnableKeyword(keyword);
                return;
            }

            _material.DisableKeyword(keyword);
        }

        public Material GetMaterial ()
        {
            if (_material == null) {
                var shader = Shader.Find("GameSoftCraft/S.P.A.C.E");
                if (shader != null) {
                    _material = new Material(shader);
                    UpdateMaterialProperties();
                }
                else {
                    Debug.LogError("Shader not found!");
                }
            }

            return _material;
        }

        public void UpdateMaterialProperties ()
        {
            if (_material == null) return;

            EnableKeyword("SUN_ON", _isSunOn);
            EnableKeyword("PLANET_ON", _isPlanetOn);
            EnableKeyword("DEBRIS_ON", _isDebrisOn);

            /// Update general settings
            _material.SetInt("_Seed", _seed);
            _material.SetFloat("_Gamma", _gamma);
            _material.SetVector("_Orientation", _orientation);

            /// Update stars settings
            _material.SetFloat("_FarStarDens", _farStarDensity);
            _material.SetFloat("_FarStarTwinkle", _farStarTwinkle);
            _material.SetFloat("_MidStarDens", _midStarDensity);
            _material.SetFloat("_MidStarTwinkle", _midStarTwinkle);
            _material.SetFloat("_NearStarDens", _nearStarDensity);
            _material.SetColor("_NebulaColOffset", _nebulaColorOffset);

            /// Update sun settings if applicable
            if (_isSunOn) {
                _material.SetFloat("_SunSize", _sunSize);
                _material.SetFloat("_SunCoronaSpeed", _sunCoronaSpeed);
                _material.SetVector("_SunDir", _sunDirection);
                _material.SetColor("_SunTint", _sunTint);
            }

            /// Update planet settings if applicable
            if (_isPlanetOn) {
                _material.SetVector("_PlanetDir", _planetDirection);
                _material.SetColor("_PlanetTint", _planetTint);
                _material.SetColor("_PlanetAtmoTint", _planetAtmosphereTint);
                _material.SetFloat("_PlanetAtmoThick", _planetAtmosphereThickness);
                _material.SetFloat("_PlanetBrightness", _planetBrightness);
                _material.SetFloat("_PlanetAngle", _planetAngle);
                _material.SetFloat("_PlanetSpeed", _planetSpeed);
                _material.SetFloat("_ShadowAngle", _shadowAngle);
                _material.SetFloat("_ShadowDepth", _shadowDepth);
                _material.SetFloat("_PlanetSize", _planetSize);
            }

            /// Update space debris settings if applicable
            if (_isDebrisOn) {
                _material.SetColor("_MetTint", _meteorsTint);
                _material.SetFloat("_MetBrightness", _meteorsBrightness);
                _material.SetFloat("_MetSpeed", _meteorsSpeed);
            }
        }
    }
}