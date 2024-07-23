using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Builder.Extensions;

namespace BankTransactions.Models;

public class Transaction
{   
    [Key]
    public int TransactionId { get; set; }
    [Column (TypeName ="nvarchar(12)")]
    [DisplayName("Account Number")]
    [Required]
    [MaxLength(12,ErrorMessage ="Maximum 12 characters are allowed")]
    public string AccountNumber { get; set; }
    [Column (TypeName ="nvarchar(100)")]
    [DisplayName("Benificiary Name")]
    [Required]
    [MaxLength(12,ErrorMessage ="Maximum 100 characters are allowed")]

    public string BenificiaryName { get; set; }
    [Column (TypeName ="nvarchar(100)")]
    [DisplayName("Bank Name")]
    [Required]
    [MaxLength(12,ErrorMessage ="Maximum 100 characters are allowed")]
    public string BankName { get; set; }
    [Column (TypeName ="nvarchar(11)")]
    [DisplayName("SWIFT Code")]
    [Required]
    [MaxLength(12,ErrorMessage ="Maximum 11 characters are allowed")]
    public string SWIFTCode { get; set; }
    [Required]
    [DataType(DataType.Currency)]
    public decimal Amount { get; set; }
    [DisplayFormat (DataFormatString = "{0:dd MMM yyyy}")]
    public DateTime Date { get; set; }
}
