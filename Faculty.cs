﻿using System.ComponentModel.DataAnnotations;
public class Faculty
{
    [Key]public int Fid { get; set; }
    public string FacultyName { get; set; }
    public string Department { get; set; }
}
