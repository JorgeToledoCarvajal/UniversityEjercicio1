using System.ComponentModel.DataAnnotations;

namespace UniversityEjercicio1.Models.DataModels
{
    public class Curso: BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;

        [Required, StringLength(500)]
        public string DescripcionLarga{ get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string PublicoObjetivo { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Objetivos{ get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Requisitos { get; set; } = string.Empty;

        public enum Nivel
        {
            Basico,
            Intermedio,
            Avanzado
        }
    }
}
