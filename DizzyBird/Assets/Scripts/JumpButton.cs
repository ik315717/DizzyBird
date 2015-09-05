using System;
using UnityEngine;
using System.Collections;

namespace UnityStandardAssets._2D
{
	public class JumpButton : MonoBehaviour {

		private PlatformerCharacter2D m_Character;

		void Start()
		{
			m_Character = GetComponent<PlatformerCharacter2D>();
		}

		void OnTouchDown()
		{
			m_Character.Move (0, false, true);
		}
	}
}