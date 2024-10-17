// Assets/Scripts/Imprimante3D/SwitchBehaviour.cs
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SwitchBehaviour : MonoBehaviour
{
	public bool isOn  = false;

	public void ToggleSwitch()
	{
		// Nous allons restreindre le fait de pouvoir éteindre l'imprimante.
		if (!isOn)
		{
			isOn = true;
			transform.Rotate(new Vector3(0f, -50f, 0f));
		}
	}
}