using TMPro;
using UnityEngine;

/// @brief Applies a FontPreset to the attached TextMeshPro component.
///
/// This is useful to keep text consistent throughout the project as a change
/// to the FontPreset will be reflected everywhere it is used.
[ExecuteInEditMode]
[RequireComponent(typeof(TextMeshProUGUI))]
public class ApplyFontPreset : MonoBehaviour
{
    // The TextMeshPro component to apply this FontPreset to.
    private TextMeshProUGUI m_text;

    /// @brief The FontPreset to apply.
    public FontPreset fontPreset;

    /// @brief Whether or not to destroy this component once the game starts.
    ///
    /// You should enable this if you don't plan on modifying the FontPreset at runtime.
    public bool destroyInGame = true;

    /// @brief Applies the given FontPreset to the given TextMeshProUGUI component.
    public static void Apply(FontPreset fontPreset, TextMeshProUGUI textMesh)
    {
        // Set the font.
        if (textMesh.font != fontPreset.font)
        {
            textMesh.font = fontPreset.font;
        }

        // Set the text size.
        if (textMesh.fontSize != fontPreset.size)
        {
            textMesh.fontSize = fontPreset.size;
        }

        // Set the text style.
        if (textMesh.fontStyle != fontPreset.style)
        {
            textMesh.fontStyle = fontPreset.style;
        }

        // Set the character spacing.
        if (textMesh.characterSpacing != fontPreset.letterSpacing)
        {
            textMesh.characterSpacing = fontPreset.letterSpacing;
        }

        // Set the line spacing.
        if (textMesh.lineSpacing != fontPreset.lineSpacing)
        {
            textMesh.lineSpacing = fontPreset.lineSpacing;
        }

        // Set the word spacing.
        if (textMesh.wordSpacing != fontPreset.wordSpacing)
        {
            textMesh.wordSpacing = fontPreset.wordSpacing;
        }

        // Set the paragraph spacing.
        if (textMesh.paragraphSpacing != fontPreset.paragraphSpacing)
        {
            textMesh.paragraphSpacing = fontPreset.paragraphSpacing;
        }
    }

    // Applies the font preset every frame.
    private void Update()
    {
        // Verify that the TextMeshPro component is set.
        if (m_text == null)
        {
            m_text = GetComponent<TextMeshProUGUI>();
        }

        // If no preset is provided, then quit.
        if (fontPreset == null)
        {
            Debug.LogError("No FontPreset provided!");
            return;
        }

        Apply(fontPreset, m_text);

        // Destroy this component after setting, if enabled.
        if (Application.isPlaying && destroyInGame)
        {
            Destroy(this);
        }
    }
}
