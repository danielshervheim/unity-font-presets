using TextMesh = TMPro.TextMeshProUGUI;
using UnityEngine;

/// @brief Applies a FontPreset to the attached TextMeshPro component.
///
/// This is useful to keep text consistent throughout the project as a change
/// to the FontPreset will be reflected everywhere it is used.
[ExecuteInEditMode]
[RequireComponent(typeof(TextMesh))]
public class ApplyFontPreset : MonoBehaviour
{
    // The TextMeshPro component to apply this FontPreset to.
    private TextMesh _text;

    /// @brief The FontPreset to apply.
    public FontPreset fontPreset;

    /// @brief Wether to allow a color override or not.
    public bool allowColorOverride = false;

    /// @brief Whether or not to destroy this component once the game starts.
    /// You should enable this if you don't plan on modifying the FontPreset at runtime.
    public bool destroyInGame = true;

    /// @brief Applies the given FontPreset to the given TextMeshProUGUI component.
    public static void Apply(FontPreset fontPreset, TextMesh textMesh, bool allowColorOverride = false)
    {
        if (textMesh.font != fontPreset.font)
        {
            textMesh.font = fontPreset.font;
        }

        if (textMesh.fontSize != fontPreset.size)
        {
            textMesh.fontSize = fontPreset.size;
        }

        if (textMesh.fontStyle != fontPreset.style)
        {
            textMesh.fontStyle = fontPreset.style;
        }

        if (textMesh.characterSpacing != fontPreset.letterSpacing)
        {
            textMesh.characterSpacing = fontPreset.letterSpacing;
        }

        if (textMesh.lineSpacing != fontPreset.lineSpacing)
        {
            textMesh.lineSpacing = fontPreset.lineSpacing;
        }

        if (textMesh.wordSpacing != fontPreset.wordSpacing)
        {
            textMesh.wordSpacing = fontPreset.wordSpacing;
        }

        if (textMesh.paragraphSpacing != fontPreset.paragraphSpacing)
        {
            textMesh.paragraphSpacing = fontPreset.paragraphSpacing;
        }

        if (textMesh.color != fontPreset.color && !allowColorOverride)
        {
            textMesh.color = fontPreset.color;
        }
    }

    // Applies the font preset every frame.
    private void Update()
    {
        if (!fontPreset)
        {
            return;
        }

        // Verify that the TextMeshPro component is set.
        if (!_text)
        {
            _text = GetComponent<TextMesh>();
        }

        Apply(fontPreset, _text, allowColorOverride);

        // Destroy this component after setting, if enabled.
        if (Application.isPlaying && destroyInGame)
        {
            Destroy(this);
        }
    }
}
