using System.ComponentModel.DataAnnotations;

namespace Veterinarios.Models
{
    /// <summary>
    /// describes the owner'ss data
    /// </summary>
    public class Owner
    {
        public Owner()
        {
            Animals = new HashSet<Animal>();
        }

        /// <summary>
        /// PK for owners table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// name of owner
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [StringLength(20, ErrorMessage = "O {0} só pode utilizar até 20 caracteres")]
        //[RegularExpression("[A-Z][a-záéíóúàèìòùãõâêîôûäëïöüñç]+( [A-Z][a-záéíóúàèìòùãõâêîôûäëïöüñç]+)*", ErrorMessage = "Por favor, coloque o seu {0} de forma correcta.")]
        [RegularExpression("[A-ZÂÓÍa-záéíóúàèìòùãõâêîôûäëïöüñç '-]+", ErrorMessage = "")]
        // 
        [Display(Name="Nome")]
        public string Name { get; set; }

        /// <summary>
        /// fiscal number owner
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [StringLength(9, MinimumLength =9, ErrorMessage = "O {0} tem de ter 9 caracteres")]
        [RegularExpression("[123578][0-9]{8}", ErrorMessage = "O {0} deve começar por 1,2,3,5,7,8 seguido por 8 dígitos numéricos")]
        public string NIF { get; set; }

        /// <summary>
        /// owner's sex
        /// Ff-female; Mm-male;
        /// </summary>
        [StringLength(1, ErrorMessage = "O {0} não pode ter mais do que 1 caracter")]
        [Display(Name = "Sexo")]
        [RegularExpression("[MmFf]",ErrorMessage = "Só pode usar F ou M no campo {0}")]
        public string Sex { get; set; }
        

        /// <summary>
        /// set of owner's animals
        /// </summary>
        public ICollection<Animal> Animals { get; set; }
    }
}
