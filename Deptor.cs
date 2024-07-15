using System.Reflection.Metadata.Ecma335;

namespace Linq;

public class Debtor
{


    public string FullName { get; set; }
    public DateTime Birthday { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Adress { get; set; }
    public int Dept { get; set; }

    public Debtor(string fullName, DateTime birthday, string phone, string email, string adress, int dept)
    {
        FullName = fullName;
        Birthday = birthday;
        Phone = phone;
        Email = email;
        Adress = adress;
        Dept = dept;
    }

    public override string ToString() =>
        $"FullName:{FullName}\nBirthday:{Birthday}\nPhone:{Phone}\nEmail:{Email}\nAdress:{Adress}\nDebt:{Dept}";
        
        
        
}
