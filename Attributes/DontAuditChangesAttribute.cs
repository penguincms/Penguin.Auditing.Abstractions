using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Auditing.Abstractions.Attributes
{
    /// <summary>
    /// Skips auditing changes on the class or property
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DontAuditChangesAttribute : Attribute
    {
    }
}