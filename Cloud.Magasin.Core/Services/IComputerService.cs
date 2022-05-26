using Cloud.Magasin.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cloud.Magasin.Core.Services
{
    public interface IComputerService
    {
        List<Computer> GetComputers();
        Computer GetComputer(string id);
        Computer AddComputer(Computer computer);

        void DeleteComputer(string id);
        Computer UpdateComputer(Computer computer);
    }
}
