using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCloud.Database;
using GameCloud.Database.Adapters;
using GameCloud.UCenter.Database.Entities;

namespace GameCloud.UCenter.Database
{
    [Export]
    public class UCenterEventDatabaseContext : DatabaseContext
    {
        [ImportingConstructor]
        public UCenterEventDatabaseContext(ExportProvider exportProvider, UCenterEventDatabaseContextSettings settings)
            : base(exportProvider, settings)
        {
        }

        /// <summary>
        /// Gets the account event database adapter.
        /// </summary>
        public ICollectionAdapter<AccountEventEntity> AccountEvents
        {
            get
            {
                return this.GetAdapter<AccountEventEntity>();
            }
        }

        /// <summary>
        /// Gets the error event database adapter.
        /// </summary>
        public ICollectionAdapter<ErrorEventEntity> ErrorEvents
        {
            get
            {
                return this.GetAdapter<ErrorEventEntity>();
            }
        }
    }
}
