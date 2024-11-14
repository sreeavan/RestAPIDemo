
using System.ComponentModel.DataAnnotations.Schema;

namespace UserApi.Models;

[Table("User")]

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }

    public string ContactPhone { get; set; }

    public int DesignationId { get; set; }
    public int DepartmentId { get; set; }
}