using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDome
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

}

// Question 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TextInput
{
    public IList<char> list = new List<char>();

    public virtual void Add(char c)
    {
        list.Add(c);
    }

    public string GetValue()
    {
        string r = "";
        foreach (char l in list)
        {
            r = r + l;
        }
        return r;
    }
}

public class NumericInput : TextInput
{
    public override void Add(char c)
    {
        if (c < '0' || c > '9') { }
        else
            list.Add(c);
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}

public class AlertService
{
    private readonly IAlertDAO storage;

    //Constructor
    public AlertService(IAlertDAO alert)
    {
        storage = alert;
    }

    public Guid RaiseAlert()
    {
        return this.storage.AddAlert(DateTime.Now);
    }

    public DateTime GetAlertTime(Guid id)
    {
        return this.storage.GetAlert(id);
    }

    static void Main(string[] args)
    {
        IAlertDAO alertDao = new AlertDAO();
        AlertService alert = new AlertService(alertDao);
        Guid id = alert.RaiseAlert();
        Console.WriteLine(alert.GetAlertTime(id));
        Console.ReadKey();
    }
}

// question 2

public class AlertDAO : IAlertDAO
{
    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

    public Guid AddAlert(DateTime time)
    {
        Guid id = Guid.NewGuid();
        this.alerts.Add(id, time);
        return id;
    }

    public DateTime GetAlert(Guid id)
    {
        return this.alerts[id];
    }
}

public interface IAlertDAO
{
    Guid AddAlert(DateTime time);
    DateTime GetAlert(Guid id);
}
