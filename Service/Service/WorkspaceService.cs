using Service.Entities;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class WorkspaceService : BaseService<Workspace>
    {
        private readonly IMongoRepository<Workspace> repository;

        public WorkspaceService(IMongoRepository<Workspace> repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
