using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class ResolutionManager : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;

    void Start()
    {
        if (resolutionDropdown == null)
        {
            Debug.LogError("ResolutionDropdown is not assigned in the Inspector!");
            return;
        }

        PopulateResolutions();
        resolutionDropdown.onValueChanged.AddListener(OnResolutionChange);
    }


    // Populate the TMP_Dropdown with available resolutions
    void PopulateResolutions()
    {
        resolutionDropdown.ClearOptions();
        var resolutions = Screen.resolutions;

        List<string> resolutionOptions = new List<string>();
        foreach (var resolution in resolutions)
        {
            resolutionOptions.Add(resolution.width + " x " + resolution.height);
        }

        resolutionDropdown.AddOptions(resolutionOptions);

        // Set the current resolution in the dropdown
        int currentResolutionIndex = resolutionOptions.IndexOf(Screen.currentResolution.width + " x " + Screen.currentResolution.height);
        resolutionDropdown.value = currentResolutionIndex;
    }

    // Change the screen resolution when the dropdown value is changed
    void OnResolutionChange(int index)
    {
        var resolutions = Screen.resolutions;
        var selectedResolution = resolutions[index];
        Screen.SetResolution(selectedResolution.width, selectedResolution.height, Screen.fullScreen);
    }
}
