using System;
using System.IO;

namespace Countries
{
    internal class Fail
    {

		readonly string _msgError;

		public Fail()
		{
			_msgError = "¡Error!";
		}

		public void FailMessage()
		{
			throw new Exception(_msgError);
		}

	}
}
