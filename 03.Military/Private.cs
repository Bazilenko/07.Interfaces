using System;

public class Private : Soldier, IPrivate
{
	decimal salary;
	public Private(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
	{
		Salary = salary;
	}
	public decimal Salary { get; set; }
    public override string ToString()
    {
        return base.ToString() + ($"Salary: {0}",Salary:2F);
    }
}
