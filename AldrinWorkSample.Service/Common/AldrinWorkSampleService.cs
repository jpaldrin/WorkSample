using AldrinWorkSample.Model.Models;
using AldrinWorkSample.Repository.Common;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AldrinWorkSample.Service.Common
{
    public partial class AldrinWorkSampleService 
    {
        private IAldrinWorkSampleUnitOfWork _unitOfWork;

        public AldrinWorkSampleService()
        {

        }

        public AldrinWorkSampleService(IAldrinWorkSampleUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}
