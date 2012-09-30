using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO = eGo.MLGT.DTO;
using DAL = eGo.MLGT.DAL;

namespace eGo.MLGT.Bl
{
    public interface ITemplateManager
    {

        /// <summary>
        /// Retrieve all templates
        /// </summary>
        /// <returns>list of template DTOs</returns>
        List<DTO.Template> GetTemplates();

        /// <summary>
        /// Retrieve template by id
        /// </summary>
        /// <param name="templateId">guid of required template</param>
        /// <returns></returns>
        DTO.Template GetTemplate(Guid templateId);

        /// <summary>
        /// Create template
        /// </summary>
        /// <param name="template">template DTO</param>
        /// <returns>true if success and false if failure</returns>
        bool CreateTemplate(DTO.Template template);

        /// <summary>
        /// Update template
        /// </summary>
        /// <param name="template">template DTO</param>
        /// <returns>true if success and false if failure</returns>
        bool UpdateTemplate(DTO.Template template);

        /// <summary>
        /// Delete template by id
        /// </summary>
        /// <param name="templateId">guid of the template</param>
        /// <returns>true if success and false if failure</returns>
        bool DeleteTemplate(Guid templateId);

    }
}
