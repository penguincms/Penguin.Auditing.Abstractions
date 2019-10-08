using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Auditing.Abstractions.Attributes
{

    /// <summary>
    /// Informs an entity auditor not to track the property or class
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DontAuditChangesAttribute : Attribute
    {
    }
}