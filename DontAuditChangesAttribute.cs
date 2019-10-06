using System;

namespace Penguin.Cms.Auditing.Abstractions
{
    /// <summary>
    /// Informs the auditing system not to track changes on a property or class
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple =false, Inherited = true)]
    public class DontAuditChangesAttribute : Attribute
    {
    }
}
