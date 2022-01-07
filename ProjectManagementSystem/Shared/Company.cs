using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Shared
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Founded { get; set; }

        //Navigation Properties
        public List<Board> Boards { get; set; }

        public Company()
        {
        }

        public Company(string name, DateTime founded)
        {
            Name = name;
            Founded = founded;
            Boards = new List<Board>();
        }
    }
}
