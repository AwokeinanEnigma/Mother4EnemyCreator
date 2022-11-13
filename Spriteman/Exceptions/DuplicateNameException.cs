using System;

namespace M4EC.Exceptions
{
	public class DuplicateNameException : Exception
	{
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000819B File Offset: 0x0000639B
		public override string Message
		{
			get
			{
				return this.message;
			}
		}
		public DuplicateNameException()
		{
			this.message = "Multiple sprite definitions cannot have the same name.";
		}
		public DuplicateNameException(string message) : base(message)
		{
			this.message = message;
		}
		public DuplicateNameException(string message, Exception inner) : base(message, inner)
		{
			this.message = message;
		}
		private string message;
	}
}
