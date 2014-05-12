using System.Collections.Generic;
using System.IO;
using System.Linq;
using SchemaManager.Core;

namespace SchemaManager.AlwaysRun
{
	public class FileSystemAlwaysRunScriptsProvider : IProvideAlwaysRunScripts
	{
		private readonly string _pathToScripts;
	    private readonly SchemaManagerGlobalOptions _options;

		public FileSystemAlwaysRunScriptsProvider(string pathToScripts, SchemaManagerGlobalOptions options)
		{
			_pathToScripts = pathToScripts;
		    _options = options;
		}

		public IEnumerable<ISimpleScript> GetScripts()
		{
			return Directory.EnumerateFiles(_pathToScripts).Select(script => new SimpleScript(File.ReadAllText(script), _options));
		}
	}
}