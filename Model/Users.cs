using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ToDoList.Model
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("Cod")]
        [Key]public int COD { get; set; }

        [JsonPropertyName("firstName")]
        public string FIRST_NAME { get; set; }

        [JsonPropertyName("middleName")]
        public string MIDDLE_NAME { get; set; }

        [JsonPropertyName("lastName")]
        public string LAST_NAME { get; set; }

        [JsonPropertyName("secondSurname")]
        public string SECOND_SURNAME { get; set; }

        [JsonPropertyName("dateBirth")]
        public DateOnly DATE_BIRTH { get; set; }

        [JsonPropertyName("email")]
        public string EMAIL { get; set; }

        [JsonPropertyName("phone")]
        public string PHONE { get; set; }

        [JsonPropertyName("userName")]
        public string USERNAME { get; set; }

        [JsonPropertyName("password")]
        public string PASSWORD { get; set; }

        [JsonPropertyName("nationality")]
        public string NATIONALITY { get; set; }
    }
}
