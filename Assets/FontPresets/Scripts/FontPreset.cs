using TMPro;
using UnityEngine;

/// @brief A collection of TextMeshPro options in a single object.
[CreateAssetMenu(fileName = "New Font Preset", menuName = "ScriptableObjects/Font Preset", order = 1)]
public class FontPreset : ScriptableObject
{
    /// @brief The font asset.
    public TMP_FontAsset font;

    /// @brief The text style to apply.
    public FontStyles style = FontStyles.Normal;

    /// @brief The font size.
    public float size = 12f;

    /// @brief The space between letters.
    public float letterSpacing = 0f;

    /// @brief The space between words.
    public float wordSpacing = 0f;

    /// @brief The space between lines.
    public float lineSpacing = 0f;

    /// @brief The space between paragraphs.
    public float paragraphSpacing = 0f;
}
