using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
public class Enrolled
{
    [Key]public int Cid { get; set; }
    public int Sid { get; set; }
}
