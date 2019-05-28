using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace AulaCore.Models
{
    [Table("Cidades")]
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="ID: ")]
        public int id { get; set; }

        [StringLength(35)]
        [Display(Name ="Nome da Cidade: ")]
        [Required(ErrorMessage = "Campo Nome da Cidade é obrigatorio...")]
        public string nome { get; set; }

        [StringLength(2)]
        [Required(ErrorMessage = "Campo UF da Cidade é obrigatorio...")]
        [Display(Name ="Estado: ")]
        public string uf { get; set; }

        [Display(Name ="Quantidade de Clientes")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true,
                        NullDisplayText = "Campo quantidade não pode ser nulo")]
        public int qtdeCli { get; set; }

        //public int teste { get; set; }

    }
}
