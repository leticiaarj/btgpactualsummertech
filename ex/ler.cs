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
           /* string filename = "D:/Simples.xlsx";
            TextReader leitor = new StreamReader(filename, true);
            int lines = 0;
            while(leitor.Peek() != -1) 
            {
                lines++;
                leitor.ReadLine();
            }
            leitor.Close();
            Console.WriteLine("LINHAS: ", lines);*/

            var list = new List<StudyParticipantDto>();
            //var fileStream = new FileStream("D:/teste.csv", FileMode.Open, FileAccess.Read);
            
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
                        if (int.TryParse(worksheet.Cells[row, 1].Value.ToString(), out int id))
                        {
                            linha.StudyParticipantId = (int)id;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }

                        //2
                        linha.ParticipantName = worksheet.Cells[row, 2].Value.ToString().Trim();

                        //3
                        if (int.TryParse(worksheet.Cells[row, 3].Value.ToString(), out int gender))
                        {
                            linha.GenderType = (GenderType)gender;
                        }
                        else
                        {
                            Console.WriteLine("Impossível ler");
                        }
                    
                        //4
                        if(DateTime.TryParse(worksheet.Cells[row, 4].Value.ToString(), out DateTime data)) 
                        {
                            linha.BirthDate = data;
                        }
                        else 
                        {
                            Console.WriteLine("DATA EM FORMATO INVÁLIDO!");
                        }

                        //5
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
                        linha.Empresa = int.Parse(worksheet.Cells[row, 7].Value.ToString());

                        //8
                        linha.CodEstudo = int.Parse(worksheet.Cells[row, 8].Value.ToString());

                        //9
                        linha.Cpf = long.Parse(worksheet.Cells[row, 9].Value.ToString());

                        //10
                        linha.SalaryPercent = int.Parse(worksheet.Cells[row, 10].Value.ToString());

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