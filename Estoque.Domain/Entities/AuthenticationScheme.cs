using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entities
{
    public class AuthenticationScheme
    {
        private object value;

        public AuthenticationScheme(string name, string displayName, Type handlerType)
        {
            Name = name;
            DisplayName = displayName;
            HandlerType = handlerType;
        }

        public string Name { get; }

        public string DisplayName { get; }

        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
        public Type HandlerType { get; }
    }
}
