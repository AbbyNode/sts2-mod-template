using Godot;

namespace BaseLib.Patches.UI;

/// <summary>
/// When a model (card, relic, potion?) is attached to its NCard/NRelic etc, it can provide a Control which will be added as a child of the node.
/// This child will automatically be removed when the model is unbound from the node.
/// </summary>
public interface ICustomUiModel
{
	/// <summary>
	/// Set up a control that will be added as a child. This control should not actively track information, only display it.
	/// Keep any information in the model, as the control will be recreated whenever the model is reloaded.
	/// </summary>
	/// <param name="toAdd">The control that will be added as a child. Add what you want to add as a child of this control.</param>
	/// <returns></returns>
	void CreateCustomUi(Control toAdd);
}
