using System.ComponentModel.DataAnnotations;


namespace UmbracoProject1.Models
{
    public class SolicitudeschModel
    {
        [Display(Name = "名字", Description = "名字")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "输入你的名字")]
        [MaxLength(100, ErrorMessage = "不应超过 100 个字符")]
        public string Nombrech { get; set; }

        [Display(Name = "姓", Description = "姓")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "输入您的姓氏")]
        [DataType(DataType.Text, ErrorMessage = "输入您的姓氏")]
        [MaxLength(100, ErrorMessage = "不应超过 100 个字符")]
        public string Apellidoch { get; set; }

        [Display(Name = "企业", Description = "企业")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "进入公司")]
        [DataType(DataType.Text, ErrorMessage = "进入公司")]
        [MaxLength(100, ErrorMessage = "不应超过 100 个字符")]
        public string Empresach { get; set; }

        [Display(Name = "负责", Description = "负责")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "输入您的位置")]
        [DataType(DataType.Text, ErrorMessage = "输入您的位置")]
        [MaxLength(100, ErrorMessage = "不应超过 100 个字符")]
        public string Cargoch { get; set; }


        [Display(Name = "邮件 ", Description = "邮件 ")]
        [Required(ErrorMessage = "输入您的电子邮件")]
        [DataType(DataType.EmailAddress, ErrorMessage = "输入电子邮件")]
        public string Correoch { get; set; }

        [Display(Name = "电话 ", Description = "电话 ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "输入您的电话号码")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "输入电话号码")]
        [MaxLength(20, ErrorMessage = "输入您的电话号码")]
        public string Telefonoch { get; set; }

        [Display(Name = "消息", Description = "消息")]
        [Required(ErrorMessage = "输入您的留言")]
        [DataType(DataType.MultilineText, ErrorMessage = "输入消息")]
        [MaxLength(600, ErrorMessage = "不应超过 600 个字符")]
        public string Mensajech { get; set; }

        [Display(Name = "ReCaptcha", Description = "ReCaptcha")]
        [Required(ErrorMessage = "请填写 reCAPTCHA")]
        public string ReCaptcha { get; set; }
        public string Origench { get; set; }
    }
}
