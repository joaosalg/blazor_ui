using System.Reflection;

namespace Blazor_ui.Util
{
	public static class PropertyUtil
	{
		public static List<string> getColumns(this Type value)
		{
			return value.GetProperties().Select(x => x.Name).ToList();
		}

		public static List<PropertyInfo> getProperties(this Type value)
		{
			return value.GetProperties().ToList();
		}

	}
}
