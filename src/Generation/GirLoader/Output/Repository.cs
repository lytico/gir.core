﻿using System;
using System.Collections.Generic;
using System.Linq;
using GirLoader.Helper;

namespace GirLoader.Output
{
    public class Repository : Node<Repository>
    {
        private Namespace? _namespace;
        public Namespace Namespace => _namespace ?? throw new Exception("Namespace not initialized.");
        public IEnumerable<Include> Includes { get; }
        public IEnumerable<Repository> Dependencies => Includes.Select(x => x.GetResolvedRepository());

        public Repository(IEnumerable<Include> includes)
        {
            Includes = includes;
        }

        internal void SetNamespace(Namespace @namespace)
        {
            this._namespace = @namespace;
        }

        public override string ToString()
        {
            return $"{nameof(Repository)} for {Namespace.Name}";
        }
    }
}