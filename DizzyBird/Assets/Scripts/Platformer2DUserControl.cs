using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;


        private void Awake()
        {
			m_Character = GetComponent<PlatformerCharacter2D>();
        }

        private void Update()
        {
            if (!m_Jump)
            {
//                // Read the jump input in Update so button presses aren't missed.
//				if(HUDScript.jumpbuttonpressed)
//					m_Jump = true;
            }

        }

		void OnGUI()
		{
			GUI.skin.button.fontSize = 50;
			if (GUI.Button (new Rect (Screen.width - 300, Screen.height - 300, 300, 300), "Jump"))
				m_Jump = true;
		}

        private void FixedUpdate()
        {
            // Read the inputs.
			//No crouch ability, always false. Left code for potential future use
            //bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, false, m_Jump);
            m_Jump = false;
        }
    }
}
