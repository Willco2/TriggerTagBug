using Sandbox;

public sealed class TriggerDebug : Component, Component.ITriggerListener
{

	public void OnTriggerEnter( Collider other )
	{
		Log.Info( $"{GameObject.Name} triggered!" );
	}

	public void OnTriggerExit( Collider other )
	{

	}

}
