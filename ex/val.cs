using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex
{
    internal class val
    {
        public void validar(List<StudyParticipantDto> dados)
        {
 
            //2
            for (int i = 0; i < dados.Count; i++) 
            {
                if (dados[i].ParticipantName.Length <= 200)
                {
                    Console.WriteLine("Definido!");
                }
                else
                {
                    Console.WriteLine("Tipo indefinido!");
                }

            }

            //3
            for (int i = 0; i < dados.Count; i++)
            {
                if(Enum.IsDefined(typeof(GenderType), dados[i].GenderType))
                {
                    Console.WriteLine("Definido!");
                }
                else
                {
                    Console.WriteLine("Tipo indefinido!");
                }

            }

            //4
            for(int i = 0; i<dados.Count; i++) 
            {
                try
                {
                    string val = dados[i].BirthDate.ToString("dd MM yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR" + ex.Message);
                }
            }

            //6
            for (int i = 0; i < dados.Count; i++)
            {
                if (Enum.IsDefined(typeof(MaritalStatus), dados[i].MaritalStatus))
                {
                    Console.WriteLine("Definido!");
                }
                else
                {
                    Console.WriteLine("Tipo indefinido!");
                }

            }

            //11
            for (int i = 0; i < dados.Count; i++)
            {
                if (Enum.IsDefined(typeof(PlanType), dados[i].PlanType))
                {
                    Console.WriteLine("Definido!");
                }
                else
                {
                    Console.WriteLine("Tipo indefinido!");
                }

            }

            //12
            for (int i = 0; i < dados.Count; i++)
            {
                if (Enum.IsDefined(typeof(TaxOption), dados[i].TaxOption))
                {
                    Console.WriteLine("Definido!");
                }
                else
                {
                    Console.WriteLine("Tipo indefinido!");
                }

            }


        }

    }
}