using UnityEngine;

[ExecuteAlways]
public class DayNightManager : MonoBehaviour
{
    public Gradient AmbientColor;
    [SerializeField] private Light DirectionalLight;
    [SerializeField, Range(0, 24)] private float TimeOfDay;
    [SerializeField] public float slownessMultiplier;

    private void Update()
    {
        if (Application.isPlaying)
        {
            //(Replace with a reference to the game time)
            TimeOfDay += Time.deltaTime * slownessMultiplier;
            TimeOfDay %= 24; //Modulus to ensure always between 0-24
            UpdateLighting(TimeOfDay / 24f);
        }
        else
        {
            UpdateLighting(TimeOfDay / 24f);
        }
    }

    private void UpdateLighting(float timePercent)
    {
        RenderSettings.ambientLight = AmbientColor.Evaluate(timePercent);

        if (DirectionalLight != null)
        {
            DirectionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, 170f, 0));
        }
    }

    private void OnValidate()
    {
        if (DirectionalLight != null)
            return;
    }
}