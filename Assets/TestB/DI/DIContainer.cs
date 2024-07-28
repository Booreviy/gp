using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestB.DI
{
	public class DIContainer
	{
		private readonly DIContainer _parentContainer;

		public DIContainer()
		{
			_parentContainer = null;
		}

		public DIContainer(DIContainer parentContainer)
		{
			_parentContainer = parentContainer;
		}
	}
}

