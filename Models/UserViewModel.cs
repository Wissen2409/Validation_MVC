using System.ComponentModel.DataAnnotations;

public class UserViewModel
{

    // Required name alanın boş girilmemesini sağlayacaktır
    [MinLength(3, ErrorMessage = "Ad alanı minimum 3 karakterli olmalıdır!")]
    [Required(ErrorMessage = "Ad alanı boş girilemez")]
    public string Name { get; set; }
    

    [MaxLength(20, ErrorMessage = "En fazla 20 karakter girilebilir")]
    [Required(ErrorMessage = "Email alanı boş olamaz")]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",ErrorMessage ="Email adres uygun değil")]
    public string Email { get; set; }

    [Range(10,70,ErrorMessage ="Lütfen 10 ile 70 arasında bir değer giriniz")]
    [Required(ErrorMessage ="Lütfen yaş değerini giriniz")]
    public int Age{ get; set; } 

    // iki propery'nin değerinin birbirinin aynısı olması için yapılan validasyon 
    [Required]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Girilen değerler aynı değil")]
    public string ConfirmPassword { get; set; }
}