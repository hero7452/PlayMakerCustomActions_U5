// (c) Copyright HutongGames, LLC 2010-2016. All rights reserved.
/*--- __ECO__ __PLAYMAKER__ __ACTION__ ---*/

using UnityEngine.VR;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("VR")]
	[Tooltip("Center tracking on the current pose.")]
	public class InputTrackingRecenter : FsmStateAction
	{

		public override void OnEnter()
		{
			InputTracking.Recenter();
			Finish();		
		}

	}
}