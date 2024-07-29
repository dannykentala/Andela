using Andela.Domain.DTOs;
using Andela.Domain.Entities;

namespace Andela.Domain.Intefaces.Services
{
  public interface IExcelService
  {
    List<ExcelDTO> ConvertExcelToDbObject();
    // File ParseDbToExcel();
  }
}
