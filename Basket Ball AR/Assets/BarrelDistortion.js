
#pragma strict

@script ExecuteInEditMode
@script RequireComponent (Camera)
@script AddComponentMenu ("Image Effects/Displacement/Barrel Distortion")

class BarrelDistortion extends PostEffectsBase {
	public var Auto: boolean = false; // Sets the FOV_Radians automatically
	public var FOV_Radians: float = 1.69f; // Camera's FOV in radians

	public  var BarrelDistortionShader : Shader = null;
	private var BarrelDistortionMaterial : Material = null;	
	
	function CheckResources () : boolean {	
		CheckSupport (false);
		BarrelDistortionMaterial = CheckShaderAndCreateMaterial(BarrelDistortionShader,BarrelDistortionMaterial);
		
		if(!isSupported)
			ReportAutoDisable ();
		return isSupported;			
	}
	
	function OnRenderImage (source : RenderTexture, destination : RenderTexture) {		
		if(CheckResources()==false) {
			Graphics.Blit (source, destination);
			return;
		}
		
//		if(Auto)
//			FOV_Radians = camera.fieldOfView * Mathf.Deg2Rad;
		
		BarrelDistortionMaterial.SetFloat ("_FOV", FOV_Radians);
		
		Graphics.Blit (source, destination, BarrelDistortionMaterial); 	
	}
}