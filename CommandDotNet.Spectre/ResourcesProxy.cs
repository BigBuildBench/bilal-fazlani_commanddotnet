// this file generated by ResourceGenerators.RegenerateProxyClasses

using System;

namespace CommandDotNet.Spectre
{
    // this class generated by ResourcesDef.GenerateProxyClass
    public class ResourcesProxy : Resources
    {
        private readonly Func<string, string?> _localize;
        private readonly bool _memberNameAsKey;

        public ResourcesProxy(Func<string, string?> localize, bool memberNameAsKey = false)
        {
            _localize = localize ?? throw new ArgumentNullException(nameof(localize));
            _memberNameAsKey = memberNameAsKey;
        }

        private static string? Format(string? value, params object?[] args) =>
            value is null ? null : string.Format(value, args);

        public override string Selection_paging_instructions(string argumentName) =>
            Format(_localize(_memberNameAsKey 
                ? "Selection_paging_instructions"
                : base.Selection_paging_instructions("{0}")),
                argumentName)
            ?? base.Selection_paging_instructions(argumentName);

        public override string MultiSelection_selection_instructions(string argumentName) =>
            Format(_localize(_memberNameAsKey 
                ? "MultiSelection_selection_instructions"
                : base.MultiSelection_selection_instructions("{0}")),
                argumentName)
            ?? base.MultiSelection_selection_instructions(argumentName);

    }
}