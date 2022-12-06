using System;
namespace CSharpShop3.Eccezioni {
	public class AcquaFinitaException : Exception {
		public AcquaFinitaException(string message) : base(message) {
			Console.WriteLine(message);
		}
	}
}

