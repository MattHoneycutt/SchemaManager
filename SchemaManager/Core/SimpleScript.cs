using Utilities.Data;

namespace SchemaManager.Core
{
	public class SimpleScript : ScriptBase, ISimpleScript
	{
		private readonly string _script;

		public SimpleScript(string script, SchemaManagerGlobalOptions options)
		{
			_script = script;
		    Options = options;
		}

		public void Execute(IDbContext context)
		{
			RunAllBatchesFromText(context, _script);
		}

	    protected override sealed SchemaManagerGlobalOptions Options { get; set; }
	}
}