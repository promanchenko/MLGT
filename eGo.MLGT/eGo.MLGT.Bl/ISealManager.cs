using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO = eGo.MLGT.DTO;
using DAL = eGo.MLGT.DAL;

namespace eGo.MLGT.Bl
{
    public interface ISealManager
    {
        /// <summary>
        /// Retrieve all seals
        /// </summary>
        /// <returns>List of seal DTOs</returns>
        List<DTO.Seal> GetSeals();

        /// <summary>
        /// Retrieve seal by id
        /// </summary>
        /// <param name="sealId">guid of required seal</param>
        /// <returns>seal DTO</returns>
        DTO.Seal GetSeal(Guid sealId);

        /// <summary>
        /// Create seal
        /// </summary>
        /// <param name="seal">seal DTO</param>
        /// <returns>true if success and false if failure</returns>
        bool CreateSeal(DTO.Seal seal);

        /// <summary>
        /// Update seal
        /// </summary>
        /// <param name="seal">seal DTO</param>
        /// <returns>true if success and false if failure</returns>
        bool UpdateSeal(DTO.Seal seal);

        /// <summary>
        /// Delete seal by id
        /// </summary>
        /// <param name="sealId">guid of the seal</param>
        /// <returns>true if success and false if failure</returns>
        bool DeleteSeal(Guid sealId);
    }
}
