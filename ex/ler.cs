using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ex
{
    public class ler
    {

        public List<StudyParticipantDto> test()
        {
            var list = new List<StudyParticipantDto>();
            
            byte[] bin = File.ReadAllBytes("D:/simples.xlsx");

            using (var reader = new MemoryStream(bin))
            {
                using (var package = new ExcelPackage(reader))
                {

                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.End.Row;

                    for (int row = 1; row <= rowCount; row++)
                    { 
                        var linha = new StudyParticipantDto();

                        // 1
                        if (int.TryParse(worksheet.Cells[row, 1].Value?.ToString(), out int id))
                        {
                            linha.StudyParticipantId = (int)id;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }

                        //2
                        if (!string.IsNullOrEmpty(worksheet.Cells[row, 2].Value?.ToString()?.Trim()))
                        {
                            linha.ParticipantName = worksheet.Cells[row, 2].Value?.ToString().Trim();
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }
                        linha.Mail = worksheet.Cells[row, 5].Value.ToString().Trim();


                        //3
                        if (int.TryParse(worksheet.Cells[row, 3].Value?.ToString(), out int gender))
                        {
                            linha.GenderType = (GenderType)gender;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }
                    
                        //4
                        if(DateTime.TryParseExact(worksheet.Cells[row, 4].Value?.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data)) 
                        {
                            linha.BirthDate = data;
                        }
                        else 
                        {
                            Console.WriteLine("DATA EM FORMATO INVÁLIDO!");
                        }

                        //5
                        if(!string.IsNullOrEmpty(worksheet.Cells[row, 5].Value?.ToString()?.Trim())) 
                        {
                            linha.Mail = worksheet.Cells[row, 5].Value?.ToString().Trim();
                        }
                        else 
                        {
                            Console.WriteLine("Impossível ler");
                        }
                        linha.Mail = worksheet.Cells[row, 5].Value.ToString().Trim();

                        //6
                        if (int.TryParse(worksheet.Cells[row, 6].Value.ToString(), out int marital))
                        {
                            linha.MaritalStatus = (MaritalStatus)marital;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }

                        //7
                        if (int.TryParse(worksheet.Cells[row, 7].Value?.ToString(), out int empr))
                        {
                            linha.Empresa = (int)empr;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }

                        //8
                        if (int.TryParse(worksheet.Cells[row, 8].Value?.ToString(), out int cod))
                        {
                            linha.CodEstudo = (int)cod;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }

                        //9
                        if (int.TryParse(worksheet.Cells[row, 9].Value?.ToString(), out int cppf))
                        {
                            linha.Cpf = (int)cppf;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }

                        //10
                        if (int.TryParse(worksheet.Cells[row, 10].Value?.ToString(), out int sal))
                        {
                            linha.SalaryPercent = (int)sal;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }

                        //11
                        if (int.TryParse(worksheet.Cells[row, 11].Value.ToString(), out int plan))
                        {
                            linha.PlanType = (PlanType)plan;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }

                        //12
                        if (int.TryParse(worksheet.Cells[row, 12].Value.ToString(), out int tx))
                        {
                            linha.TaxOption = (TaxOption)tx;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }


                        list.Add(linha);
                    }

                }
            }
                      
            return list;

        }
    }
}