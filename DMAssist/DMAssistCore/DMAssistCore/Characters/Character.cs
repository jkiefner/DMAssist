namespace DMAssistCore
{
	public abstract class Character
	{
		private string _typeName;
		public virtual string TypeName
		{
			get
			{
				return GetType().Name;
			}
			set
			{
				_typeName = value;
			}
		}
		public abstract void Attack();		
	}
}
