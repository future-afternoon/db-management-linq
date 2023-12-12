using System.ComponentModel.DataAnnotations;
public class Class
{
    [Key]public int Cid { get; set; }
    public string ClassName { get; set; }
    public string RoomNumber { get; set; }
    public int Fid { get; set; }
}