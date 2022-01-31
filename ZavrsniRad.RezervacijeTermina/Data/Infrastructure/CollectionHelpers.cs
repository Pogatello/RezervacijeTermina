using System.Collections.Generic;
using System.Linq;

namespace ZavrsniRad.RezervacijeTermina.Data.Infrastructure
{
	public static class CollectionHelpers
	{
		public static bool HasElements<T>(this IEnumerable<T> enumerable)
		{
			return enumerable != null && enumerable.Any();
		}
	}
}