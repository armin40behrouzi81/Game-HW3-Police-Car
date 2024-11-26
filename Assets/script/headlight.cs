using UnityEngine;

public class LightToggle : MonoBehaviour
{
    public Light targetLight; // Drag the light object here in the Inspector
    public Light targetLight2; // Drag the light object here in the Inspector

    void Update()
    {
        // Example: Press "L" to toggle the light
        if (Input.GetKeyDown(KeyCode.L))
        {
            targetLight.enabled = !targetLight.enabled;
            targetLight2.enabled = !targetLight2.enabled;
        }
    }

    public void ToggleLight() // Attach this method to a button, if needed
    {
        targetLight.enabled = !targetLight.enabled;
    }
}
