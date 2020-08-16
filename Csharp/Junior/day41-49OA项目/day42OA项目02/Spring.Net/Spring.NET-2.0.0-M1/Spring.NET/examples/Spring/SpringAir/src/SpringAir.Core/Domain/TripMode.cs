#region Licence

/*
 * Copyright � 2002-2005 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

#region Imports

using System;

#endregion

namespace SpringAir.Domain
{
	/// <summary>
	/// ...
	/// </summary>
	/// <author>Keith Donald</author>
	/// <author>Rick Evans (.NET)</author>
	/// <version>$Id: TripMode.cs,v 1.2 2005/10/05 05:06:49 aseovic Exp $</version>
    [Serializable]
    public enum TripMode 
    {
		OneWay,
		RoundTrip
	}
}
