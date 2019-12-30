using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace ex
{   
    public class StudyParticipantDto
    {
        [Required]
        public int StudyParticipantId { get; set; } //1

        [Required]
        [MaxLength(200)]
        public string ParticipantName { get; set; } //2

        public GenderType GenderType { get; set; } //3
        public DateTime BirthDate { get; set; } //4

        [Required]
        public string Mail { get; set; } //5

        [Required]
        public MaritalStatus MaritalStatus { get; set; } //6

        public int Empresa { get; set; } //7
        public int CodEstudo { get; set; } //8
        public long Cpf { get; set; } //9
        public int SalaryPercent { get; set; } //10
        public PlanType PlanType { get; set; } //11
        public TaxOption TaxOption { get; set; } //12
    }

}
  
