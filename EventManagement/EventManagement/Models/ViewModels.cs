using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EventManagement.Models;
public class LoginViewModel
{
    public string Email{get;set;}
    public string Password{get;set;}

}

public class SigUpViewModel
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Password {get; set; }
    [Required]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword {get; set; }
    [Required]
    public string Surname{get;set;}
    [Required]
    public string Email { get; set;}
    [Required]
    public string PhoneNumber{get; set;}
    [Required]
    public string RoleId {get;set;}

    //Address Fields
    [Required]
    public string StreetAddress { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Province {get;set;}
    [Required]
    public string ZipCode { get; set; }
    [Required]
    public string Country { get; set; }


    public List<SelectListItem> AccountTypes{get;set;} = new List<SelectListItem>();
}