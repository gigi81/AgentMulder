﻿using System.Collections.Generic;
using AgentMulder.ReSharper.Domain.Registrations;
using JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch;
using JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders;
using JetBrains.ReSharper.Psi.Services.StructuralSearch;

namespace AgentMulder.Containers.Ninject.Patterns.Module.Bind
{
    internal sealed class BindGeneric : BindBasePattern
    {
        private static readonly IStructuralSearchPattern pattern
            = new CSharpStructuralSearchPattern("Bind<$service$>()",
                new TypePlaceholder("service"));

        public BindGeneric(IEnumerable<ComponentImplementationBasePattern> toPatterns)
            : base(pattern, "service", toPatterns)
        {
        }
    }
}