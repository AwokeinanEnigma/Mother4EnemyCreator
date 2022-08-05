using System;

namespace M4EC.Exceptions
{
	// Token: 0x0200000F RID: 15
	public class DuplicateNameException : Exception
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000819B File Offset: 0x0000639B
		public override string Message
		{
			get
			{
				return this.message;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000081A3 File Offset: 0x000063A3
		public DuplicateNameException()
		{
			this.message = "Multiple sprite definitions cannot have the same name.";
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000081B6 File Offset: 0x000063B6
		public DuplicateNameException(string message) : base(message)
		{
			this.message = message;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000081C6 File Offset: 0x000063C6
		public DuplicateNameException(string message, Exception inner) : base(message, inner)
		{
			this.message = message;
		}

		// Token: 0x04000084 RID: 132
		private string message;
	}
}
