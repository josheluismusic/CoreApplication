using CoreApplication.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApplication.Infrastructure.Behaviors
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    [MetadataAttribute]
    public sealed class ModuleMenuExportAttribute : ExportAttribute, IModuleMenuExportMetadata
    {
        public ModuleMenuExportAttribute(ShellType shell)
            : this(shell, typeof(IModuleMenuProvider))
        { }

        public ModuleMenuExportAttribute(ShellType shell, Type contractType)
            : base(contractType)
        {
            this.Shell = shell;
        }

        public ShellType Shell { get; set; }
    }
}
