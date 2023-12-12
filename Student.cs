using System.ComponentModel.DataAnnotations;
public class Student
{
    [Key]public int Sid { get; set; }
    public string Sname { get; set; }
    public string Major { get; set; }
    public string Standing { get; set; }
}