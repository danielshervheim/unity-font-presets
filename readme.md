# Unity Font Presets

This is a tool for Unity that allows you to define font presets and apply them to text components. When the preset is changed, any `TextMeshProUGUI` component that uses that preset will reflect the changes immediately. This is useful for keeping consistent text styles throughout a project.

## To Use

Create a new FontPreset object somewhere in your assets folder.
- Right click in the Asset browser.
- Select `Create/ScriptableObjects/New FontPreset`.
- Adjust the settings of the newly created font preset, and name it something descriptive.

Assign the FontPreset to a text component in the scene.
- Select the GameObject with the TextMeshProUGUI you want to apply the FontPreset to.
- Add an `ApplyFontPreset` component to the GameObject.
- Assign your newly created FontPreset to the ApplyFontPreset component.
