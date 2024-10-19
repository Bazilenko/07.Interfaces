using System;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
	public List<Private> privates;
    public LeutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
	{
		privates = new List<Private>();
	}
	public void AddPrivate(Private priv)
	{
		privates.Add(priv);
	}
    public override string ToString()
    {
        return base.ToString();
    }
    public decimal Salary {  get; set; } 
	public List<Private> Privates { get; set; }
}
