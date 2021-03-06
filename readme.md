# Unity Font Presets

This is a tool for Unity that allows you to define font presets and apply them to text components. When the preset is changed, any `TextMeshProUGUI` component that uses that preset will reflect the changes immediately. This is useful for keeping consistent text styles throughout a project.

## Installation

**via unity package manager**

1. Add this repositories `upm` branch as a dependancy to your project's `manifest.json`

```json
"com.dss.font-presets": "ssh://git@github.com/danielshervheim/unity-font-presets.git#upm"
```

**manually**

1. Clone this repository
2. Copy the `Assets/DSS/FontPresets` folder into your own project's `Assets` folder.

## To Use

Create a new FontPreset object somewhere in your assets folder.
- Right click in the Asset browser.
- Select `Create/DSS/Font Presets/Font Preset`.
- Adjust the settings of the newly created font preset, and name it something descriptive.

Assign the FontPreset to a text component in the scene.
- Select the GameObject with the TextMeshProUGUI you want to apply the FontPreset to.
- Add an `ApplyFontPreset` component to the GameObject.
- Assign your newly created FontPreset to the ApplyFontPreset component.
