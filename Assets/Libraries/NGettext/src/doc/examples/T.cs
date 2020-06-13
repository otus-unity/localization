using UnityEngine;
using System;
using System.IO;
using System.Globalization;
using NGettext;
using ngettext_unity;

//
// Usage:
//		T._("Hello, World!"); // GetString
//		T._n("You have {0} apple.", "You have {0} apples.", count, count); // GetPluralString
//		T._p("Context", "Hello, World!"); // GetParticularString
//		T._pn("Context", "You have {0} apple.", "You have {0} apples.", count, count); // GetParticularPluralString
//
namespace Example
{
	internal class T
	{
		private static ICatalog _Catalog;

		public static string _(string text)
		{
			return _Catalog.GetString(text);
		}

		public static string _(string text, params object[] args)
		{
			return _Catalog.GetString(text, args);
		}

		public static string _n(string text, string pluralText, long n)
		{
			return _Catalog.GetPluralString(text, pluralText, n);
		}

		public static string _n(string text, string pluralText, long n, params object[] args)
		{
			return _Catalog.GetPluralString(text, pluralText, n, args);
		}

		public static string _p(string context, string text)
		{
			return _Catalog.GetParticularString(context, text);
		}

		public static string _p(string context, string text, params object[] args)
		{
			return _Catalog.GetParticularString(context, text, args);
		}

		public static string _pn(string context, string text, string pluralText, long n)
		{
			return _Catalog.GetParticularPluralString(context, text, pluralText, n);
		}

		public static string _pn(string context, string text, string pluralText, long n, params object[] args)
		{
			return _Catalog.GetParticularPluralString(context, text, pluralText, n, args);
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		static void Init()
		{
			NGettextUnity.Instance.LoadLocale("ru-RU");
			_Catalog = NGettextUnity.Catalog;
		}

		#if UNITY_EDITOR
		[UnityEditor.MenuItem("Tools/Update MO files")]
		static void RenameFiles()
		{
			string srcName = $"{Application.dataPath}/Resources/Locale/ru-RU/LC_MESSAGES/messages.mo";
			string dstName = $"{Application.dataPath}/Resources/Locale/ru-RU/LC_MESSAGES/messages_mo.bytes";
			if (File.Exists(srcName)) {
				File.Delete(dstName);
                File.Delete($"{srcName}.meta");
				File.Move(srcName, dstName);
			}
            UnityEditor.AssetDatabase.Refresh();
		}
		#endif
	}
}
