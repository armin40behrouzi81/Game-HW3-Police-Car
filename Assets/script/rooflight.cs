using UnityEngine;

public class RoofLight : MonoBehaviour
{
    public Light leftLight;  // Left roof light
    public Light rightLight; // Right roof light
    public float flashSpeed = 0.5f; // Time in seconds for each flash

    private bool isFlashing = false; // Control if the lights are flashing

    void Update()
    {
        // Check for input to toggle lights
        if (Input.GetKeyDown(KeyCode.H)) // Press 'H' to toggle lights
        {
            ToggleLights();
        }
    }

    public void ToggleLights()
    {
        isFlashing = !isFlashing;

        if (isFlashing)
        {
            StartCoroutine(FlashLights());
        }
        else
        {
            StopAllCoroutines();
            leftLight.enabled = false;
            rightLight.enabled = false;
        }
    }

    private System.Collections.IEnumerator FlashLights()
    {
        while (isFlashing)
        {
            leftLight.enabled = true;
            rightLight.enabled = false;
            yield return new WaitForSeconds(flashSpeed);

            leftLight.enabled = false;
            rightLight.enabled = true;
            yield return new WaitForSeconds(flashSpeed);
        }
    }
}
