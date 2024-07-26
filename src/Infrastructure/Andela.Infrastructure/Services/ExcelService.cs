using Andela.Domain.Intefaces.Services;
using OfficeOpenXml;

namespace SchoolApi.Services.StudentsRepository
{
  public class ExcelService: IExcelService
  {
    // private readonly string _assetsDir = "../../../";
    private string _excelDir = $"../../../assets/data/excel/basesita.xlsx";
    private ExcelWorksheet _excelSheet;


    public ExcelService()
    {
      ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
    }

    public void UploadExcelToDb()
    {
      using(ExcelPackage excelPackage = new ExcelPackage(_excelDir))
      {
        _excelSheet = excelPackage.Workbook.Worksheets[0];

        int lastRow = _excelSheet.Dimension.End.Row;

        for(int i = FirstRow(); i < lastRow; i++)
        {
          var rowData = GetRowInfo(i);
        }

        excelPackage.Save();
      }
    }

    private int EndColunm()
    {
      return _excelSheet.Dimension.End.Column;
    }

    private int FirstRow()
    {
      /*
        | ID | Name |
        | 1  | Jose |

        we have to begin in the next row
      */
      return HeaderRow() + 1;
    }

    private List<string> GetRowInfo(int rowNumber)
    {
      List<string> rowValues = new();

      int firstColum = _excelSheet.Dimension.Start.Column;

      for(int i = firstColum; i < EndColunm(); i++)
      {
        string cell = _excelSheet.Cells[rowNumber,i].Value.ToString();
        rowValues.Add(cell);
      }

      return rowValues;
    }

    private int HeaderRow()
    {
      return _excelSheet.Dimension.Start.Row;
    }
  }
}